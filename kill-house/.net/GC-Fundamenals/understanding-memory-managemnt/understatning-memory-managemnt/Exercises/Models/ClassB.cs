using System.Collections.Generic;

namespace understatning_memory_managemnt.Models
{
    public class ClassB
    {
        private List<ClassA> listOfAClasses = new List<ClassA>();
        public ClassB()
        {
            
        }

        public void HoldNextAClass(ClassA classA){
            this.listOfAClasses.Add(classA);
        }
    }
}