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
    public partial class operations : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5OBQPE3;Initial Catalog=theshop;Integrated Security=True");
        SqlCommand cmd;

        public operations(string ID)
        {
            InitializeComponent();
            if (ID == "12345")
            {
                emName.Text = "mohamed";
                emPhoneNum.Text="0114566";
                emId.Text = "12345";
                emAddress.Text = "151eltawfik street";
            }
  
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void emPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void emId_TextChanged(object sender, EventArgs e)
        {

        }

        private void emName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Data Source = DESKTOP - 5OBQPE3; Initial Catalog = theshop; Integrated Security = True
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query2 = "insert into bedo values(' " + itemCode.Text + "','" + itemName.Text + "','" + itemCost.Text + "','" + itemcategory + "')";
                cmd = new SqlCommand(query2, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message,"error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                con.Close();
            }
                
                

        }

        private void itemCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemcategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string query2 = "insert into bedo values(' " + itemCode.Text + "','" + itemName.Text + "','" + itemCost.Text + "','" + itemcategory + "')";
                cmd = new SqlCommand(query2, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        private void operations_Load(object sender, EventArgs e)
        {

        }
    }
}
