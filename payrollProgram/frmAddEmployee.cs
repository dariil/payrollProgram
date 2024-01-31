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
    public partial class frmAddEmployee : Form
    {
        //Instantiated object from payrollProgram named add.
        payrollProgram add;

        //Polymorphed payrollProgram which takes data to be added in combobox of add employee form and table
        public frmAddEmployee(payrollProgram insert)
        {
            InitializeComponent();
            this.add = insert;
        }
        private void insertEmployeeBtn_Click(object sender, EventArgs e)
        {

            if(validation() == true)
            {
                add.employeeTable.Rows.Add(empNoInp.Text, empFNameInp.Text, empMNameInp.Text, empLNameInp.Text, deptSelect.Text, posSelect.Text);
                add.nameSelect.Items.Add(empFNameInp.Text + " " + empMNameInp.Text + " " + empLNameInp.Text);
                MessageBox.Show("Data added successfully.");

                empNoInp.Text = "";
                empFNameInp.Text = "";
                empMNameInp.Text = "";
                empLNameInp.Text = "";
                deptSelect.SelectedIndex = 0;
                posSelect.SelectedIndex = 0;
            }
            else
            {
                empNoInp.Text = "";
                empFNameInp.Text = "";
                empMNameInp.Text = "";
                empLNameInp.Text = "";
                deptSelect.SelectedIndex = 0;
                posSelect.SelectedIndex = 0;
            }
        }

        //method validator
        public bool validation()
        {
            if(empNoInp.Text.Equals("") || empFNameInp.Text.Equals("") || empMNameInp.Text.Equals("") || empLNameInp.Text.Equals("") || deptSelect.SelectedIndex == 0 || posSelect.SelectedIndex == 0)
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