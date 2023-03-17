using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PusulaRAC
{
    public partial class LoginPage : MetroFramework.Forms.MetroForm
    {
        
        static int attempt = 3;
        MainMenu mainMenu = new MainMenu();
        

        public LoginPage()
        {
            InitializeComponent();
            

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (attempt == 0)  
            {
                lblLoginError.Text = ("3 Giris hakkinizi kullandiniz !!! Yoneticiye Basvurunuz !!!");
                return;
            }
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            SqlCommand scmd = new SqlCommand("select count (*) as cnt from tblUsers where username=@usr and password=@pwd", con);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", tbUser.Text);
            scmd.Parameters.AddWithValue("@pwd", tbPass.Text);
            con.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                //MessageBox.Show("Giris Basarili");
                mainMenu.Show();
                this.Hide();
            }

            else
            {


                MessageBox.Show("Giris Basarisiz !!!");
                --attempt;
                lblLoginError.Text = ("Son " + Convert.ToString(attempt) + " Deneme Hakkiniz ");
                tbUser.Clear();
                tbPass.Clear();
            }
            con.Close();
            //mainMenu.Show();
            //this.Hide();
        }

    }
    
}
