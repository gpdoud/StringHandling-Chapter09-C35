using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnParseName_Click(object sender, System.EventArgs e) {
            // TODO: Add code to parse name
            string[] nameParts = txtFullName.Text.Split(" ");
            string firstname = nameParts[0];
            string middlename = string.Empty;
            string lastname = string.Empty;
            if (nameParts.Length == 3) {
                middlename = nameParts[1];
                lastname = nameParts[2];
            } else {
                lastname = nameParts[1];
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("First name:\t");
            sb.AppendLine(firstname.Substring(0, 1).ToUpper() + firstname.Substring(1));
            sb.Append("Middle name:\t");
            if (middlename.Length == 0) {
                sb.AppendLine();
            } else {
                sb.AppendLine(middlename.Substring(0, 1).ToUpper() + middlename.Substring(1));
            }
            sb.Append("Last name:\t");
            sb.AppendLine(lastname.Substring(0, 1).ToUpper() + lastname.Substring(1));
            MessageBox.Show(sb.ToString(), "Parse Name");
        }

        private void btnEditPhoneNumber_Click(object sender, System.EventArgs e) {
            // TODO: Add code to edit the phone number
        }

        // TODO: Add ToInitialCap method here

        private void btnExit_Click(object sender, System.EventArgs e) {
            this.Close();
        }

    }
}
