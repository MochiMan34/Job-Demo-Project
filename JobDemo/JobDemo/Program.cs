using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Job j1 = new Job(10202, "George", "Toilet Repair", 2);
            Job j2 = new Job(10202, "Bob", "Electrical Repair", 5);

            Console.Write(j1.ToString());
            Console.ReadLine();
            Console.Write("\n" + j2.ToString());
            Console.ReadLine(); 
            Console.Write("\n");
            Console.Write("Job 1 Hashcode: " + j1.GetHashCode());
            Console.ReadLine(); 
            Console.Write("\n");
            Console.Write("Job 2 Hashcode: " + j2.GetHashCode());
            Console.ReadLine(); 
            Console.Write("\n");
            j1.Equals(j2);
            Console.ReadLine(); 


        }

        public class Job
        {

            public int jobNumber;
            public string customerName;
            public string jobDescription;
            public int estimatedHours;
            public double priceForJob;

            public int JobNumber { get; set; }


            public string CustomerName { get; set; }
            public string JobDescription { get; set; }



            public int EstimatedHours
            {
                get
                {
                    return estimatedHours;
                }
                set
                {
                    estimatedHours = value;
                }

            }
            public double PriceForJob
            {
                get
                {
                    return priceForJob;
                }
                set
                {
                    priceForJob = 45 * estimatedHours;
                }

            }

            public Job(int jobNum, String name, String jobDescript, int estHours)
            {
                JobNumber = jobNum;
                CustomerName = name;
                JobDescription = jobDescript;
                EstimatedHours = estHours;
                priceForJob = 45 * EstimatedHours;
            }

            public override Boolean Equals(object e)
            {
                Boolean equals;
                Job temp = (Job)e;

                if (this.jobNumber == temp.jobNumber)
                {
                    equals = true;
                    Console.Write("Job Numbers are the same.  "); 

                }
                else
                {
                    equals = false;
                }

              

                return equals;




            }

            public override int GetHashCode()
            {
                return this.JobNumber;
            }

            public override String ToString()
            {
                String info = "";

                info = "Job Number: " + this.JobNumber + "\n Customer name: " + this.CustomerName + " \n Job Description: " + this.JobDescription + "\n Estimated Hours: " + this.EstimatedHours + "\n Price for Job: $" + this.PriceForJob;

                return info;

            }

        }


    
}
}
