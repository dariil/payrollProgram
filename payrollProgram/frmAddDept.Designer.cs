
namespace payrollProgram
{
    partial class frmAddDept
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.deptNameInp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deptIdInp = new System.Windows.Forms.TextBox();
            this.insertDeptBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "ADD DEPARTMENT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 79);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(46, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "DEPARTMENT NAME";
            // 
            // deptNameInp
            // 
            this.deptNameInp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptNameInp.Location = new System.Drawing.Point(51, 157);
            this.deptNameInp.Name = "deptNameInp";
            this.deptNameInp.Size = new System.Drawing.Size(211, 29);
            this.deptNameInp.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(46, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "DEPARTMENT ID";
            // 
            // deptIdInp
            // 
            this.deptIdInp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptIdInp.Location = new System.Drawing.Point(51, 283);
            this.deptIdInp.Name = "deptIdInp";
            this.deptIdInp.Size = new System.Drawing.Size(179, 29);
            this.deptIdInp.TabIndex = 20;
            // 
            // insertDeptBtn
            // 
            this.insertDeptBtn.BackColor = System.Drawing.Color.Tomato;
            this.insertDeptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertDeptBtn.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertDeptBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insertDeptBtn.Location = new System.Drawing.Point(109, 366);
            this.insertDeptBtn.Name = "insertDeptBtn";
            this.insertDeptBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.insertDeptBtn.Size = new System.Drawing.Size(326, 52);
            this.insertDeptBtn.TabIndex = 21;
            this.insertDeptBtn.Text = "INSERT";
            this.insertDeptBtn.UseVisualStyleBackColor = false;
            this.insertDeptBtn.Click += new System.EventHandler(this.insertDeptBtn_Click);
            // 
            // frmAddDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.insertDeptBtn);
            this.Controls.Add(this.deptIdInp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deptNameInp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddDept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "23rdSC | Payroll System | Add Department";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox deptNameInp;
        public System.Windows.Forms.TextBox deptIdInp;
        public System.Windows.Forms.Button insertDeptBtn;
    }
}