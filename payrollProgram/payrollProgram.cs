using System;
using System.Data;
using System.Windows.Forms;

namespace payrollProgram
{
    public partial class payrollProgram : Form
    {
        //Creating DataTable objects that would collect data for dataGridView tables
        public DataTable employeeTable = new DataTable("Employees");
        public DataTable deptTable = new DataTable("Departments");
        public DataTable positionTable = new DataTable("Positions");
        public DataTable payPorcessing = new DataTable("Payroll Process");
        public int countHold;
        public payrollProgram()
        {
            InitializeComponent();
        }
        public void payrollProgram_Load(object sender, EventArgs e)
        {
            //Setting tab/panel visibility. Employee panel should be the only visible when program starts.
            deptPnl.Visible = false;
            positionPnl.Visible = false;
            processingPnl.Visible = false;
            processPayPnl.Visible = false;

            //Add columns for employee table
            employeeTable.Columns.Add("Employee No.", Type.GetType("System.Int32"));
            employeeTable.Columns.Add("First Name", Type.GetType("System.String"));
            employeeTable.Columns.Add("Middle Name", Type.GetType("System.String"));
            employeeTable.Columns.Add("Last Name", Type.GetType("System.String"));
            employeeTable.Columns.Add("Department", Type.GetType("System.String"));
            employeeTable.Columns.Add("Position", Type.GetType("System.String"));
            employeeDataGrid.DataSource = employeeTable;

            //Add columns for dept. table
            deptTable.Columns.Add("Department Name", Type.GetType("System.String"));
            deptTable.Columns.Add("Department ID", Type.GetType("System.Int32"));
            deptDataGrid.DataSource = deptTable;

            //Add columns for position table
            positionTable.Columns.Add("Position ID", Type.GetType("System.Int32"));
            positionTable.Columns.Add("Position Name", Type.GetType("System.String"));
            positionTable.Columns.Add("Rate/hour", Type.GetType("System.Int32"));
            positionTable.Columns.Add("Hour/Day", Type.GetType("System.Int32"));
            positionTable.Columns.Add("Working Days/Month", Type.GetType("System.Int32"));
            positionDataGrid.DataSource = positionTable;

            //Add columns for pay process table
            payPorcessing.Columns.Add("Employee Name", Type.GetType("System.String"));
            payPorcessing.Columns.Add("Gross Pay", Type.GetType("System.String"));
            payPorcessing.Columns.Add("Deduction", Type.GetType("System.String"));
            payPorcessing.Columns.Add("Net Pay", Type.GetType("System.String"));
            payPorcessing.Columns.Add("Status", Type.GetType("System.String"));
            payrollListsDataGrid.DataSource = payPorcessing;

            nameSelect.Items.Add("---SELECT EMPLOYEE---");
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            //Instance object from frmAddEmployee named addEmployee which adds selection for combobox (department and position).
            frmAddEmployee addEmployee = new frmAddEmployee(this);
            addEmployee.Show();

            addEmployee.deptSelect.Items.Add("---SELECT DEPARTMENT---");
            addEmployee.deptSelect.SelectedIndex = 0;
            for (int i = 0; i < this.deptDataGrid.Rows.Count - 1; i++)
            {
                addEmployee.deptSelect.Items.Add(this.deptDataGrid.Rows[i].Cells[0].Value);
            }

            addEmployee.posSelect.Items.Add("---SELECT POSITION----");
            addEmployee.posSelect.SelectedIndex = 0;
            for (int i = 0; i < this.positionDataGrid.Rows.Count - 1; i++)
            {
                addEmployee.posSelect.Items.Add(this.positionDataGrid.Rows[i].Cells[1].Value);
            }
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            //Sets visibility of tabs in button click
            employeePnl.Visible = true;
            deptPnl.Visible = false;
            positionPnl.Visible = false;
            processingPnl.Visible = false;
            processPayPnl.Visible = false;
        }

        private void deptBtn_Click(object sender, EventArgs e)
        {
            //Sets visibility of tabs in button click
            deptPnl.Visible = true;
            positionPnl.Visible = false;
        }

        private void postnsBtn_Click(object sender, EventArgs e)
        {
            //Sets visibility of tabs in button click
            positionPnl.Visible = true;
            deptPnl.Visible = false;
            employeePnl.Visible = false;
        }

        private void addDeptBtn_Click(object sender, EventArgs e)
        {
            //Instance object of fromAddDept then make form visible
            frmAddDept addDepartment = new frmAddDept(this);
            addDepartment.Show();
        }

        private void addPositionBtn_Click(object sender, EventArgs e)
        {
            //Instance object of formAddPositions then make form visible
            fromAddPositions addPosition = new fromAddPositions(this);
            addPosition.Show();
        }

        private void prcssPayrollBtn_Click(object sender, EventArgs e)
        {
            //Sets visibility of tabs in button click
            processingPnl.Visible = true;
        }

