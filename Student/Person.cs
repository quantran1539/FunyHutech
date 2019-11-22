﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    abstract class Person
    {
        public string Faculty { get; set; }
        public string FullName { get; set; }
        public Person()
        {
        }
        public Person(string faculty, string fullName)
        {
            Faculty = faculty;

            FullName = fullName;
        }

        //ham Nhap Person
        public virtual void Input()
        {
            Console.WriteLine("Faculty :=");
            this.Faculty = Console.ReadLine();
            Console.WriteLine("FullName :=");
            this.FullName = Console.ReadLine();
        }
        
        
        /*ham Xuat Person
        public virtual void OutPut()
        {
            Console.WriteLine("ID := {0} \n FullName := {1}\n",
                this.Faculty, this.FullName);
        }
        */
    }
}