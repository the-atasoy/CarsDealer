using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class AddUserPanel : Form
    {
        public AddUserPanel()
        {
            InitializeComponent();
        }

        private void AddUserPanel_Load(object sender, EventArgs e)
        {
            string savedUsername = UserCredentials.Username;
            string savedPassword = UserCredentials.Password;
        }
    }
}
