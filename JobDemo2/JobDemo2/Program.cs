using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDemo
{
    class Program
    {
        private int jobNum;
        private string name;
        private string jobDescript;
        private int estHours;

        public Program(int jobNum, string name, string jobDescript, int estHours)
        {
            this.jobNum = jobNum;
            this.name = name;
            this.jobDescript = jobDescript;
            this.estHours = estHours;
        }

        public class Job
        {
            public  Job() {} 
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

            public override bool Equals(object e)
            {
                Boolean equals;
                Job temp = (Job)e;

                if (this.GetHashCode() == temp.GetHashCode())
                {
                    equals = true;
                    Console.Write("Duplicate Job number. Please enter another job number: "); 

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
