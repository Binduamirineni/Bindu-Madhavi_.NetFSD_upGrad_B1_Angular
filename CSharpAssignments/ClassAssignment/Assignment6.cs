using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1_Billing
{
    internal class Billing
    {
        public string PatientName;
        public double ConsultationFee;
        public double TestCharges;
        public void CalculateTotalBill()
        {
            double TotalBill = ConsultationFee + TestCharges;
            Console.WriteLine($"PatientName: {PatientName} \nTotal Bill: {TotalBill}");
        }
    }
    class Program
    {
        static void Main()
        {
            Billing b = new Billing();
            b.PatientName = "Ramesh";
            b.ConsultationFee = 500;
            b.TestCharges = 1000;
            b.CalculateTotalBill();
        }
    }
}