using System;
using System.Collections.Generic;

namespace PoliticalCompass
{
    class Driver : QuestionBank
    {
        //READ ME
        //This console app is going to be my fun and more in depth spin on the political compass
        //The idea behind the application should be credited to and originally from https://www.politicalcompass.org/ 
        //Some of the questions will come from a bank they have but I will also ask other questions I deem interesting
        //The process will go through certain steps, gather basic user data, answering questions, and then results
        //DESIGN 
        // etc. TBD and written later 

        public static List<string> Questionset;

        public Driver() 
        {
            //constructor
            Questionset = null;
        }

        public static List<string> CreateQuestionBank(List<string> list)
        {
            //Implement creation of question bank
            Questionset = QuestionBank.MakeQuestions(list);
            return Questionset;
        }

        static void Main(string[] args)
        {
            //Test results
            Console.WriteLine("Hello World!");
            Console.WriteLine("Today is the day");
            Questionset = new List<string>();
            CreateQuestionBank(Questionset);
            //Questionset.ToArray();

            for(int i = 0; i < Questionset.Count; i++)
            {
                Console.WriteLine("i is: " + i);
                Console.WriteLine(Questionset[i]);
            }
        }
    }
}
