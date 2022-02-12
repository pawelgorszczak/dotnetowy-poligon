using System.Collections.Generic;
using System.Threading.Tasks;
using understatning_memory_managemnt.Models;

namespace understatning_memory_managemnt
{
    /// infinite loop
    public class Exercise3
    {        
        public async Task Function1() {
            var exercise3Store = new Exercise3Store();

            while (true)
            {
                Function2(exercise3Store);
                await Task.Delay(500);
            }
        }
        
        public void Function2(Exercise3Store exercise3Store){
            var classA = new ClassA();
            var classA2 = new ClassA();
            var classA3 = new ClassA();

            //operation
            //operation

            exercise3Store.ClassAStore.Add(classA2);

            SampleMethod();

            void SampleMethod(){
                var classA4 = new ClassA();
                exercise3Store.ClassAStore.Add(classA4);
            }
        }
    }


    public class Exercise3Store
    {
        public List<ClassA> ClassAStore = new List<ClassA>();
    }
}