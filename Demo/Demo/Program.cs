using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EmpArrayList item1 = new EmpArrayList(1, "Zsolt", 24);
            EmpArrayList item2 = new EmpArrayList(2, "Bela", 23);
            EmpArrayList item3 = new EmpArrayList(3, "Niki", 21);
            EmpArrayList item4 = new EmpArrayList(4, "Vanda", 22);
            EmpArrayList item5 = new EmpArrayList(5, "Julcsi", 25);

            ArrayList items = new ArrayList();
            items.Add(item1);
            items.Add(item2);
            items.Add(item3);
            items.Add(item4);
            items.Add(item5);

            Console.WriteLine("Enter the ID you are looking for: ");
            int sId = Convert.ToInt32(Console.ReadLine());
            
            foreach(var item in items)
            {
                Console.WriteLine(item);
  
            }


            /*for(int i =0;i < items.Count; i++)
            {
                if (items.Contains(sId)){
                    Console.WriteLine("{0} ", items[i]);
                }
            }*/
            Console.ReadLine();
        }

        
    }
}
