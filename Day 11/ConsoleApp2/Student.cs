using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student
    {/*
        public string Name;
        public string RegisterNumber;
        public int StudentClass;
        public override string ToString()
        {
            return $"StudentNme: {Name},RegisterNumber: {RegisterNumber}, Class: {StudentClass}";
        }*/

        public string Name { get; set; }
        private int age;


        public int Age
            
        {
            get => age;

            set
            {
                if(value>0 || value < 50)
                {
                    age = value;
                }
            }
        }
       
    }
}
