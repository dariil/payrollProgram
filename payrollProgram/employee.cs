using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payrollProgram
{
    //Parent and base class of position class
    public class employee
    {
        private string wholeName;
        public employee(string name)
        {
            this.wholeName = name;
        }

        //Encapsulated name of employees
        public string getWholeName
        {
            get
            {
                return this.wholeName;
            }
        }
    }
}