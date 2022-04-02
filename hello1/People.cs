using System;

namespace hello1
{

    class People{


        int Age{set;get;}



        string Name{set;get;}



        public string hello(){
            return this.Name + this.Age;
        }



        public People(int Age,string Name){
            this.Age = Age;
            this.Name = Name;
        }

        public People(){}

    }



}
