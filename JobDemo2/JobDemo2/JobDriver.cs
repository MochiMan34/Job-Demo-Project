using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JobDemo.Program;

namespace JobDemo2
{
    class RunProgram : JobDemo.Program.Job
    {
        public RunProgram(int jobNum, string name, string jobDescript, int estHours) : base(jobNum, name, jobDescript, estHours)
        {
        }

        static void Main(String[] args)
        {
            int s = 0; 
            Job [] j = new Job[5];
            int[] numbers = new int[j.Length];
            double total = 0;
            for(int i = 0; i < j.Length; i++)
            {
                int[] nums = new int[i]; 

                j[i] = new Job();
                Console.Write("Enter Job Number: ");
              

                j[i].JobNumber = Convert.ToInt32(Console.ReadLine());
                if (i > 0)
                {

                    while (j[i].Equals(j[i - 1]) || j[i].Equals(j[0]))
                    {

                        //Console.Write("Duplicate Job number. Enter a valid Job number: ");
                        j[i].JobNumber = Convert.ToInt32(Console.ReadLine());




                    }

                    if (i >= 2)
                    {

                        while (j[i].Equals(j[i - 2]) || j[i].Equals(j[i-1]))
                        {

                            j[i].JobNumber = Convert.ToInt32(Console.ReadLine());

                        }


                    }

                    if(i >= 3)
                    {
                        while(j[i].Equals(j[i-3]) || j[i].Equals(j[i-2]) ||  j[i].Equals(j[i-1]))
                        {
                            j[i].JobNumber = Convert.ToInt32(Console.ReadLine()); 
                        }

                    }

                    if(i >= 4)
                    {
                        while (j[i].Equals(j[i - 4]) || j[i].Equals(j[i - 3]) || j[i].Equals(j[i - 2]) || j[i].Equals(j[i - 1]))
                        {
                            j[i].JobNumber = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    if(i >= 5)
                    {

                        while (j[i].Equals(j[i - 5]) || j[i].Equals(j[i - 4]) || j[i].Equals(j[i - 3]) || j[i].Equals(j[i - 2]) || j[i].Equals(j[i - 1]))
                        {
                            j[i].JobNumber = Convert.ToInt32(Console.ReadLine());
                        }
                    }

               


                }





                Console.Write("Enter customer name: "); 
                j[i].CustomerName = Console.ReadLine();
                Console.Write("Enter estimated hours: "); 
                j[i].EstimatedHours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter job description: "); 
                j[i].JobDescription = Console.ReadLine();
                Console.Write("\n"); 
                j[i].PriceForJob = 45 * j[i].EstimatedHours;
               

                
                total += j[i].PriceForJob;

                

                
                
                
            }
            
            for(int c = 0; c < j.Length; c++)
            {
                Console.Write("\n" + j[c].ToString());
                Console.ReadLine(); 

            }

            Console.Write("\n Total price for all jobs: $" + total);
            Console.ReadLine(); 

            
            

            
        }

        

                





        }

      

      


        

     

        

    

       
    }



        

