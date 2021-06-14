using System;
using System.Collections;
using System.Collections.Generic;

namespace TrainingApp
{
    class Program
    {
        

        static void Main(string[] args)
        {

            // Array Example - Number of Values Fixed with Strongly Typed
            Console.WriteLine("");
            Console.WriteLine("Array Example");
            int[] intArray = { 1, 2, 3 };

            foreach(int item in intArray)
            {
                Console.WriteLine("  " + item);
            }


            // ArrayList Example -- Number of Values Not Fixed with Loosely Typed Leads to Boxing and Unboxing
            Console.WriteLine("");
            Console.WriteLine("ArrayList Example");
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(true);

            foreach(object item in arrayList)
            {
                Console.WriteLine("  " + item);
            }
            foreach (var item in arrayList)
            {
                Console.WriteLine("  " + item);
            }

            //Find which Datatype 
            Console.WriteLine("");
            Console.WriteLine("Datatype Example");
            Type tp = arrayList[1].GetType();
            Console.WriteLine("  Data Type of the value is"+ tp);


            if (tp.Equals(typeof(string)))
                Console.WriteLine("  {0} is an String data type.", tp);



            // List - Combination of Array & ArrayList
            Student obj1 = new Student()
            {
                StudentId = 1,
                Name = "Barani",
                std = 3,
                fathername = "Raja",
                fees = 40000.00

            };

            Student obj2 = new Student()
            {
                StudentId = 1,
                Name = "Santhosh",
                std = 3,
                fathername = "Bala",
                fees = 40000.00

            };


            List<Student> students = new List<Student>();
            students.Add(obj1);
            students.Add(obj2);
            Console.WriteLine("");
            Console.WriteLine("List Example");
            foreach (Student item in students)
            {
                Console.WriteLine("  "+item.Name+ " is studying class " +item.std);
            }


            // Dictionary - Key Value Pair with Strongly Typed without Sorting
            Console.WriteLine("");
            Console.WriteLine("Dictionary Example");

            Dictionary<int, string> DicKeyValue = new Dictionary<int, string>();

            DicKeyValue.Add(1,"Sunday");
            DicKeyValue.Add(2, "Monday");
            DicKeyValue.Add(4, "Wednesday");
            DicKeyValue.Add(3, "Tuesday");
            DicKeyValue.Add(5, "Thursday");
            DicKeyValue.Add(6, "Friday");
            DicKeyValue.Add(7, "Saturday");

            foreach(var item in DicKeyValue)
            {
                Console.WriteLine("  "+item.Key+" Contains "+item.Value);
            }

            // SortedList - Key Value Pair with Strongly Typed & Sorting
            Console.WriteLine("");
            Console.WriteLine("SortedList Example");

            SortedList<int, string> sortlist = new SortedList<int, string>();

            sortlist.Add(1, "Sunday");
            sortlist.Add(2, "Monday");
            sortlist.Add(4, "Wednesday");
            sortlist.Add(3, "Tuesday");
            sortlist.Add(5, "Thursday");
            sortlist.Add(6, "Friday");
            sortlist.Add(7, "Saturday");
            foreach (var item in sortlist)
            {
                Console.WriteLine("  " + item.Key + " Contains " + item.Value);
            }

            // Hashtable - Key Value Pair with Loosely typed
            Console.WriteLine("");
            Console.WriteLine("HashTable Example");

            Hashtable hashlist = new Hashtable();

            hashlist.Add(1,"test");
            hashlist.Add("test", "Sunday");
            hashlist.Add("ett", "testing");

            foreach(DictionaryEntry item in hashlist)
            {
                Console.WriteLine("  " + item.Key + " Contains " + item.Value);
            }

        }
    }
}
