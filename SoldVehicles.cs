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
    public partial class SoldVehicles : MetroFramework.Forms.MetroForm
    {
        public SoldVehicles()
        {
            InitializeComponent();
        }

        private void SoldVehicles_Load(object sender, EventArgs e)
        {
        }

        private void btnListV_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            string scmd = "select * from tblSoldVehicles where  ID > 0 ";



            using (SqlCommand cmdSQL = new SqlCommand())
            {
                if (!string.IsNullOrEmpty(tbSearchP.Text))
                {
                    scmd += " AND Plate Like @Plate";
                    cmdSQL.Parameters.Add("@Plate", SqlDbType.VarChar).Value = "%" + tbSearchP.Text + "%";
                }

                if (!string.IsNullOrEmpty(tbSearchB.Text))
                {
                    scmd += " AND Brand Like @Brand";
                    cmdSQL.Parameters.Add("@Brand", SqlDbType.VarChar).Value = "%" + tbSearchB.Text + "%";
                }

                if (!string.IsNullOrEmpty(tbSearchM.Text))
                {
                    scmd += " AND Model Like @Model";
                    cmdSQL.Parameters.Add("@Model", SqlDbType.VarChar).Value = "%" + tbSearchM.Text + "%";
                }

                if (!string.IsNullOrEmpty(tbSearchY.Text))
                {
                    scmd += " AND Year Like @Year";
                    cmdSQL.Parameters.Add("@Year", SqlDbType.VarChar).Value = "%" + tbSearchY.Text + "%";
                }
                // Add rest of conditions here like this

                cmdSQL.CommandText = scmd;
                cmdSQL.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmdSQL);
                SqlCommandBuilder cb = new SqlCommandBuilder();
                DataSet ds = new DataSet();
                da.Fill(ds);

                gvListV.DataSource = ds.Tables[0];
            }

        }

       

        //private void gvListVMDClick(object sender, MouseEventArgs e)
        //{
        //    SqlConnection con = new SqlConnection
        //    {
        //        ConnectionString = @"Data Source=OG-PC;Initial Catalog=PusulaDB;Integrated Security=True"
        //    };
        //    SqlCommand command = new SqlCommand("Select * from tblSoldVehicles where Plate = @plate", con);
        //    command.Parameters.AddWithValue("@plate", gvListV.CurrentRow.Cells[0].Value.ToString());
        //    con.Open();
        //    SqlDataAdapter da = new SqlDataAdapter(command);
        //    SqlCommandBuilder cb = new SqlCommandBuilder();
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);


        //    SoldVehiclesInfo vInfo = new SoldVehiclesInfo();
        //    vInfo.Show();
        //    vInfo.tbPlate.Text = ds.Tables[0].Rows[0][1].ToString();
        //    vInfo.tbBrand.Text = ds.Tables[0].Rows[0][2].ToString();
        //    vInfo.tbModel.Text = ds.Tables[0].Rows[0][3].ToString();
        //    vInfo.tbYear.Text = ds.Tables[0].Rows[0][4].ToString();
        //    vInfo.tbColor.Text = ds.Tables[0].Rows[0][5].ToString();
        //    vInfo.tbClass.Text = ds.Tables[0].Rows[0][6].ToString();
        //    vInfo.tbInspDate.Text = ds.Tables[0].Rows[0][7].ToString();
        //    vInfo.tbLicence.Text = ds.Tables[0].Rows[0][8].ToString();
        //    vInfo.tbBP.Text = ds.Tables[0].Rows[0][9].ToString();
        //    vInfo.tbSP.Text = ds.Tables[0].Rows[0][10].ToString();

        //    vInfo.tbPlate.Enabled = false;
        //    vInfo.tbBrand.Enabled = false;
        //    vInfo.tbModel.Enabled = false;
        //    vInfo.tbYear.Enabled = false;
        //    vInfo.tbColor.Enabled = false;
        //    vInfo.tbClass.Enabled = false;
        //    vInfo.tbInspDate.Enabled = false;
        //    vInfo.tbLicence.Enabled = false;
        //    vInfo.tbBP.Enabled = false;
        //    vInfo.tbSP.Enabled = false;
        //    vInfo.btnSave.Enabled = false;
        //}

        private void gvListVMDClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("Select * from tblSoldVehicles where Plate = @plate", con);
            command.Parameters.AddWithValue("@plate", gvListV.CurrentRow.Cells[0].Value.ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            SqlCommandBuilder cb = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            da.Fill(ds);


            SoldVehiclesInfo vInfo = new SoldVehiclesInfo();
            vInfo.Show();
            vInfo.tbPlate.Text = ds.Tables[0].Rows[0][1].ToString();
            vInfo.tbBrand.Text = ds.Tables[0].Rows[0][2].ToString();
            vInfo.tbModel.Text = ds.Tables[0].Rows[0][3].ToString();
            vInfo.tbYear.Text = ds.Tables[0].Rows[0][4].ToString();
            vInfo.tbColor.Text = ds.Tables[0].Rows[0][5].ToString();
            vInfo.tbClass.Text = ds.Tables[0].Rows[0][6].ToString();
            vInfo.tbInspDate.Text = ds.Tables[0].Rows[0][7].ToString();
            vInfo.tbLicence.Text = ds.Tables[0].Rows[0][8].ToString();
            vInfo.tbBP.Text = ds.Tables[0].Rows[0][9].ToString();
            vInfo.tbSP.Text = ds.Tables[0].Rows[0][10].ToString();

            vInfo.tbPlate.Enabled = false;
            vInfo.tbBrand.Enabled = false;
            vInfo.tbModel.Enabled = false;
            vInfo.tbYear.Enabled = false;
            vInfo.tbColor.Enabled = false;
            vInfo.tbClass.Enabled = false;
            vInfo.tbInspDate.Enabled = false;
            vInfo.tbLicence.Enabled = false;
            vInfo.tbBP.Enabled = false;
            vInfo.tbSP.Enabled = false;
            vInfo.btnSave.Enabled = false;
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            VehicleOperations vop = new VehicleOperations();
            vop.ShowDialog();
            this.Hide();
        }
    }

}
