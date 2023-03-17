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
    public partial class AddClient : MetroFramework.Forms.MetroForm
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbSurname.Text == "" || tbID.Text == "" || tbAddress.Text == "" || tbEmail.Text == "" || tbLicenceID.Text == "" || tbPhoneNo.Text == "" || cbClientType.Text == "")
            {
                MessageBox.Show("Gerekli alanlari Doldurunuz !!!");

            }
            else
            {
                SqlConnection con = new SqlConnection
                {
                    ConnectionString = @"Data Source=OG-PC;Initial Catalog=PusulaDB;Integrated Security=True"
                };

                SqlCommand scmd = new SqlCommand("INSERT INTO tblVehicles(Plate,Brand,Model,Year,Color,Class,InspDate,Licence,BuyingPrice,SellingPrice ) VALUES ('" + tbName.Text + "' ,'" + tbSurname.Text + "' ,'" + tbID.Text + "' ,'" + tbAddress.Text + "' ,'" + tbEmail.Text + "' ,'" + tbLicenceID.Text + "' ,'" + tbPhoneNo.Text + "' ,'" + cbClientType.Text + "' ,'" + tbCompany.Text + "' ,'" + tbAddNote.Text + "');", con);
                con.Open();
                scmd.ExecuteNonQuery();

                ClientOperations clientOperations1 = new ClientOperations();
                this.Hide();
                clientOperations1.ShowDialog();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClientOperations clientOperations1 = new ClientOperations();
            this.Hide();
            clientOperations1.ShowDialog();

        }
    }
}
