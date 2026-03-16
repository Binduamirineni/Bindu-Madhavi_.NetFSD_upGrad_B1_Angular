using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1_Patient
{
    internal class Patient
    {
        public long PatientId;
        public string PatientName;
        public byte Age;
        public string Disease;
    }
    public class Program
    {
        static void Main()
        {
            Patient p = new Patient();
            p.PatientId = 101;
            p.PatientName = "Ravi Kumar";
            p.Age = 45;
            p.Disease = "Diabetes";

            Console.WriteLine($"Patient Id: {p.PatientId} \nPatient Name: {p.PatientName} \nAge: {p.Age} \nDisease: {p.Disease}");
        }
    }
}