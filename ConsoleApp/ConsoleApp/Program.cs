using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {


        static void Main(string[] args)
        {
            var result = GetValues(10);

            var structure = GetTest();

            var result = GetMaxValue(structure);

        }


        // 1. Write a function to create, initialize and return an array of ascending values. 
        // It gets a positive integer N and returns an array containing a sequence from 0 to N, inclusive.
        private static int[] GetValues(int length)
        {

            int[] result = new int[length + 1];
            for (int i = 0; i < length + 1; i++)
            {
                result[i] = i;
            }
            return result;
        }


        // 3. Using the class from previous task, create the following tree:
        private static Test GetTest()
        {
            Test test = new Test();
            test.Head = 1;
            test.Arm = new List<Test>();


            Test arm0 = new Test();
            arm0.Head = 2;
            test.Arm.Add(arm0);


            Test child3 = new Test();
            child3.Head = 20;

            Test child1 = new Test();
            child1.Head = 4;
            child1.Arm = new List<Test>();
            child1.Arm.Add(child3);

            Test child2 = new Test();
            child2.Head = 5;
            child2.Arm = new List<Test>();

            Test child78 = new Test();
            child78.Head = 78;
            child2.Arm.Add(child78); 

            Test arm1 = new Test();
            arm1.Head = 2;
            arm1.Arm = new List<Test>();
            arm1.Arm.Add(child1);
            arm1.Arm.Add(child2);
            test.Arm.Add(arm1);


            Test arm2 = new Test()
            {
                Head = 7
            };
            test.Arm.Add(arm2);


            return test;
        }


        // 4. Write a function to find a maximum value stored in a tree defined in the previous task.
        private static int GetMaxValue(Test test)
        {
            int result = test.Head;
            if (test.Arm != null)
            {
                foreach (var subItem in test.Arm)
                {
                    var value = GetMaxValue(subItem);
                    if (value > result)
                    {
                        result = value;
                    }
                }
            }
            return result;
        }
    }


    // 2. Define a class capable of implementing a simple tree structure, holding an integer value in each node.
    public class Test
    {
        public int Head { get; set; }

        public List<Test> Arm { get; set; }
    }
}
