using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareSystem
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public Staff(int id, string name, double salary)
        {
            StaffId = id;
            Name = name;
            BaseSalary = salary;
        }

        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }
    }

    public class Doctor : Staff
    {
        public double ConsultationFee { get; set; }

        public Doctor(int id, string name, double salary, double fee)
            : base(id, name, salary)
        {
            ConsultationFee = fee;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + ConsultationFee;
        }
    }

    public class Nurse : Staff
    {
        public double NightShiftAllowance { get; set; }

        public Nurse(int id, string name, double salary, double allowance)
            : base(id, name, salary)
        {
            NightShiftAllowance = allowance;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + NightShiftAllowance;
        }
    }

    public class LabTechnician : Staff
    {
        public double EquipmentAllowance { get; set; }

        public LabTechnician(int id, string name, double salary, double allowance)
            : base(id, name, salary)
        {
            EquipmentAllowance = allowance;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + EquipmentAllowance;
        }
    }

    class Program
    {
        static void Main()
        {
            Staff s1 = new Doctor(1, "Ravi", 50000, 20000);
            Staff s2 = new Nurse(2, "Anita", 30000, 5000);
            Staff s3 = new LabTechnician(3, "Rahul", 25000, 4000);

            Console.WriteLine("Doctor Salary: " + s1.CalculateSalary());
            Console.WriteLine("Nurse Salary: " + s2.CalculateSalary());
            Console.WriteLine("Lab Technician Salary: " + s3.CalculateSalary());
        }
    }
}