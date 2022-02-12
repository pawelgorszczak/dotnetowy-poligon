using System.Collections.Generic;
using understatning_memory_managemnt.Models;

namespace understatning_memory_managemnt
{
    public class Exercise4
    {
        public static ClassD globalClassD = new ClassD();

        /// Static class example with explicit reference
        public void Function1(){            
            var classC = new ClassC(globalClassD);
            var classC2 = new ClassC(new ClassD());
            var classC3 = new ClassC(new ClassD());

            //operation
            //operation

            Exercise4_Static_Class.ClassAStore.Add(classC2);

            Sample_Method();

            void Sample_Method(){
                var classC4 = new ClassC(globalClassD);
                Exercise4_Static_Class.ClassAStore.Add(classC4);
            }
        }
    }

    public static class Exercise4_Static_Class
    {
        public static List<ClassC> ClassAStore = new List<ClassC>();
    }
}