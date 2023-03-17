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
    public partial class VehicleInfo : MetroFramework.Forms.MetroForm
    {
        public VehicleInfo()
        {
            InitializeComponent();
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            tbPlate.Enabled = true;
            tbBrand.Enabled = true;
            tbModel.Enabled = true;
            tbYear.Enabled = true;
            tbColor.Enabled = true;
            tbClass.Enabled = true;
            tbInspDate.Enabled = true;
            tbLicence.Enabled = true;
            tbBP.Enabled = true;
            tbSP.Enabled = true;

            btnDelete.Enabled = false;
            btnBack.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = true;
            lblPlateHolder.Text = tbPlate.Text;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPlate.Text == "" || tbBrand.Text == "" || tbModel.Text == "" || tbYear.Text == "" || tbColor.Text == "" || tbClass.Text == "" || tbInspDate.Text == "" || tbLicence.Text == "" || tbBP.Text == "" || tbBD.Text == "")
            {
                MessageBox.Show("Gerekli alanlari Doldurunuz !");

            }
            else if ( tbSP.Text == "" || Double.Parse(tbSP.Text) == 0.0)
            {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                SqlCommand dcmd = new SqlCommand("UPDATE tblVehicles SET Plate = '" + tbPlate.Text + "' , Brand = '" + tbBrand.Text + "' , Model = '" + tbModel.Text + "' , Year = '" + tbYear.Text + "' , Color = '" + tbColor.Text + "' , Class = '" + tbClass.Text + "' , InspDate = '" + tbInspDate.Text + "' , Licence = '" + tbLicence.Text + "' , BuyingPrice = '" + tbBP.Text + "' , SellingPrice = '" + tbSP.Text + "', BuyingPrice = '" + tbBD.Text + "' , SellingPrice = '" + tbSD.Text + "' where Plate = '" + lblPlateHolder.Text + "';", con);
                con.Open();
                dcmd.ExecuteNonQuery();
                con.Close();
                //SqlCommand scmd = new SqlCommand("INSERT INTO tblVehicles(Plate,Brand,Model,Year,Color,Class,InspDate,Licence,BuyingPrice,SellingPrice ) VALUES ('" + tbPlate.Text + "' ,'" + tbBrand.Text + "' ,'" + tbModel.Text + "' ,'" + tbYear.Text + "' ,'" + tbColor.Text + "' ,'" + tbClass.Text + "' ,'" + tbInspDate.Text + "' ,'" + tbLicence.Text + "' ,'" + tbBP.Text + "' ,'" + tbSP.Text + "');", con);
                //con.Open();
                //scmd.ExecuteNonQuery();

                MessageBox.Show("Arac Bilgisi Guncellenmistir !");
                this.Hide();
            }
            else if (Double.Parse(tbSP.Text) > 0.0 || tbSD.Text != "")
            {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                SqlCommand dcmd = new SqlCommand("DELETE FROM tblVehicles where Plate = '" + tbPlate.Text + "';", con);
                con.Open();
                dcmd.ExecuteNonQuery();
                con.Close();
                SqlCommand scmd = new SqlCommand("INSERT INTO tblSoldVehicles(Plate,Brand,Model,Year,Color,Class,InspDate,Licence,BuyingPrice,SellingPrice ) VALUES ('" + tbPlate.Text + "' ,'" + tbBrand.Text + "' ,'" + tbModel.Text + "' ,'" + tbYear.Text + "' ,'" + tbColor.Text + "' ,'" + tbClass.Text + "' ,'" + tbInspDate.Text + "' ,'" + tbLicence.Text + "' ,'" + tbBP.Text + "' ,'" + tbSP.Text + "');", con);
                con.Open();
                scmd.ExecuteNonQuery();

                MessageBox.Show("Arac Bilgisi Guncellenmistir !");
                this.Hide();

            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kayidi Silmek Istediginizden Emin misiniz ?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                SqlCommand dcmd = new SqlCommand("DELETE FROM tblVehicles where Plate = '" + tbPlate.Text + "';", con);
                con.Open();
                dcmd.ExecuteNonQuery();
                con.Close();
                this.Hide();

            }
            else
            {

            }
        }
    }
}
