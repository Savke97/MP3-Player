using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_Player.Forms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void logInBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.logInBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.log_InDataSet);

        }
    }
}
