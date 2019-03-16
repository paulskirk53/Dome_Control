using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dome_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ASCOM.GowerCDome.Dome GD = new ASCOM.GowerCDome.Dome();
        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBLName.Text = GD.Name;
            if(GD.Connected)
            {
                LBLConnected.Text = "Connected";
            }
            else
            {
                LBLConnected.Text = "awaiting connection";
            }
        }
        private void LBLName_Click(object sender, EventArgs e)
        {

        }

        private void BTNConnect_Click(object sender, EventArgs e)
        {
            try
            {
                GD.Connected = true;     //connect te two ports via the driver's method
            }
            catch
            {
                Exception ex;
            }

            if (GD.Connected)       // update the information label with connected status
            {
                LBLConnected.Text = "Connected";
            }
            else
            {
                LBLConnected.Text = "awaiting connection";
            }
        }
    }
}
