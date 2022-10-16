using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
     
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            renovators = new List<Renovator>();
        }

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public int Count { get { return renovators.Count; } }

        public string AddRenovator(Renovator renovator)
        {
            if(renovator.Name == null || renovator.Name == "" || renovator.Type == null || renovator.Type == "")
            {
                return "Invalid renovator's information.";
            }

            if(Count >= NeededRenovators)
            {
                return "Renovators are no more needed.";
            }

            if(renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            foreach(var ren in renovators)
            {
                if(ren.Name == name)
                {
                    renovators.Remove(ren);
                    return true;
                }
            }

            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            if(renovators.Exists(e => e.Type == type))
            {
                int count = renovators.RemoveAll(e => e.Type == type);
                return count;
            }

            return 0;
        }

        public Renovator HireRenovator(string name)
        {
            foreach(var ren in renovators)
            {
                if(ren.Name == name)
                {
                    ren.Hired = true;
                    return ren;
                }
            }

            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> newRenovators = renovators.FindAll(r => r.Days >= days);
            return newRenovators;
        }

        public string Report()
        {
            List<Renovator> newRenovators = renovators.Where(r => r.Hired == false).ToList();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Renovators available for Project {Project}:");

            foreach(var ren in newRenovators)
            {
                sb.AppendLine(ren.ToString());
            }

            return sb.ToString();
        }
    }
}
