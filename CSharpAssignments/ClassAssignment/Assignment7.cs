using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1_Properties
{
    internal class Nurse
    {
        public int NurseId { get; set; }
        public string NurseName { get; set; }
        public string Department { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Nurse n = new Nurse
            {
                NurseId = 101,
                NurseName = "Lakshmi",
                Department = "Department"
            };
            Console.WriteLine($"Nurse Id: {n.NurseId} \nNurse Name: {n.NurseName} \nDepartment: {n.Department}");
        }
    }
}