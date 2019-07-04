using System;
using System.Collections.Generic;
using System.Text;
using Workers.Entities.Enums;
namespace Workers.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level;
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Add(contract);

        }

        public double Income( int month, int year)
        {
            double sum= BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (month == contract.Date.Month && year == contract.Date.Year )
                {
                    sum += contract.Total();
                }
            }
            return sum;
        }


    }
}
