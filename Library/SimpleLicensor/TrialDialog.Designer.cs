namespace SimpleLicensor
{
    partial class TrialDialog
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
        	this.btnOK = new System.Windows.Forms.Button();
        	this.btnTrial = new System.Windows.Forms.Button();
        	this.grbRegister = new System.Windows.Forms.GroupBox();
        	this.lblSerial = new System.Windows.Forms.Label();
        	this.lblID = new System.Windows.Forms.Label();
        	this.lblComment = new System.Windows.Forms.Label();
        	this.lblDaysToEnd = new System.Windows.Forms.Label();
        	this.lblDays = new System.Windows.Forms.Label();
        	this.grbTrialRunning = new System.Windows.Forms.GroupBox();
        	this.HardwareID = new System.Windows.Forms.TextBox();
        	this.SerialKey = new System.Windows.Forms.TextBox();
        	this.grbRegister.SuspendLayout();
        	this.grbTrialRunning.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// btnOK
        	// 
        	this.btnOK.Location = new System.Drawing.Point(176, 123);
        	this.btnOK.Margin = new System.Windows.Forms.Padding(4);
        	this.btnOK.Name = "btnOK";
        	this.btnOK.Size = new System.Drawing.Size(100, 28);
        	this.btnOK.TabIndex = 5;
        	this.btnOK.Text = "&OK";
        	this.btnOK.UseVisualStyleBackColor = true;
        	this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
        	// 
        	// btnTrial
        	// 
        	this.btnTrial.Location = new System.Drawing.Point(275, 32);
        	this.btnTrial.Margin = new System.Windows.Forms.Padding(4);
        	this.btnTrial.Name = "btnTrial";
        	this.btnTrial.Size = new System.Drawing.Size(132, 28);
        	this.btnTrial.TabIndex = 2;
        	this.btnTrial.Text = "Trial Run";
        	this.btnTrial.UseVisualStyleBackColor = true;
        	this.btnTrial.Click += new System.EventHandler(this.btnTrial_Click);
        	// 
        	// grbRegister
        	// 
        	this.grbRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.grbRegister.Controls.Add(this.SerialKey);
        	this.grbRegister.Controls.Add(this.HardwareID);
        	this.grbRegister.Controls.Add(this.lblSerial);
        	this.grbRegister.Controls.Add(this.lblID);
        	this.grbRegister.Controls.Add(this.btnOK);
        	this.grbRegister.Location = new System.Drawing.Point(16, 85);
        	this.grbRegister.Margin = new System.Windows.Forms.Padding(4);
        	this.grbRegister.Name = "grbRegister";
        	this.grbRegister.Padding = new System.Windows.Forms.Padding(4);
        	this.grbRegister.Size = new System.Drawing.Size(423, 174);
        	this.grbRegister.TabIndex = 1;
        	this.grbRegister.TabStop = false;
        	this.grbRegister.Text = "Registration Info";
        	// 
        	// lblSerial
        	// 
        	this.lblSerial.AutoSize = true;
        	this.lblSerial.Location = new System.Drawing.Point(21, 82);
        	this.lblSerial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblSerial.Name = "lblSerial";
        	this.lblSerial.Size = new System.Drawing.Size(76, 17);
        	this.lblSerial.TabIndex = 3;
        	this.lblSerial.Text = "Serial Key:";
        	// 
        	// lblID
        	// 
        	this.lblID.AutoSize = true;
        	this.lblID.Location = new System.Drawing.Point(21, 44);
        	this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblID.Name = "lblID";
        	this.lblID.Size = new System.Drawing.Size(90, 17);
        	this.lblID.TabIndex = 1;
        	this.lblID.Text = "Hardware ID:";
        	// 
        	// lblComment
        	// 
        	this.lblComment.Location = new System.Drawing.Point(16, 11);
        	this.lblComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblComment.Name = "lblComment";
        	this.lblComment.Size = new System.Drawing.Size(423, 53);
        	this.lblComment.TabIndex = 0;
        	this.lblComment.Text = "To use this application, you must buy it.\r\nBefore buying, you can run application" +
        	" as trial. in trial mode some parts may be inactive and after buying they will b" +
        	"e active";
        	// 
        	// lblDaysToEnd
        	// 
        	this.lblDaysToEnd.AutoSize = true;
        	this.lblDaysToEnd.Location = new System.Drawing.Point(12, 27);
        	this.lblDaysToEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblDaysToEnd.Name = "lblDaysToEnd";
        	this.lblDaysToEnd.Size = new System.Drawing.Size(159, 17);
        	this.lblDaysToEnd.TabIndex = 3;
        	this.lblDaysToEnd.Text = "Days to end trial period:";
        	// 
        	// lblDays
        	// 
        	this.lblDays.AutoSize = true;
        	this.lblDays.ForeColor = System.Drawing.Color.Red;
        	this.lblDays.Location = new System.Drawing.Point(176, 27);
        	this.lblDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblDays.Name = "lblDays";
        	this.lblDays.Size = new System.Drawing.Size(48, 17);
        	this.lblDays.TabIndex = 4;
        	this.lblDays.Text = "[Days]";
        	// 
        	// grbTrialRunning
        	// 
        	this.grbTrialRunning.Controls.Add(this.lblDaysToEnd);
        	this.grbTrialRunning.Controls.Add(this.lblDays);
        	this.grbTrialRunning.Controls.Add(this.btnTrial);
        	this.grbTrialRunning.Location = new System.Drawing.Point(16, 291);
        	this.grbTrialRunning.Margin = new System.Windows.Forms.Padding(4);
        	this.grbTrialRunning.Name = "grbTrialRunning";
        	this.grbTrialRunning.Padding = new System.Windows.Forms.Padding(4);
        	this.grbTrialRunning.Size = new System.Drawing.Size(423, 91);
        	this.grbTrialRunning.TabIndex = 8;
        	this.grbTrialRunning.TabStop = false;
        	this.grbTrialRunning.Text = "Trial Running";
        	// 
        	// sebBaseString
        	// 
        	this.HardwareID.Location = new System.Drawing.Point(118, 44);
        	this.HardwareID.Name = "sebBaseString";
        	this.HardwareID.Size = new System.Drawing.Size(250, 22);
        	this.HardwareID.TabIndex = 6;
        	// 
        	// sebPassword
        	// 
        	this.SerialKey.Location = new System.Drawing.Point(118, 82);
        	this.SerialKey.Name = "sebPassword";
        	this.SerialKey.Size = new System.Drawing.Size(250, 22);
        	this.SerialKey.TabIndex = 7;
        	// 
        	// frmDialog
        	// 
        	this.AcceptButton = this.btnOK;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(455, 404);
        	this.Controls.Add(this.lblComment);
        	this.Controls.Add(this.grbTrialRunning);
        	this.Controls.Add(this.grbRegister);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "frmDialog";
        	this.Text = "Regitration Dialog";
        	this.grbRegister.ResumeLayout(false);
        	this.grbRegister.PerformLayout();
        	this.grbTrialRunning.ResumeLayout(false);
        	this.grbTrialRunning.PerformLayout();
        	this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox HardwareID;
        private System.Windows.Forms.TextBox SerialKey;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnTrial;
        private System.Windows.Forms.GroupBox grbRegister;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDaysToEnd;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.GroupBox grbTrialRunning;

    }
}