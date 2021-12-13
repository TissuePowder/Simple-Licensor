namespace Serial_Maker
{
    partial class frmMain
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
        	this.stbBase = new System.Windows.Forms.TextBox();
        	this.stbPass = new System.Windows.Forms.TextBox();
        	this.btnGenerate = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.txtIdentifier = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// stbBase
        	// 
        	this.stbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        	this.stbBase.Location = new System.Drawing.Point(114, 59);
        	this.stbBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.stbBase.Name = "stbBase";
        	this.stbBase.Size = new System.Drawing.Size(358, 21);
        	this.stbBase.TabIndex = 0;
        	// 
        	// stbPass
        	// 
        	this.stbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        	this.stbPass.Location = new System.Drawing.Point(114, 102);
        	this.stbPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.stbPass.Name = "stbPass";
        	this.stbPass.Size = new System.Drawing.Size(358, 21);
        	this.stbPass.TabIndex = 1;
        	// 
        	// btnGenerate
        	// 
        	this.btnGenerate.Location = new System.Drawing.Point(16, 143);
        	this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.btnGenerate.Name = "btnGenerate";
        	this.btnGenerate.Size = new System.Drawing.Size(456, 28);
        	this.btnGenerate.TabIndex = 2;
        	this.btnGenerate.Text = "Generate";
        	this.btnGenerate.UseVisualStyleBackColor = true;
        	this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(16, 19);
        	this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(66, 17);
        	this.label1.TabIndex = 3;
        	this.label1.Text = "Indetifier:";
        	// 
        	// txtIdentifier
        	// 
        	this.txtIdentifier.Location = new System.Drawing.Point(114, 19);
        	this.txtIdentifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.txtIdentifier.MaxLength = 3;
        	this.txtIdentifier.Name = "txtIdentifier";
        	this.txtIdentifier.Size = new System.Drawing.Size(85, 22);
        	this.txtIdentifier.TabIndex = 4;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(16, 59);
        	this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(90, 17);
        	this.label2.TabIndex = 5;
        	this.label2.Text = "Hardware ID:";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(16, 102);
        	this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(76, 17);
        	this.label3.TabIndex = 6;
        	this.label3.Text = "Serial Key:";
        	// 
        	// frmMain
        	// 
        	this.AcceptButton = this.btnGenerate;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(493, 188);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.txtIdentifier);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.btnGenerate);
        	this.Controls.Add(this.stbPass);
        	this.Controls.Add(this.stbBase);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        	this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        	this.Name = "frmMain";
        	this.Text = "Simple Serial Maker";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

        #endregion

        private System.Windows.Forms.TextBox stbBase;
        private System.Windows.Forms.TextBox stbPass;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifier;
    }
}

