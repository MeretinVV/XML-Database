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

namespace Person_Search.Forms
{
    public partial class AddEntryWindow : Form
    {
        public event EventHandler<InsertEntryEventArgs> InsertEntryEvent;

        public AddEntryWindow()
        {
            InitializeComponent();
        }

        private void insertEntry_Click(object sender, EventArgs e)
        {   
            try
            {
                InsertEntryEvent?.Invoke(this, new InsertEntryEventArgs(
                    newEmployeeID.Text,
                    newDepartmentID.Text,
                    newLastName.Text,
                    newSex.SelectedItem != null ? newSex.SelectedItem.ToString() : string.Empty,
                    newSalary.Text,
                    newHireDate.Value.ToShortDateString(),
                    newComissionPercent.Text,
                    newIncomeTax.Text,
                    newDaysWorked.Text,
                    newWorkDaysTotal.Text,
                    newMoneyCredited.Text,
                    newMoneyWithheld.Text));
                this.Close();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelInsert_Click(object sender, EventArgs e) => this.Close();
    }
}
