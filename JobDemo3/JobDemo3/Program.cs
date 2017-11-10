using System;
using JobDemo2;
using JobDemo3; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace JobDemo3
{
    class Program : JobDemo2.Program2
    {
        static void Main(String[] args)
        {
            RushJob[] rj = new RushJob[5];

            Generate(rj);
        }



    }


    
 
}
