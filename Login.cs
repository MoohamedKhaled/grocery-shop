using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HCIproject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void loginbut_Click(object sender, EventArgs e)
        {
             if (idTxt.Text == "12345")
             {
                 operations f1 = new operations(idTxt.Text);
                 f1.Show();
             }
             else
                 MessageBox.Show("this ID ancorerct");
             idTxt.Clear();
           // this.Hide();
        }
    }
}
