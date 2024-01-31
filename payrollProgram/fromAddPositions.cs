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
    public partial class fromAddPositions : Form
    {
        //Instantiated payrollProgram object named add
        payrollProgram add;

        //Polymorphed payrollProgram which adds position in employee form and position table
        public fromAddPositions(payrollProgram insert)
        {
            InitializeComponent();
            this.add = insert;
        }

        private void insertEmployeeBtn_Click(object sender, EventArgs e)
        {
            if(validation() == true)
            {
                MessageBox.Show("Data added successfully.");
                add.positionTable.Rows.Add(posIdInp.Text, posNameInp.Text, ratePHrInp.Text, hourPDayInp.Text, workingDaysInp.Text);

                posIdInp.Text = "";
                posNameInp.Text = "";
                ratePHrInp.Text = "";
                hourPDayInp.Text = "";
                workingDaysInp.Text = "";
            }
            else
            {
                //do nothing
            }
            
        }

        //Method validator
        public bool validation()
        {
            if(posIdInp.Text.Equals("") || posNameInp.Text.Equals("") || ratePHrInp.Text.Equals("") || hourPDayInp.Text.Equals("") || workingDaysInp.Text.Equals(""))
            {
                MessageBox.Show("Inputs cannot be blank. Please fill all the data accordingly.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
