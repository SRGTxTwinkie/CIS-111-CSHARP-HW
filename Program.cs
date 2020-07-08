using System;

namespace schedulue_maker
{
    class Program
    {
        static void Main(string[] args)
        {
            string name_first;
            string name_last;
            string class_name;
            
            int to_leave = 0;

            Schedule tempSchedule = new Schedule();

            Schedule[] schedules = new Schedule[0];

            Console.Write("Name, First: ");
            name_last = Console.ReadLine();

            Console.Write("Name, Last: ");
            name_first = Console.ReadLine();


            Console.WriteLine("Enter -1 and press enter to stop schedule creation.");
            Console.WriteLine("Enter the name of the class you are taking. I.E. \" English 305 \"  \n \n");

            tempSchedule.name_first = name_first;
            tempSchedule.name_last = name_last;


            while (to_leave != -1)
            {
                Console.Write("Class Name: ");
                class_name = Console.ReadLine();
                if(int.TryParse(class_name, out to_leave) == true)
                {
                    if(to_leave == -1)
                    {
                        break;
                    }
                }

               tempSchedule.classes = arrAdder(class_name, tempSchedule.classes);

            }

            Console.WriteLine("First Name: {0} \nLast Name: {1} \n",tempSchedule.name_first,tempSchedule.name_last);

            for(int i = 0; i < tempSchedule.classes.Length; i++)
            {
                Console.WriteLine("Class {0} : {1}", i + 1, tempSchedule.classes[i]);
            }

        }

        static string[] arrAdder(string var, string[] add_array)
        {
            string[] new_arr = new string[add_array.Length + 1];

            for(int i = 0; i < add_array.Length; i++)
            {
                new_arr[i] = add_array[i];
            }

            new_arr[new_arr.Length - 1] = var;

            return new_arr;
        }
        static Schedule[] arrAdder(Schedule var, Schedule[] add_array)
        {
            Schedule[] new_arr = new Schedule[add_array.Length + 1];

            for (int i = 0; i < add_array.Length; i++)
            {
                new_arr[i] = add_array[i];
            }

            new_arr[new_arr.Length - 1] = var;

            return new_arr;
        }
    }

    class Schedule
    {
        public string name_first
        {
            get;
            set; 
        }
        public string name_last
        { 
            get;
            set;
        }

        public string[] classes = new string[0];
    }
}
