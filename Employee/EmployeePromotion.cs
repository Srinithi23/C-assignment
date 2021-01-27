using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class EmployeePromotion
    {

        static List<string> empList = new List<string>();

        //1. 1)To Create a C# console application,class with name “EmployeePromotion” that take employee names in the order and eligible for promotion. 
        public void AddEmployeePromotion()
        {
            bool e = true;
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
            while (e)
            {
                string name = Console.ReadLine();
                if (name == string.Empty)
                    e = false;
                else 
                {
                    empList.Add(name);
                }
            }

            //2.finding the position in the promotion list

            Console.WriteLine("Please enter the name of the employee to check promotion position\n");
            string nameemp = Console.ReadLine();
            int a = empList.IndexOf(nameemp);
            int b = a + 1;
            Console.WriteLine(nameemp + " is the position " + b + " for promotion");


            /*3.To remove extra space
             
            Console.WriteLine("The current size of the collection is {0}", empList.Capacity);
            empList.TrimExcess();
            Console.Write("The size after removing the extra space is {0}", empList.Capacity);
            */


            //sorting the list

            empList.Sort();
            System.Console.WriteLine("\n" + "Promoted employee list:" + "\n");

            foreach (var empsname in empList)
            { 
                Console.WriteLine(empsname);
            }

            Console.ReadLine();

        }
    }
}
