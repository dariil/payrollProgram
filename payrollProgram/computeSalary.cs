namespace payrollProgram
{
    class computeSalary : position
    {
        private double deductSSS, deductPhilHealth, deductTax;

        //Inherits and uses the parameters of the base constructor
        public computeSalary(string position, int ratePhr, int hourPday, int workingDys, string name) : base(position, ratePhr, hourPday, workingDys, name)
        {
            this.deductSSS = 0.02;
            this.deductPhilHealth = 0.05;
            this.deductTax = 0.15;
        }

        //Encapsulated gross pay computation
        public double grossPay
        {
            get
            {
                return getRateHr * getHrDay * getWorkDaysPMnth;
            }
        }

        //Encapsulated SSS deduction computation
        public double getSSSDeduct
        {
            get
            {
                return this.deductSSS;
            }
        }

        //Encapsulated PhilHealth deduction computation
        public double getPhilHealthDeduct
        {
            get
            {
                return this.deductPhilHealth;
            }
        }

        //Encapsulated tax deduction computation
        public double getTaxDeduct
        {
            get
            {
                return this.deductTax;
            }
        }

        //Encapsulated total deduction computation
        public double TotalDeduction
        {
            get
            {
                return grossPay * (getSSSDeduct + getPhilHealthDeduct + getTaxDeduct);
            }
        }

        //Encapsulated total net pay computation
        public double netPay
        {
            get
            {
                return grossPay - TotalDeduction;
            }
        }
    }
}