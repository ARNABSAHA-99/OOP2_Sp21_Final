using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList list = new ArrayList();
            Course c1 =new Course();
            Course c2 =new Course();
            Course c3 =new Course();

            list.Add(c1); //add element in index (0) by default
            list.Add(c1); 
            list.Add(c1); 
            list.Add(c1); //after run the program this element will replace by c2
            list.Add(c1);
            list.Insert(4, c2); //add element specifically in index (4) and also replace with new element
            int i = list.IndexOf(c2); //to see the element index position
            bool rs = list.Contains(c2); //show us if this element is present or not||if present print True otherwise False
            bool rs1 = list.Contains(c3);
            Console.WriteLine("Index no is: "+i);
            Console.WriteLine("Element existence: "+rs); //return True 
            Console.WriteLine("Element existence: "+rs1); //return False because we are not add this element in list index*/

            Hashtable ages = new Hashtable();
            ages["arnab"] = 21;
            ages["anik"] = 22;
            ages["rahim"] = 23;

            foreach (DictionaryEntry age in ages)
            {
                string a = (string)age.Key;
                int b = (int)age.Value;
                Console.WriteLine("{0} ==> {1}",a,b);
                //Console.WriteLine("Ages: "+age.Value);
                //Console.WriteLine("Keys: "+age.Key);


            }
            Console.WriteLine("Age of Arnab: "+ages["arnab"]);

            SortedList sl = new SortedList();
            sl["en-us"] = "United States";
            sl["en-uk"] = "United Kingdom";
            sl["bn"] = "Bangla";
            sl["in"] = "India";
            sl["Ar"] = "Arabic";

            foreach (DictionaryEntry s in sl) 
            {
                string a = (string)s.Key;
                string b = (string)s.Value;
                Console.WriteLine("{0} ==> {1}", a, b);
                

            }




            /* //boxing, unboxing
             int k = 10;
             object box = k; //boxing
             Console.WriteLine(k.GetType()); //to know the datatype
             k = (int)box;//unboxing

             Course c5 = new Course();
             box = c5; //boxing
             Console.WriteLine(box.GetType()); //to know the datatype
             c5 = (Course)box; //unboxing*/


        }
    }
}
