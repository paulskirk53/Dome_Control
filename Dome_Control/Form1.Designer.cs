namespace Dome_Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DOMEPicture = new System.Windows.Forms.PictureBox();
            this.ASCOMLogo = new System.Windows.Forms.PictureBox();
            this.LblShutter = new System.Windows.Forms.Label();
            this.LBLAzimuth = new System.Windows.Forms.Label();
            this.LBLShutterText = new System.Windows.Forms.Label();
            this.LBLAzimuthText = new System.Windows.Forms.Label();
            this.LBLSlewing = new System.Windows.Forms.Label();
            this.LBLHome = new System.Windows.Forms.Label();
            this.LBLPark = new System.Windows.Forms.Label();
            this.BTNGoto = new System.Windows.Forms.Button();
            this.BTNSync = new System.Windows.Forms.Button();
            this.TXTAzimuth = new System.Windows.Forms.TextBox();
            this.BTNOpen = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            this.LBLNudgeSize = new System.Windows.Forms.Label();
            this.TXTNudgeSize = new System.Windows.Forms.TextBox();
            this.BTNNudgeAntiClock = new System.Windows.Forms.Button();
            this.NudgeClockwise = new System.Windows.Forms.Button();
            this.BTNPark = new System.Windows.Forms.Button();
            this.BTNHome = new System.Windows.Forms.Button();
            this.BTNStop = new System.Windows.Forms.Button();
            this.LBLName = new System.Windows.Forms.Label();
            this.LBLConnected = new System.Windows.Forms.Label();
            this.BTNConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DOMEPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASCOMLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DOMEPicture
            // 
            this.DOMEPicture.ImageLocation = "C:\\Users\\Paul\\Desktop\\Observatory build\\Observatory.jpg";
            this.DOMEPicture.Location = new System.Drawing.Point(10, 11);
            this.DOMEPicture.Name = "DOMEPicture";
            this.DOMEPicture.Size = new System.Drawing.Size(143, 96);
            this.DOMEPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DOMEPicture.TabIndex = 0;
            this.DOMEPicture.TabStop = false;
            // 
            // ASCOMLogo
            // 
            this.ASCOMLogo.ImageLocation = "C:\\Users\\Paul\\Desktop\\ASCOMLogo\\ASCOM.png";
            this.ASCOMLogo.Location = new System.Drawing.Point(224, 11);
            this.ASCOMLogo.Name = "ASCOMLogo";
            this.ASCOMLogo.Size = new System.Drawing.Size(48, 56);
            this.ASCOMLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ASCOMLogo.TabIndex = 1;
            this.ASCOMLogo.TabStop = false;
            // 
            // LblShutter
            // 
            this.LblShutter.AutoSize = true;
            this.LblShutter.BackColor = System.Drawing.Color.Black;
            this.LblShutter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShutter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblShutter.Location = new System.Drawing.Point(15, 119);
            this.LblShutter.Name = "LblShutter";
            this.LblShutter.Size = new System.Drawing.Size(59, 18);
            this.LblShutter.TabIndex = 2;
            this.LblShutter.Text = "Shutter:";
            // 
            // LBLAzimuth
            // 
            this.LBLAzimuth.AutoSize = true;
            this.LBLAzimuth.BackColor = System.Drawing.Color.Black;
            this.LBLAzimuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAzimuth.Location = new System.Drawing.Point(15, 150);
            this.LBLAzimuth.Name = "LBLAzimuth";
            this.LBLAzimuth.Size = new System.Drawing.Size(110, 18);
            this.LBLAzimuth.TabIndex = 3;
            this.LBLAzimuth.Text = "Dome Azimuth:";
            // 
            // LBLShutterText
            // 
            this.LBLShutterText.AutoSize = true;
            this.LBLShutterText.BackColor = System.Drawing.Color.Black;
            this.LBLShutterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLShutterText.Location = new System.Drawing.Point(141, 119);
            this.LBLShutterText.Name = "LBLShutterText";
            this.LBLShutterText.Size = new System.Drawing.Size(12, 18);
            this.LBLShutterText.TabIndex = 4;
            this.LBLShutterText.Text = " ";
            // 
            // LBLAzimuthText
            // 
            this.LBLAzimuthText.AutoSize = true;
            this.LBLAzimuthText.BackColor = System.Drawing.Color.Black;
            this.LBLAzimuthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAzimuthText.Location = new System.Drawing.Point(141, 150);
            this.LBLAzimuthText.Name = "LBLAzimuthText";
            this.LBLAzimuthText.Size = new System.Drawing.Size(36, 18);
            this.LBLAzimuthText.TabIndex = 5;
            this.LBLAzimuthText.Text = "0.00";
            // 
            // LBLSlewing
            // 
            this.LBLSlewing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LBLSlewing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSlewing.ForeColor = System.Drawing.Color.Black;
            this.LBLSlewing.Location = new System.Drawing.Point(192, 99);
            this.LBLSlewing.Name = "LBLSlewing";
            this.LBLSlewing.Size = new System.Drawing.Size(80, 20);
            this.LBLSlewing.TabIndex = 6;
            this.LBLSlewing.Text = "Slewing";
            this.LBLSlewing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLHome
            // 
            this.LBLHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LBLHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHome.ForeColor = System.Drawing.Color.Black;
            this.LBLHome.Location = new System.Drawing.Point(192, 119);
            this.LBLHome.Name = "LBLHome";
            this.LBLHome.Size = new System.Drawing.Size(80, 20);
            this.LBLHome.TabIndex = 7;
            this.LBLHome.Text = "Home";
            this.LBLHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLPark
            // 
            this.LBLPark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LBLPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPark.ForeColor = System.Drawing.Color.Black;
            this.LBLPark.Location = new System.Drawing.Point(192, 139);
            this.LBLPark.Name = "LBLPark";
            this.LBLPark.Size = new System.Drawing.Size(80, 20);
            this.LBLPark.TabIndex = 8;
            this.LBLPark.Text = "Park";
            this.LBLPark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNGoto
            // 
            this.BTNGoto.ForeColor = System.Drawing.Color.Black;
            this.BTNGoto.Location = new System.Drawing.Point(18, 191);
            this.BTNGoto.Name = "BTNGoto";
            this.BTNGoto.Size = new System.Drawing.Size(77, 27);
            this.BTNGoto.TabIndex = 9;
            this.BTNGoto.Text = "Goto:";
            this.BTNGoto.UseVisualStyleBackColor = true;
            // 
            // BTNSync
            // 
            this.BTNSync.ForeColor = System.Drawing.Color.Black;
            this.BTNSync.Location = new System.Drawing.Point(19, 224);
            this.BTNSync.Name = "BTNSync";
            this.BTNSync.Size = new System.Drawing.Size(77, 27);
            this.BTNSync.TabIndex = 10;
            this.BTNSync.Text = "Sync:";
            this.BTNSync.UseVisualStyleBackColor = true;
            // 
            // TXTAzimuth
            // 
            this.TXTAzimuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAzimuth.Location = new System.Drawing.Point(120, 208);
            this.TXTAzimuth.Name = "TXTAzimuth";
            this.TXTAzimuth.Size = new System.Drawing.Size(57, 22);
            this.TXTAzimuth.TabIndex = 11;
            this.TXTAzimuth.Text = "0.0";
            this.TXTAzimuth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNOpen
            // 
            this.BTNOpen.ForeColor = System.Drawing.Color.Black;
            this.BTNOpen.Location = new System.Drawing.Point(195, 198);
            this.BTNOpen.Name = "BTNOpen";
            this.BTNOpen.Size = new System.Drawing.Size(77, 27);
            this.BTNOpen.TabIndex = 12;
            this.BTNOpen.Text = "Open";
            this.BTNOpen.UseVisualStyleBackColor = true;
            // 
            // BTNClose
            // 
            this.BTNClose.ForeColor = System.Drawing.Color.Black;
            this.BTNClose.Location = new System.Drawing.Point(195, 224);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(77, 27);
            this.BTNClose.TabIndex = 13;
            this.BTNClose.Text = "Close";
            this.BTNClose.UseVisualStyleBackColor = true;
            // 
            // LBLNudgeSize
            // 
            this.LBLNudgeSize.AutoSize = true;
            this.LBLNudgeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNudgeSize.Location = new System.Drawing.Point(25, 283);
            this.LBLNudgeSize.Name = "LBLNudgeSize";
            this.LBLNudgeSize.Size = new System.Drawing.Size(142, 16);
            this.LBLNudgeSize.TabIndex = 14;
            this.LBLNudgeSize.Text = "Nudge Size (Degrees)";
            // 
            // TXTNudgeSize
            // 
            this.TXTNudgeSize.Location = new System.Drawing.Point(173, 279);
            this.TXTNudgeSize.Name = "TXTNudgeSize";
            this.TXTNudgeSize.Size = new System.Drawing.Size(36, 20);
            this.TXTNudgeSize.TabIndex = 15;
            this.TXTNudgeSize.Text = "5.0";
            this.TXTNudgeSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTNNudgeAntiClock
            // 
            this.BTNNudgeAntiClock.ForeColor = System.Drawing.Color.Black;
            this.BTNNudgeAntiClock.Location = new System.Drawing.Point(28, 323);
            this.BTNNudgeAntiClock.Name = "BTNNudgeAntiClock";
            this.BTNNudgeAntiClock.Size = new System.Drawing.Size(88, 37);
            this.BTNNudgeAntiClock.TabIndex = 16;
            this.BTNNudgeAntiClock.Text = "Nudge \r\nAntiClockwise";
            this.BTNNudgeAntiClock.UseVisualStyleBackColor = true;
            // 
            // NudgeClockwise
            // 
            this.NudgeClockwise.ForeColor = System.Drawing.Color.Black;
            this.NudgeClockwise.Location = new System.Drawing.Point(193, 323);
            this.NudgeClockwise.Name = "NudgeClockwise";
            this.NudgeClockwise.Size = new System.Drawing.Size(79, 37);
            this.NudgeClockwise.TabIndex = 17;
            this.NudgeClockwise.Text = "Nudge \r\nClockwise";
            this.NudgeClockwise.UseVisualStyleBackColor = true;
            // 
            // BTNPark
            // 
            this.BTNPark.ForeColor = System.Drawing.Color.Black;
            this.BTNPark.Location = new System.Drawing.Point(193, 366);
            this.BTNPark.Name = "BTNPark";
            this.BTNPark.Size = new System.Drawing.Size(79, 37);
            this.BTNPark.TabIndex = 18;
            this.BTNPark.Text = "Park - 90";
            this.BTNPark.UseVisualStyleBackColor = true;
            // 
            // BTNHome
            // 
            this.BTNHome.ForeColor = System.Drawing.Color.Black;
            this.BTNHome.Location = new System.Drawing.Point(28, 366);
            this.BTNHome.Name = "BTNHome";
            this.BTNHome.Size = new System.Drawing.Size(88, 37);
            this.BTNHome.TabIndex = 19;
            this.BTNHome.Text = "Home";
            this.BTNHome.UseVisualStyleBackColor = true;
            this.BTNHome.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNStop
            // 
            this.BTNStop.BackColor = System.Drawing.Color.Maroon;
            this.BTNStop.ForeColor = System.Drawing.Color.Black;
            this.BTNStop.Location = new System.Drawing.Point(122, 330);
            this.BTNStop.Name = "BTNStop";
            this.BTNStop.Size = new System.Drawing.Size(65, 67);
            this.BTNStop.TabIndex = 20;
            this.BTNStop.Text = "Stop";
            this.BTNStop.UseVisualStyleBackColor = false;
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Location = new System.Drawing.Point(25, 415);
            this.LBLName.Name = "LBLName";
            this.LBLName.Size = new System.Drawing.Size(35, 13);
            this.LBLName.TabIndex = 21;
            this.LBLName.Text = "label1";
            this.LBLName.Click += new System.EventHandler(this.LBLName_Click);
            // 
            // LBLConnected
            // 
            this.LBLConnected.AutoSize = true;
            this.LBLConnected.Location = new System.Drawing.Point(170, 415);
            this.LBLConnected.Name = "LBLConnected";
            this.LBLConnected.Size = new System.Drawing.Size(78, 13);
            this.LBLConnected.TabIndex = 22;
            this.LBLConnected.Text = "Not connected";
            // 
            // BTNConnect
            // 
            this.BTNConnect.ForeColor = System.Drawing.Color.Black;
            this.BTNConnect.Location = new System.Drawing.Point(195, 175);
            this.BTNConnect.Name = "BTNConnect";
            this.BTNConnect.Size = new System.Drawing.Size(77, 27);
            this.BTNConnect.TabIndex = 23;
            this.BTNConnect.Text = "Connect";
            this.BTNConnect.UseVisualStyleBackColor = true;
            this.BTNConnect.Click += new System.EventHandler(this.BTNConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 460);
            this.Controls.Add(this.BTNConnect);
            this.Controls.Add(this.LBLConnected);
            this.Controls.Add(this.LBLName);
            this.Controls.Add(this.BTNStop);
            this.Controls.Add(this.BTNHome);
            this.Controls.Add(this.BTNPark);
            this.Controls.Add(this.NudgeClockwise);
            this.Controls.Add(this.BTNNudgeAntiClock);
            this.Controls.Add(this.TXTNudgeSize);
            this.Controls.Add(this.LBLNudgeSize);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.BTNOpen);
            this.Controls.Add(this.TXTAzimuth);
            this.Controls.Add(this.BTNSync);
            this.Controls.Add(this.BTNGoto);
            this.Controls.Add(this.LBLPark);
            this.Controls.Add(this.LBLHome);
            this.Controls.Add(this.LBLSlewing);
            this.Controls.Add(this.LBLAzimuthText);
            this.Controls.Add(this.LBLShutterText);
            this.Controls.Add(this.LBLAzimuth);
            this.Controls.Add(this.LblShutter);
            this.Controls.Add(this.ASCOMLogo);
            this.Controls.Add(this.DOMEPicture);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Gower Observatory Dome";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DOMEPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASCOMLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DOMEPicture;
        private System.Windows.Forms.PictureBox ASCOMLogo;
        private System.Windows.Forms.Label LblShutter;
        private System.Windows.Forms.Label LBLAzimuth;
        private System.Windows.Forms.Label LBLShutterText;
        private System.Windows.Forms.Label LBLAzimuthText;
        private System.Windows.Forms.Label LBLSlewing;
        private System.Windows.Forms.Label LBLHome;
        private System.Windows.Forms.Label LBLPark;
        private System.Windows.Forms.Button BTNGoto;
        private System.Windows.Forms.Button BTNSync;
        private System.Windows.Forms.TextBox TXTAzimuth;
        private System.Windows.Forms.Button BTNOpen;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.Label LBLNudgeSize;
        private System.Windows.Forms.TextBox TXTNudgeSize;
        private System.Windows.Forms.Button BTNNudgeAntiClock;
        private System.Windows.Forms.Button NudgeClockwise;
        private System.Windows.Forms.Button BTNPark;
        private System.Windows.Forms.Button BTNHome;
        private System.Windows.Forms.Button BTNStop;
        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.Label LBLConnected;
        private System.Windows.Forms.Button BTNConnect;
    }
}

