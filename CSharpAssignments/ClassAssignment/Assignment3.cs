using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1_Hospital
{
    internal class Hospital
    {
        public static string HospitalName;
        public static string HospitalAddress;
        public string PatientName;
    }
    class Program
    {
        static void Main()
        {
            Hospital.HospitalName = "Apolo Hosptials";
            Hospital.HospitalAddress = "Hyderabad";
            Hospital h1 = new Hospital();
            h1.PatientName = "Ravi";
            Hospital h2 = new Hospital();
            h2.PatientName = "Kumar";
            Hospital h3 = new Hospital();
            h3.PatientName = "Charan";

            Console.WriteLine($"HospitalName: {Hospital.HospitalName} \nHospitalAddress: {Hospital.HospitalAddress} \nPatientNames: {h1.PatientName}, {h2.PatientName},{h3.PatientName}");
        }
    }
}