using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PoliticalCompass
{
    class Person
    {
        private string name;
        private string standing;
        public Person()
        {
            name = "";
            standing = "";
        }

        public Person(string n)
        {
            name = n;
        }
        
        public Person(string n, string s)
        {
            name = n;
            standing = s;
        }
    }
}
