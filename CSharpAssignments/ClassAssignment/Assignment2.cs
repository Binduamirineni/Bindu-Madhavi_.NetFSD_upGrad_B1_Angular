using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1_Doctor
{
    internal class Doctor
    {
        public short DoctorId;
        public string DoctorName;
        public string Specialization;
        public double ConsultationFee;
    }
    class Program
    {
        static void Main(String[] args)
        {
            Doctor d1 = new Doctor();
            Doctor d2 = new Doctor();
            d1.DoctorId = 10;
            d1.DoctorName = "Dr.Kumar";
            d1.Specialization = "Cardiologist";
            d1.ConsultationFee = 500;
            d2.DoctorId = 11;
            d2.DoctorName = "Dr.Reddy";
            d2.Specialization = "Neurologist";
            d2.ConsultationFee = 600;
            Console.WriteLine($"DoctorId: {d1.DoctorId} \nDoctorName: {d1.DoctorName} \nSpecialization: {d1.Specialization} \nConsultationFee: {d1.ConsultationFee}");
            Console.WriteLine($"DoctorId: {d2.DoctorId} \nDoctorName: {d2.DoctorName} \nSpecialization: {d2.Specialization} \nConsultationFee: {d2.ConsultationFee}");
        }
    }
}
