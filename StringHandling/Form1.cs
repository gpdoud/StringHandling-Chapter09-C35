#nullable enable
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
            string? middlename = null;
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
            if (middlename == null) {
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
            string phoneNumber = txtPhoneNumber.Text.Replace("(", "");
            string digitsOnly = phoneNumber.Replace(")", "");
            digitsOnly = digitsOnly.Replace("-", "");
            digitsOnly = digitsOnly.Replace(" ", "");
            string standardFormat = digitsOnly.Substring(0, 3) + "-" 
                                  + digitsOnly.Substring(3, 3) + "-" 
                                  + digitsOnly.Substring(6);

            string message = string.Empty;
            message += $"Entered        :\t{txtPhoneNumber.Text}\n\n";
            message += $"Digits only    :\t{digitsOnly}\n\n";
            message += $"Standard format:\t{standardFormat}\n\n";
            MessageBox.Show(message, "Edit Phone Number");
        }

        // TODO: Add ToInitialCap method here

        private void btnExit_Click(object sender, System.EventArgs e) {
            this.Close();
        }

    }
}
