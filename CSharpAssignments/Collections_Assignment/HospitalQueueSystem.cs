using System;
using System.Collections.Generic;

namespace HospitalQueueSystem
{
    // Patient Class
    public class Patient
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Disease { get; set; }

        // Constructor
        public Patient(int id, string name, string disease)
        {
            Id = id;
            Name = name;
            Disease = disease;
        }
    }

    class Program
    {
        static void Main()
        {
            // Normal Queue
            Queue<Patient> queue = new Queue<Patient>();

            // VIP Queue (Bonus)
            Queue<Patient> vipQueue = new Queue<Patient>();

            // Add 5 patients
            queue.Enqueue(new Patient(1, "Ravi", "Fever"));
            queue.Enqueue(new Patient(2, "Anita", "Cold"));
            queue.Enqueue(new Patient(3, "Kiran", "Headache"));
            queue.Enqueue(new Patient(4, "Sneha", "Cough"));
            queue.Enqueue(new Patient(5, "Arjun", "Infection"));

            // Add VIP patients
            vipQueue.Enqueue(new Patient(101, "VIP1", "Emergency"));
            vipQueue.Enqueue(new Patient(102, "VIP2", "Critical"));

            Console.WriteLine("---- Serving Patients ----");

            // Serve 2 patients (VIP first)
            for (int i = 0; i < 2; i++)
            {
                if (vipQueue.Count > 0)
                {
                    var p = vipQueue.Dequeue();
                    Console.WriteLine($"VIP Served: {p.Name}");
                }
                else if (queue.Count > 0)
                {
                    var p = queue.Dequeue();
                    Console.WriteLine($"Served: {p.Name}");
                }
            }

            // Display next patient
            Console.WriteLine("\n---- Next Patient ----");
            if (vipQueue.Count > 0)
                Console.WriteLine("Next (VIP): " + vipQueue.Peek().Name);
            else if (queue.Count > 0)
                Console.WriteLine("Next: " + queue.Peek().Name);

            // Show all remaining patients
            Console.WriteLine("\n---- Remaining Patients ----");

            Console.WriteLine("VIP Queue:");
            foreach (var p in vipQueue)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Disease}");
            }

            Console.WriteLine("\nNormal Queue:");
            foreach (var p in queue)
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Disease}");
            }
        }
    }
}