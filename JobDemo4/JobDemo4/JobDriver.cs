
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDemo2
{
    class Program2
    {
        public static Job[] j = new Job[5];
        public static double total = 0;
        public static double price = 0.0;
        public static double prem = 0; 





        public class Job : IComparable
        {

            public Job() { }
            public int jobNumber;
            public string customerName;
            public string jobDescription;
            public int estimatedHours;
            public double priceForJob;
            public double premiumPrice; 

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

            public double PremiumPrice
            {

                get
                {
                    return premiumPrice; 
                }

                set
                {
                    premiumPrice = 150 + (45 * EstimatedHours); 
                    




                }

            }

            int IComparable.CompareTo(object obj)
            {
                int returnVal;

                RushJob temp = (RushJob)obj;
                if (this.JobNumber > temp.JobNumber)
                {
                    returnVal = 1;
                }
                else
                {
                    if (this.JobNumber < temp.JobNumber)
                    {
                        returnVal = -1;
                    }
                    else
                    {
                        returnVal = 0;
                    }
                }

                return returnVal;
            }

            public Job(int jobNum, String name, String jobDescript, int estHours)
            {
                JobNumber = jobNum;
                CustomerName = name;
                JobDescription = jobDescript;
                EstimatedHours = estHours;

                priceForJob = 45 * EstimatedHours;
            }

            public override bool Equals(Object o)
            {
                Boolean isEquals;

                Job temp = (Job)o;

                if (this.JobNumber == temp.JobNumber)
                {
                    isEquals = true;
                    Console.Write("Duplicate Job number. Please enter another job number: ");


                }
                else
                {
                    isEquals = false;
                    
                   
                }

                

                return isEquals; 




            }

            public  override int GetHashCode()
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

        public class RushJob : Job 
        {
            public RushJob() 
            {

            }

        

            public override string ToString()
            {
                String info = "";

                info = "Job Number: " + this.JobNumber + "\n Customer name: " + this.CustomerName + " \n Job Description: " + this.JobDescription + "\n Estimated Hours: " + this.EstimatedHours + "\n Price for Job: $" + this.PremiumPrice;

                return info;
            }

         
        }


        public static void Generate(Job [] arr)
        {
           
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = new Job();
                Console.Write("\n");

                Console.Write("Enter Job Number: ");


                arr[i].JobNumber = Convert.ToInt32(Console.ReadLine());


                if (i > 0)
                {

                    while (arr[i].Equals(arr[i - 1]) || arr[i].Equals(arr[0]))
                    {

                        //Console.Write("Duplicate Job number. Enter a valid Job number: ");
                        arr[i].JobNumber = Convert.ToInt32(Console.ReadLine());




                    }

                    if (i >= 2)
                    {

                        while (arr[i].Equals(arr[i - 2]) || arr[i].Equals(arr[i - 1]))
                        {

                            arr[i].JobNumber = Convert.ToInt32(Console.ReadLine());

                        }


                    }

                    if (i >= 3)
                    {
                        while (arr[i].Equals(arr[i - 3]) || arr[i].Equals(arr[i - 2]) || arr[i].Equals(arr[i - 1]))
                        {
                            arr[i].JobNumber = Convert.ToInt32(Console.ReadLine());
                        }

                    }

                    if (i >= 4)
                    {
                        while (arr[i].Equals(arr[i - 4]) || arr[i].Equals(arr[i - 3]) || arr[i].Equals(arr[i - 2]) || arr[i].Equals(arr[i - 1]))
                        {
                            arr[i].JobNumber = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    if (i >= 5)
                    {

                        while (arr[i].Equals(arr[i - 5]) || arr[i].Equals(arr[i - 4]) || arr[i].Equals(arr[i - 3]) || arr[i].Equals(arr[i - 2]) || arr[i].Equals(arr[i - 1]))
                        {
                            arr[i].JobNumber = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }

                Console.Write("Enter customer name: ");
                arr[i].CustomerName = Console.ReadLine();
                Console.Write("Enter estimated hours: ");
                arr[i].EstimatedHours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter job description: ");
                arr[i].JobDescription = Console.ReadLine();
                arr[i].PriceForJob = 45 * arr[i].EstimatedHours;



                total += arr[i].PriceForJob;






            }

            for (int c = 0; c < arr.Length; c++)
            {
                Console.Write("\n" + arr[c].ToString());
                Console.ReadLine();

            }

            Console.Write("\n Total price for all jobs: $" + total);
            Console.ReadLine();


        }

        public static void Generate(RushJob[] arr2)
        {

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = new RushJob();
                Console.Write("Enter Job Number: ");
                arr2[i].JobNumber = Convert.ToInt32(Console.ReadLine());


                if (i > 0)
                {

                    while (arr2[i].Equals(arr2[i - 1]) || arr2[i].Equals(arr2[0]))
                    {

                        //Console.Write("Duplicate Job number. Enter a valid Job number: ");
                        arr2[i].JobNumber = Convert.ToInt32(Console.ReadLine());




                    }

                    if (i >= 2)
                    {

                        while (arr2[i].Equals(arr2[i - 2]) || arr2[i].Equals(arr2[i - 1]))
                        {

                            arr2[i].JobNumber = Convert.ToInt32(Console.ReadLine());

                        }


                    }

                    if (i >= 3)
                    {
                        while (arr2[i].Equals(arr2[i - 3]) || arr2[i].Equals(arr2[i - 2]) || arr2[i].Equals(arr2[i - 1]))
                        {
                            arr2[i].JobNumber = Convert.ToInt32(Console.ReadLine());
                        }

                    }

                    if (i >= 4)
                    {
                        while (arr2[i].Equals(arr2[i - 4]) || arr2[i].Equals(arr2[i - 3]) || arr2[i].Equals(arr2[i - 2]) || arr2[i].Equals(arr2[i - 1]))
                        {
                            arr2[i].JobNumber = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    if (i >= 5)
                    {

                        while (arr2[i].Equals(arr2[i - 5]) || arr2[i].Equals(arr2[i - 4]) || arr2[i].Equals(arr2[i - 3]) || arr2[i].Equals(arr2[i - 2]) || arr2[i].Equals(arr2[i - 1]))
                        {
                            arr2[i].JobNumber = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }

                Console.Write("Enter customer name: ");
                arr2[i].CustomerName = Console.ReadLine();
                Console.Write("Enter estimated hours: ");
                arr2[i].EstimatedHours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter job description: ");
                arr2[i].JobDescription = Console.ReadLine();
                Console.Write("\n");

                arr2[i].PremiumPrice = 150 + (45 * arr2[i].EstimatedHours);
                prem = arr2[i].PremiumPrice;
                

                








                total += prem; 
               





            }
            Array.Sort(arr2); 
            for (int c = 0; c < arr2.Length; c++)
            {
                Console.Write("\n" + arr2[c].ToString());
                Console.ReadLine();

            }

            Console.Write("\n Total price for all jobs: $" + total);
            Console.ReadLine();


        }













    }



        
}
