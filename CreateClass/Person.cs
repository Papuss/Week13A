﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {

        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        private DateTime birthDate;

        public Person() { }

        public Person(string Name, DateTime birthDate)
        {
            this.name = Name;
            this.birthDate = BirthDate;

        }

        public enum Genders : int { Male, Female };
        public Genders gender;

        public override string ToString()
        {
            return (String.Format("name:{0}, birth date {1}", this.name, this.birthDate));
        }


    }
}
