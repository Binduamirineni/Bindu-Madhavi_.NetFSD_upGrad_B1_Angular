using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1_MedicalTest
{
    internal class MedicalTest
    {
        public int TestId;
        public string TestName;
        public double TestCost;
        public MedicalTest(int id, string name, double cost)
        {
            TestId = id;
            TestName = name;
            TestCost = cost;
        }
    }
    class Program
    {
        static void Main()
        {
            MedicalTest mt1 = new MedicalTest(1, "Blood Test", 500);
            MedicalTest mt2 = new MedicalTest(2, "X-Ray", 1000);
            Console.WriteLine($"TestId: {mt1.TestId} \nTestName: {mt1.TestName} \nTestCost: {mt1.TestCost}\n");
            Console.WriteLine($"TestId: {mt2.TestId} \nTestName: {mt2.TestName} \nTestCost: {mt2.TestCost}\n");
        }
    }
}