using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PusulaRAC
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
        
    {
        VehicleOperations vehicleOperations = new VehicleOperations();
        ClientOperations clientOperations = new ClientOperations();

        public MainMenu()
        {
            InitializeComponent();
            btnVehOP.ForeColor = Color.Orange;
                

        }

        private void btnVehOP_Click(object sender, EventArgs e)
        {
            vehicleOperations.Show();
            this.Hide();
        }

        private void btnCliOp_Click(object sender, EventArgs e)
        {
            clientOperations.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
