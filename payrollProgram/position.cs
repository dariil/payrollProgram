using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payrollProgram
{
    //Inherits from parent class which is employee
    class position : employee
    {
        private string positionName;
        private int ratePerHour, hourPerDay, workDays;

        //Inherits from constructor of base class
        public position(string position, int ratePhr, int hourPday, int workingDys, string name) : base(name)
        {
            this.positionName = position;
            this.ratePerHour = ratePhr;
            this.hourPerDay = hourPday;
            this.workDays = workingDys;
        }

        //encapsulated position name getter
        public string getPosName
        {
            get
            {
                return this.positionName;
            }
        }

        //Encapsulated getter for rate per hour based on employee position
        public int getRateHr
        {
            get
            {
                return this.ratePerHour;
            }
        }

        //Encapsulated getter for hr per day work based on employee position
        public int getHrDay
        {
            get
            {
                return this.hourPerDay;
            }
        }

        //Encapsulated getter for total days worked by the employee
        public int getWorkDaysPMnth
        {
            get
            {
                return this.workDays;
            }
        }
    }
}