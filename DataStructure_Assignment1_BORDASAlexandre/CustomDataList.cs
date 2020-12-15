using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_Assignment1_BORDASAlexandre
{
    class CustomDataList
    {
        List<Student> list = new List<Student>();

        public CustomDataList()
        {            
        }

        public List<Student> List
        {
            get { return list; }
        }

        public void Add(Student student)
        {
            this.list.Add(student);
            Console.WriteLine("Student successfully added !");
        }

        public void GetElement(int index)
        {
            if (this.list == null || this.list.Count == 0) Console.WriteLine("ERROR : there is no student in the list !");
            else
            {
                if (index >= this.list.Count)
                {
                    Console.WriteLine("ERROR : invalid index !");
                }
                else
                {
                    Console.WriteLine("Student at index " + index + " : " + this.list[index].FirstName + " " + this.list[index].LastName + " - " + this.list[index].StudentNumber + ", Average score of " + this.list[index].AverageScore);
                }
            }
        }

        public void RemoveByIndex(int index)
        {
            if (this.list == null || this.list.Count == 0) Console.WriteLine("ERROR : there is no student in the list !");
            else
            {
                if (index >= this.list.Count)
                {
                    Console.WriteLine("ERROR : invalid index !");
                }
                else
                {
                    this.list.RemoveAt(index);
                }
            }
        }

        public void RemoveFirst()
        {
            this.list.RemoveAt(0);
        }

        public void RemoveLast()
        {
            this.list.RemoveAt(this.list.Count - 1);
        }

        public void DisplayList()
        {
            int n = 1;
            foreach (Student s in this.list)
            {
                Console.WriteLine("Student #" + n + " : " + this.list[n - 1].FirstName + " " + this.list[n - 1].LastName + " - " + this.list[n - 1].StudentNumber + ", Average score of " + this.list[n - 1].AverageScore);
                n++;
            }
        }

        public void PopulateWithSampleData()
        {
            Student s1 = new Student("Alexandre", "Bordas", "1", 80);
            Student s2 = new Student("Alice", "Dubois", "2", 48);
            Student s3 = new Student("Quentin", "Muller", "3", 96);
            Student s4 = new Student("Aymeric", "Nativel", "4", 68);
            Student s5 = new Student("Nicolas", "Vanderstigel", "5", 74);
            Student s6 = new Student("Theo", "Cherrier", "6", 53);
            Student s7 = new Student("Max", "Doppers", "7", 39);

            this.list.Add(s1);
            this.list.Add(s2);
            this.list.Add(s3);
            this.list.Add(s4);
            this.list.Add(s5);
            this.list.Add(s6);
            this.list.Add(s7);
        }
        public int Count()
        {
            return this.list.Count;
        }
    }
}
