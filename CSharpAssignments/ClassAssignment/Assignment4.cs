using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1_Appointment
{
    internal class Appointment
    {
        public short AppointmentId;
        public string PatientName;
        public string DoctorName;
        public DateTime AppointmentDate;
        public Appointment()
        {
            DoctorName = "General Physician";
            AppointmentDate = DateTime.Today;
        }
    }
    class Program
    {
        static void Main()
        {
            Appointment a = new Appointment();
            a.AppointmentId = 11;
            a.PatientName = "Ravi";
            Console.WriteLine($"AppointmentId: {a.AppointmentId} \nPatientName: {a.PatientName} \nDoctorName: {a.DoctorName} \nAppointmentDate: {a.AppointmentDate.ToShortDateString()}");
        }
    }
}