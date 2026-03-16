using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1_PatientRecord
{
    internal class PatientRecord
    {
        public long PatientId;
        public string PatientName;
        public short Age;
        public string Disease;
        public static string HospitalName;
        public PatientRecord(long id, string name, short age, string disease)
        {
            PatientId = id;
            PatientName = name;
            Age = age;
            Disease = disease;
        }
        public void DisplayPatientRecord()
        {
            Console.WriteLine($"Hospital Name: {HospitalName} \nPatient Id: {PatientId} \nPatient Name: {PatientName} \nAge: {Age} \nDisease: {Disease} \n");
        }
    }
    class Program
    {
        static void Main()
        {
            PatientRecord.HospitalName = "Apolo Hospitals";
            PatientRecord p1 = new PatientRecord(101, "Ravi", 40, "Fever");
            PatientRecord p2 = new PatientRecord(102, "Ramesh", 35, "Diabetes");
            PatientRecord p3 = new PatientRecord(103, "Suresh", 30, "BP");
            p1.DisplayPatientRecord();
            p2.DisplayPatientRecord();
            p3.DisplayPatientRecord();
        }
    }
}