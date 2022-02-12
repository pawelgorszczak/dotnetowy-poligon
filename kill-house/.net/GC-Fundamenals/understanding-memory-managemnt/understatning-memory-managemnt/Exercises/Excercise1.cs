using understatning_memory_managemnt.Models;

namespace understatning_memory_managemnt
{
    public class Exercise1
    {
        /// Single Instance
        public void Function1(){
            var classA = new ClassA();

            //operation
            //operation
        }

        // Multiple Instances
        public void Function2(){
            var classA = new ClassA();
            var classA2 = new ClassA();
            var classA3 = new ClassA();

            //operation
            //operation
        }

        /// Multiple variables single instance multiple variables single instance
        public void Function3(){
            var classA = new ClassA();
            var classA2 = classA;
            var classA3 = classA; 

            //operation
            //operation
        }

        /// Multiple variables single instance mix
        public void Function4(){
            var classA = new ClassA();
            var classA2 = classA;
            var classA3 = classA2; 

            //operation
            //operation
        }

        /// Method Argument
        public void Function5(ClassA classA){
            //operation
            //operation
        }

        /// Single instance passing to another function
        public void Function6(){
            var classA = new ClassA();
            Sample_Method(classA);

            void Sample_Method(ClassA classA){
                //operation
                //operation
            }           
        }

        /// Single orphant instance passing to another function
        public void Function7(){
            Sample_Method(new ClassA());
            //operation
            //operation

            void Sample_Method(ClassA classA){
                //operation
                //operation
            }
        }

        /// Single instance passing to another function with another instance
        public void Function8(){
            var classA = new ClassA();
            Sample_Method(classA);

            void Sample_Method(ClassA classA){
                //operation
                //operation
                var classA2 = new ClassA();
            }
        }

        /// Single instance passing to another function with another instance
        public void Function9(){
            var classA = new ClassA();
            Sample_Method(classA);

            void Sample_Method(ClassA classA){
                //operation
                //operation
                var classA2 = new ClassA();

                Sample_Method2(classA);
            }

            void Sample_Method2(ClassA classA){
                //operation
                //operation
            }
        }
    }
}