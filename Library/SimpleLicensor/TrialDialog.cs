using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace SimpleLicensor
{
    public partial class TrialDialog : Form
    {
        private string _Pass, _Server;
        private bool _CheckOnline;

        public TrialDialog(string BaseString,
            string Password,int DaysToEnd,int Runed, string info, bool CheckOnline, string Server)
        {
            InitializeComponent();
            HardwareID.Text = BaseString;
            _Pass = Password;
            _CheckOnline = CheckOnline;
            _Server = Server;
            lblDays.Text = DaysToEnd.ToString() + " Day(s)";
            if (DaysToEnd <= 0)
            {
                lblDays.Text = "Finished";
                btnTrial.Enabled = false;
            }

            SerialKey.Select();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
        	
        	if (_CheckOnline == true) {
        		
        		var url = _Server + SerialKey.Text;
        		//MessageBox.Show(url);

				var request = WebRequest.Create(url);
				request.Method = "GET";
				
				var webResponse = request.GetResponse();
				var webStream = webResponse.GetResponseStream();
				
				var reader = new StreamReader(webStream);
				string data = reader.ReadToEnd();
				string _type = "", _duration = "", _condition = "";
				//MessageBox.Show(data);
				if(data != ""){
					data = data.Replace("\"", "").Replace("{", "").Replace("}", "");
					string[] arr = data.Split(',');
					for(int i=0; i<arr.Length; ++i){
						if(arr[i].Contains("type")){
						   	_type = arr[i].Split(':')[1];
						}
						if(arr[i].Contains("duration")){
						   	_duration = arr[i].Split(':')[1];
						}
						if(arr[i].Contains("condition")){
						   	_condition = arr[i].Split(':')[1];
						}
					}
					
					if(_condition == "blacklisted"){
						MessageBox.Show("This key has been blacklisted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						
					}
					else if(_condition == "expired"){
						MessageBox.Show("License has been expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						
					}
					
					else{
						
						string message = "You have activated " + _type + " license for " + _duration + " days!";
						MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.DialogResult = DialogResult.OK;
						
					}
					
					
					
					
					
				}
				else {
					MessageBox.Show("Invalid serial key entered", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
				
        	}
        	
        	else {
        		
        		if (_Pass == SerialKey.Text)
            {
                MessageBox.Show("Successfully registered!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Invalid serial key entered", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        		
        	}
        	
        	
            
        }

        private void btnTrial_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }
    }
}