using System.Threading.Tasks;
using understatning_memory_managemnt.Models;

namespace understatning_memory_managemnt
{
    public class Example
    {       
        /// 1. mark all ClassA instances
        /// 2. point all roots
        /// 3. Write how long will each instance be needed in application 
        /// note that when instancance of an object is not needed GC will collect it
        /// 4. retention path for each object instance
        public void Function1(){
            /* root 1*/ var classA  = new ClassA(); // ClassAInstance 
            /* root 2*/ var classA2 = new ClassA(); // ClassAInstance2
            /* root 3*/ var classA3 = new ClassA(); // ClassAInstance3
            /* root 4*/ var classA4 = new ClassA(); // ClassAInstance4

            //operation
            //operation
            Sample_Method1(classA2);
            Sample_Method2(classA4);

            void Sample_Method1(/* root 5*/ ClassA classA2){
                /* root 6*/ var classA = classA2; // ClassAInstance2
                /* root 7*/ var classA5 = new ClassA(); // ClassAInstance5

                //operation
                //operation
            }

            async void Sample_Method2(/* root 8*/ ClassA classA4){
                //operation which last 10 seconds
                await Task.Delay(10000);
                //continuation on different thread
            }
        }

        /// Answer 3.
        /// ClassAInstance - will be needed as long as Function1 is being executed
        /// ClassAInstance2 - will be needed as long as Function1 is being executed
        /// ClassAInstance3 - will be needed as long as Function1 is being executed
        /// ClassAInstance4  - will be needed as long as Function1 and Sample_Method2 is being executed. 
        /// !!!!! note that Function1 will finish execution faster than Sample_Method2
        /// ClassAInstance5  - will be needed as long as Sample_Method1 is being executed        

        /// Answer 4
        /// ClassAInstance:
        /// root 1 -> ClassAInstance
        /// ClassAInstance3
        /// root 3 -> ClassAInstance3
        /// ClassAInstance2
        /// root 2 -> ClassAInstance2, root 5 -> ClassAInstance2, root 6 -> ClassAInstance2


        public void Function2(){
            /* root 1*/ var classC = new ClassC(new ClassD() /*ClassDInstance referenced by private field of ClassCInstance*/); // ClassCInstance 
        }
        /// Answer 3
        /// ClassCInstance - will be needed as long as function2 is being executed
        /// ClassDInstance -- will be needed as long as ClassCInstance is needed

        /// Answer 4
        /// ClassCInstance
        /// root 1 -> ClassCInstance
        /// ClassDInstance
        /// root 1 -> ClassCInstance -> ClassDInstance
    }
}