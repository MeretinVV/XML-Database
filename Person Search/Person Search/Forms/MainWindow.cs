using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Person_Search.Events;
using Person_Search.Forms;


namespace Person_Search
{
    public partial class MainWindow : Form
    {
        private FilterChangeEventArgs _currentFilterArgs;
        private XDocument _data;
        private List<string> _filteredEmployeesIDs;

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                LoadData();
                ClearFilter();
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Reload application after fixing the error.");
                Environment.Exit(-1);
            }

        }

        private void SetFilterBtn_Click(object sender, EventArgs e)
        {
            var filterWindow = new FilterWindow(_data, _currentFilterArgs);
            filterWindow.FilterChangeEvent += new EventHandler<FilterChangeEventArgs>(this.OnFilterChange);
            filterWindow.ShowDialog();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            var addEntryWindow = new AddEntryWindow();
            addEntryWindow.InsertEntryEvent += new EventHandler<InsertEntryEventArgs>(this.OnInsertEntry);
            addEntryWindow.ShowDialog();
        }

        private void OnFilterChange(object sender, FilterChangeEventArgs e)
        {
            _currentFilterArgs = e;
            ApplyFilter();
            ShowData();
        }

        private void OnInsertEntry(object sender, InsertEntryEventArgs e)
        {
            // Проверяем корректность введенных данных
            float fnum; 
            uint daysWorked, totalWorkDays;
            if (e.EmployeeID == string.Empty || e.DepartmentID == string.Empty || e.LastName == string.Empty
                || e.Salary == string.Empty) throw new ArgumentException("All necessary fields (*) must be filled");
            foreach (XElement person in _data.Element("People").Elements("Person"))
            {
                if (person.Element("Employee_ID").Value == e.EmployeeID) throw new ArgumentException(
                    "An entry with this employee ID already exists!");
            }
            if (!float.TryParse(e.Salary, out fnum)) throw new ArgumentException("Salary input must be numerical!");
            if (!float.TryParse(e.ComissionPercent, out fnum)) throw new ArgumentException("Comission percent input must be numerical!");
            if (fnum > 100) throw new ArgumentException("Comission percent cannot be more than 100!");
            if (!float.TryParse(e.IncomeTax, out fnum)) throw new ArgumentException("Income tax input must be numerical!");
            if (fnum > 100) throw new ArgumentException("Income tax cannot be more than 100!");
            if (!uint.TryParse(e.DaysWorked, out daysWorked)) throw new ArgumentException("Days worked input must be numerical!");
            if (!uint.TryParse(e.WorkDaysTotal, out totalWorkDays)) throw new ArgumentException("Total work days input must be numerical!");
            if (totalWorkDays > 31) throw new ArgumentException("Total work days input cannot be more than 31!");
            if (daysWorked > totalWorkDays) throw new ArgumentException("Days worked input cannot be more than total work days input!");
            if (!float.TryParse(e.MoneyCredited, out fnum)) throw new ArgumentException("Money credited input must be numerical!");
            if (!float.TryParse(e.MoneyWithheld, out fnum)) throw new ArgumentException("Money withheld input must be numerical!");
            if (float.Parse(e.Salary) > float.Parse(e.MoneyCredited) + float.Parse(e.MoneyWithheld))
                throw new ArgumentException("The sum of money credited and money withheld cannot be smaller than salary!");

            // Пройдя все проверки, добавляем запись
            _data.Element("People").Add(new XElement("Person",
                new XElement("Employee_ID", e.EmployeeID),
                new XElement("Department_ID", e.DepartmentID),
                new XElement("Last_Name", e.LastName),
                new XElement("Sex", e.Sex),
                new XElement("Salary", e.Salary),
                new XElement("Hire_Date", e.HireDate),
                new XElement("Comission_Percent", e.ComissionPercent),
                new XElement("Income_Tax", e.IncomeTax),
                new XElement("Days_Worked", e.DaysWorked),
                new XElement("Work_Days_Total", e.WorkDaysTotal),
                new XElement("Money_Credited", e.MoneyCredited),
                new XElement("Money_Withheld", e.MoneyWithheld)));
            if (!(_currentFilterArgs is null)) ApplyFilter();
            ShowData();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var deleteEntryWindow = new DeleteEntryWindow();
            deleteEntryWindow.deleteEntryEvent += new EventHandler<DeleteEntryEventArgs>(OnDeleteEntry);
            deleteEntryWindow.ShowDialog();
        }

        private void OnDeleteEntry(object sender, DeleteEntryEventArgs e)
        {
            string idToDelete = e.EmployeeID;
            foreach (XElement person in _data.Element("People").Elements("Person"))
            {
                if (person.Element("Employee_ID").Value == idToDelete)
                {
                    person.Remove();
                    ApplyFilter();
                    ShowData();
                    return;
                }
            }

            throw new ArgumentException("No entry with fitting employee ID");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFilter();
            ShowData();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _data.Save("DATA.xml");
                MessageBox.Show("All changes were saved!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CancelChangesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                ApplyFilter();
                ShowData();
                MessageBox.Show("All changes were canceled! (Filter settings are not affected)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Load the data from the file
        /// </summary>
        private void LoadData() => _data = XDocument.Load("DATA.xml");

        /// <summary>
        /// Clears the filter
        /// </summary>
        private void ClearFilter()
        {
            _currentFilterArgs = new FilterChangeEventArgs();
            ApplyFilter();
        }

        /// <summary>
        /// Shows the current data on the screen with filter applied
        /// </summary>
        private void ShowData()
        {
            StringBuilder txt = new StringBuilder();

            foreach (XElement person in from person in _data.Element("People").Elements("Person")
                                        where _filteredEmployeesIDs.Contains(person.Element("Employee_ID").Value)
                                        select person)
            {
                foreach (XElement dataField in person.Elements())
                {
                    txt.Append($"{dataField.Name.ToString().Replace('_', ' ')}: {dataField.Value}\r\n");
                }
                txt.Append("\r\n");
            }

            tableView.Text = txt.ToString();
        }

        /// <summary>
        /// Applies existing filter to the data
        /// </summary>
        private void ApplyFilter()
        {
            try
            {
                _filteredEmployeesIDs =
                (from person in _data.Element("People").Elements("Person")
                 where person.Element("Department_ID").Value.Contains(_currentFilterArgs.DepartmentID)
                  && person.Element("Last_Name").Value.ToLower().Contains(_currentFilterArgs.LastName.ToLower())
                  && person.Element("Hire_Date").Value.Contains(_currentFilterArgs.HireDate)
                  && person.Element("Sex").Value.Contains(_currentFilterArgs.Sex)
                 select person.Element("Employee_ID").Value).ToList();
            }
            catch(NullReferenceException)
            {
                throw new FormatException("The data have incorrect format.Some entries might be missing " +
                    "at least one of the following key elements: Employee_ID, Department_ID, Last_Name, Hire_Date, Sex.");
            }
        }
    }
}
