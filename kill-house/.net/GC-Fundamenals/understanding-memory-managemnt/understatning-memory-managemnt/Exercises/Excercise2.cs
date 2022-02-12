using System.Collections.Generic;
using understatning_memory_managemnt.Models;

namespace understatning_memory_managemnt
{
    public class Exercise2
    {
        /// Static class example with explicit reference
        public void Function1(){
            var classA = new ClassA();
            var classA2 = new ClassA();
            var classA3 = new ClassA();

            //operation
            //operation

            Exercise2_Static_Class.ClassAStore.Add(classA2);

            Sample_Method();

            void Sample_Method(){
                var classA4 = new ClassA();
                Exercise2_Static_Class.ClassAStore.Add(classA4);
            }
        }
    }

    public static class Exercise2_Static_Class
    {
        public static List<ClassA> ClassAStore = new List<ClassA>();
    }
}