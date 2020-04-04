using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Person_Search.Events;
using System.Xml.Linq;

namespace Person_Search.Forms
{
    public partial class DeleteEntryWindow : Form
    {
        public EventHandler<DeleteEntryEventArgs> deleteEntryEvent;
        public DeleteEntryWindow()
        {
            InitializeComponent();
        }

        private void DeleteEntry_Click(object sender, EventArgs e)
        {
            try
            {
                deleteEntryEvent?.Invoke(this, new DeleteEntryEventArgs(employeeIDToDeelete.Text));
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelDelete_Click(object sender, EventArgs e) => this.Close();
    }
}
