using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payrollProgram
{
    public partial class formSignIn : Form
    {
        private string uName, password;
        public formSignIn()
        {
            //image path for the image used inn sign in
            InitializeComponent();
            Image logo = Image.FromFile("D:\\Documents\\John Daryll\\2nd year college\\2nd semester\\INTEGRATIVE PROGRAMMING\\cafeLogo.png");
            companyLogo.Image = logo;

            //username and password credentials
            this.uName = "admin";
            this.password = "12345";
        }

        //Encapsulated username and password
        public string userID
        {
            get
            {
                return this.uName;
            }
        }

        public string userPass
        {
            get
            {
                return this.password;
            }
        }

        //if credentials are correct, proceed to main program. Else prompt user.
        private void signInButton_Click(object sender, EventArgs e)
        {
            formSignIn test = new formSignIn();
            if (uNameTextInp.Text.Equals(test.userID) && passTextInp.Text.Equals(test.userPass))
            {
                this.DialogResult = DialogResult.Yes;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Incorrect credentials, please try again");
            }
        }
    }
}
