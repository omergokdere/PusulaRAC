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
    public partial class SoldVehiclesInfo : MetroFramework.Forms.MetroForm
    {
        public SoldVehiclesInfo()
        {
            InitializeComponent();
        }
        

        private void btnModify_Click(object sender, EventArgs e)
        {
            //tbPlate.Enabled = true;
            //tbBrand.Enabled = true;
            //tbModel.Enabled = true;
            //tbYear.Enabled = true;
            //tbColor.Enabled = true;
            //tbClass.Enabled = true;
            //tbInspDate.Enabled = true;
            //tbLicence.Enabled = true;
            //tbBP.Enabled = true;
            tbSP.Enabled = true;

            btnDelete.Enabled = false;
            btnBack.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VehicleOperations vop = new VehicleOperations();
            vop.Show();
            this.Hide();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbSP.Text == "" || Double.Parse(tbSP.Text) == 0.0)  // if emplyoee wants to return a car from sold vehicle list to vehicle list
            {
                SqlConnection con = new SqlConnection
                {
                    ConnectionString = @"Data Source=OG-PC;Initial Catalog=PusulaDB;Integrated Security=True"
                };
                SqlCommand dcmd = new SqlCommand("DELETE FROM tblSoldVehicles where Plate = '" + tbPlate.Text + "';", con);
                con.Open();
                dcmd.ExecuteNonQuery();
                con.Close();
                SqlCommand scmd = new SqlCommand("INSERT INTO tblVehicles(Plate,Brand,Model,Year,Color,Class,InspDate,Licence,BuyingPrice ) VALUES ('" + tbPlate.Text + "' ,'" + tbBrand.Text + "' ,'" + tbModel.Text + "' ,'" + tbYear.Text + "' ,'" + tbColor.Text + "' ,'" + tbClass.Text + "' ,'" + tbInspDate.Text + "' ,'" + tbLicence.Text + "' ,'" + tbBP.Text + "' );", con);
                con.Open();
                scmd.ExecuteNonQuery();

                MessageBox.Show("Arac Bilgisi Guncellenmistir !");
                VehicleOperations vop = new VehicleOperations();
                vop.Show();
                this.Hide();

            }
            else if (Double.Parse(tbSP.Text) > 0.000)
            {
                SqlConnection con = new SqlConnection
                {
                    ConnectionString = @"Data Source=OG-PC;Initial Catalog=PusulaDB;Integrated Security=True"
                };

                SqlCommand dcmd = new SqlCommand("UPDATE tblSoldVehicles SET Plate = '" + tbPlate.Text + "' , Brand = '" + tbBrand.Text + "' , Model = '" + tbModel.Text + "' , Year = '" + tbYear.Text + "' , Color = '" + tbColor.Text + "' , Class = '" + tbClass.Text + "' , InspDate = '" + tbInspDate.Text + "' , Licence = '" + tbLicence.Text + "' , BuyingPrice = '" + tbBP.Text + "' , SellingPrice = '" + tbSP.Text + "' where Plate = '" + tbPlate.Text + "';", con);
                con.Open();
                dcmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Arac Bilgisi Guncellenmistir !");
                VehicleOperations vop = new VehicleOperations();
                vop.Show();
                this.Hide();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kayidi Silmek Istediginizden Emin misiniz ?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection
                {
                    ConnectionString = @"Data Source=OG-PC;Initial Catalog=PusulaDB;Integrated Security=True"
                };

                SqlCommand dcmd = new SqlCommand("DELETE FROM tblSoldVehicles where Plate = '" + tbPlate.Text + "';", con);
                con.Open();
                dcmd.ExecuteNonQuery();
                con.Close();
                VehicleOperations vop = new VehicleOperations();
                vop.Show();
                this.Hide();

            } 
            else
            {

            }
        }
    }
}