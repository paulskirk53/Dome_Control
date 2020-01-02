﻿using System;
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
        


        private void Form1_Load(object sender, EventArgs e)
        {
            
            LBLName.Text = GD.Name;
            

            if (GD.Connected) 
            {
                LBLConnected.Text = "Connected";
            }
            else
            {
                LBLConnected.Text = "Not connected";
            }
        }
        private void LBLName_Click(object sender, EventArgs e)
        {

        }

        private void BTNConnect_Click(object sender, EventArgs e)
        {
            try
            {
                 //i think we need this in addition to the line below
                
                 if (!GD.Connected)
                 {
                   GD.Connected = true;     //connect te two ports via the driver's method
                   SlewingTimer.Start();
                 }
                 else
                 {
                    MessageBox.Show("Already connected, just press O.K.","Dome Message");   //messagebox already connected just click ok
                 }
                 
                 
               // GD.Connected = true;     //connect te two ports via the driver's method
              //  MessageBox.Show("Test" + GD.Connected);
               // SlewingTimer.Start();
            }
            catch
            {
                Exception ex;
                MessageBox.Show("exception when trying to connect", "Dome message");
            }

            if (GD.Connected)       // update the information label with connected status
            {
                BTNConnect.Enabled = false;
                LBLConnected.Text = "Connected";
                btndisconnect.Enabled = true;
            }
            else
            {
                LBLConnected.Text = "awaiting connection";
            }
        }

        private void BTNOpen_Click(object sender, EventArgs e)
        {
            GD.OpenShutter();
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            GD.CloseShutter();
        }

        private void BTNHome_Click(object sender, EventArgs e)
        {
            GD.SlewToAzimuth(180.0);     
            // timer to check slewing
        }

        private void SlewingTimer_Tick(object sender, EventArgs e)
        {
            if (GD.Slewing)                                   //update the slewing label
            {
                
                LBLSlewing.Text = "Dome moving";
            }
            else
            {
                LBLSlewing.Text = "Dome Stationary";                //the property returns true/ false according to whether slewing
            }
                    LBLAzimuthText.Text = GD.Azimuth.ToString();            //update the aximuth information label

            //form substring 

            string str = GD.ShutterStatus.ToString();
            int startIndex = 7;
            int endIndex = str.Length - 7;
           lblshutterstate.Text  = "Shutter " + str.Substring(startIndex, endIndex);


           // LBLShutterText.Text = GD.ShutterStatus.ToString();
            LBLAzimuthText.Text = GD.Azimuth.ToString();
        }

        private void BTNGoto_Click(object sender, EventArgs e)
        {
            double Azrequest;
            double.TryParse(MTXTAzimuth.Text, out Azrequest);
            GD.SlewToAzimuth(Azrequest);
        }

        private void BTNPark_Click(object sender, EventArgs e)
        {
            GD.Park();                  // the dome parks.
        }

        private void BTNNudgeAntiClock_Click(object sender, EventArgs e)
        {
            double NudgeTo;
            double.TryParse(MTXTAzimuth.Text, out NudgeTo);
            GD.SlewToAzimuth(GD.Azimuth - NudgeTo);            // minus sign for anticlock nudge
        }

        private void NudgeClockwise_Click(object sender, EventArgs e)
        {
            double NudgeTo;
            double.TryParse(MTXTAzimuth.Text , out NudgeTo);
            GD.SlewToAzimuth(GD.Azimuth + NudgeTo);            // plus sign for clockwise nudge
        }

        private void btndisconnect_Click(object sender, EventArgs e)
        {
          if(  GD.Connected)
            {
                SlewingTimer.Enabled = false;
                GD.Connected = false;
                
            }
            LBLConnected.Text = "Not Connected";
            btndisconnect.Enabled = false;
            BTNConnect.Enabled = true;
        }

        private void BTNSync_Click(object sender, EventArgs e)
        {

        }

        private void btnsetpark_Click(object sender, EventArgs e)
        {
            
            GD.SetPark();
        }

        private void LBLSlewing_Click(object sender, EventArgs e)
        {

        }
    }
}