        private void nameSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Iterate through the employee table in employee tab
            for (int i = 0; i < employeeDataGrid.Rows.Count - 1; i++)
            {
                //If selected name in process payroll combobox equal to name in employee...
                if (nameSelect.GetItemText(nameSelect.SelectedItem) == (employeeDataGrid.Rows[i].Cells[1].Value + " " + employeeDataGrid.Rows[i].Cells[2].Value + " " + employeeDataGrid.Rows[i].Cells[3].Value))
                {
                    //... then iterate again in employee table, and if...
                    for (int j = 0; j < employeeDataGrid.Rows.Count - 1; j++)
                    {
                        //... selected employee's position is equal to one of position form position table, then...
                        if (Convert.ToString(employeeDataGrid.Rows[i].Cells[5].Value) == Convert.ToString(positionDataGrid.Rows[j].Cells[1].Value))
                        {
                            //... set rateInp textbox and hrPDayInp textbox to their corresponding values.
                            rateInp.Text = Convert.ToString(positionDataGrid.Rows[j].Cells[2].Value);
                            hrPDayInp.Text = Convert.ToString(positionDataGrid.Rows[j].Cells[3].Value);
                        }
                    }
                }
            }
        }
        private void computeSalary_Click(object sender, EventArgs e)
        {
            if(computationValidation() == true)
            {
                //Iterate through employee table
                MessageBox.Show("Data computed and ready to be processed");
                for (int i = 0; i < employeeDataGrid.Rows.Count - 1; i++)
                {
                    //If selected name in process payroll combobox equal to name in employee...
                    if (nameSelect.GetItemText(nameSelect.SelectedItem) == (employeeDataGrid.Rows[i].Cells[1].Value + " " + employeeDataGrid.Rows[i].Cells[2].Value + " " + employeeDataGrid.Rows[i].Cells[3].Value))
                    {
                        //then set countHold to i
                        this.countHold = i;
                        //Instance object of computeSalary named comute. Set parameters to combobox and text values
                        computeSalary compute = new computeSalary(Convert.ToString(employeeDataGrid.Rows[this.countHold].Cells[5].Value), Convert.ToInt32(rateInp.Text), Convert.ToInt32(hrPDayInp.Text), Convert.ToInt32(daysWorkedInp.Text), nameSelect.GetItemText(nameSelect.SelectedItem));
                        //Compute based of parameters passed then set textbox values to computed values from computeSalary class' methods
                        taxTxtBox.Text = Convert.ToString(compute.getTaxDeduct * compute.grossPay);
                        phealthTxtBox.Text = Convert.ToString(compute.getPhilHealthDeduct * compute.grossPay);
                        sssTxtBox.Text = Convert.ToString(compute.getSSSDeduct * compute.grossPay);
                        grossTxtBox.Text = Convert.ToString(compute.grossPay);
                        deductTxtBox.Text = Convert.ToString(compute.TotalDeduction);
                        netPayTxtBox.Text = Convert.ToString(compute.netPay);
                    }
                }
            }
            else
            {
                //do nothing.
            }
            
        }

        //Method validator for computing and processing payroll
        public bool computationValidation()
        {
            if(rateInp.Text.Equals("") || hrPDayInp.Text.Equals("") || nameSelect.SelectedIndex == 0 || daysWorkedInp.Text.Equals(""))
            {
                MessageBox.Show("Please fill all credentials.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void processPayBtn_Click(object sender, EventArgs e)
        {
            if(computationValidation() == true)
            {
                //Instance object of computeSalary named comute. Set parameters to combobox and text values
                computeSalary compute = new computeSalary(Convert.ToString(employeeDataGrid.Rows[this.countHold].Cells[5].Value), Convert.ToInt32(rateInp.Text), Convert.ToInt32(hrPDayInp.Text), Convert.ToInt32(daysWorkedInp.Text), nameSelect.GetItemText(nameSelect.SelectedItem));
                //Add table values to payProcessing table based on values from methods of computeSalary class.
                payPorcessing.Rows.Add(compute.getWholeName, compute.grossPay, compute.TotalDeduction, compute.netPay, "Processed");
                rateInp.Text = "";
                hrPDayInp.Text = "";
                daysWorkedInp.Text = "";
                nameSelect.SelectedIndex = 0;
                taxTxtBox.Text = "";
                phealthTxtBox.Text = "";
                sssTxtBox.Text = "";
                grossTxtBox.Text = "";
                deductTxtBox.Text = "";
                netPayTxtBox.Text = "";
                MessageBox.Show("Payroll has been processed.");
            }
            else
            {
                //do nothing;
            }
        }
        private void payrListBtn_Click(object sender, EventArgs e)
        {
            //Sets visibility of tabs in button click
            processPayPnl.Visible = true;
            positionPnl.Visible = false;
            deptPnl.Visible = false;
            employeePnl.Visible = false;
        }
    }
}