using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor { get; set; }

        public Computer(string model, int capacity)
        {
            this.Model = model;
            this.Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public int Count { get { return Multiprocessor.Count; } }

        public void Add(CPU cpu)
        {
            if(Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            if(Multiprocessor.Exists(c => c.Brand == brand))
            {
                for(int i = 0; i < Multiprocessor.Count; i++)
                {
                    if(Multiprocessor[i].Brand == brand)
                    {
                        Multiprocessor.Remove(Multiprocessor[i]);
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public CPU MostPowerful()
        {
            List<CPU> mostPowerful = Multiprocessor.OrderByDescending(x => x.Frequency).ToList();
            return mostPowerful[0];
        }

        public CPU GetCPU(string brand)
        {
            for (int i = 0; i < Multiprocessor.Count; i++)
            {
                if (Multiprocessor[i].Brand == brand)
                {
                    return Multiprocessor[i];
                }
            }

            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {this.Model}:");

            for(int i = 0; i < Multiprocessor.Count; i++)
            {
                sb.AppendLine(Multiprocessor[i].ToString());
            }

            return sb.ToString();
        }
    }
}
