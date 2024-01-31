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
    public partial class frmAddDept : Form
    {
        //instantiate object add from payrollProgram.
        payrollProgram add;

        //Polymorphed payrollProgram which gets data for combobox in add employee form and department table
        public frmAddDept(payrollProgram insert)
        {
            InitializeComponent();
            this.add = insert;
        }

        private void insertDeptBtn_Click(object sender, EventArgs e)
        {
            if(validation() == true)
            {
                add.deptTable.Rows.Add(deptNameInp.Text, deptIdInp.Text);
                MessageBox.Show("Data added successfully.");
                deptNameInp.Text = ""; deptIdInp.Text = "";
            }
            else
            {
                //do nothing
            }
        }

        //Method validator
        public bool validation()
        {
            if (deptIdInp.Text.Equals("") || deptNameInp.Text.Equals(""))
            {
                MessageBox.Show("Inputs cannot be blank. Please fill all the data accordingly");
                return false;
            }
            else {
                return true;
            }
        }
    }
}
