using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySolution2.AdoClass
{
    [Serializable]
    public class Student
    {
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name { get; set; }
        public int age { get; set; }
    }
}