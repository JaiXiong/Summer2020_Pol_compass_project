using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace PoliticalCompass
{
    class QuestionBank
    {
        private const string Path = @"C:\Users\jai_1\source\repos\PoliticalCompass\PoliticalCompass\QuestionFile.txt";
        public static List<string> QuestionList;

        public QuestionBank()
        {
            //constructor
            QuestionList = null;
        }

        public static List<string> MakeQuestions(List<string> list)
        {
            //create Array of questions here
            StreamReader reader = File.OpenText(Path);
            string line;
            string[] tmp;
            string questionmaker = "";

            while ((line = reader.ReadLine()) != null)
            {
                tmp = line.Split('\t');
                //Console.WriteLine("The question read in is: " + line);

                foreach (string value in tmp)
                {
                    questionmaker += value;
                }
                //Console.WriteLine("Adding..." + questionmaker);
                list.Add(questionmaker);
                questionmaker = "";
            }
            return list;
        }

        public static List<string> RandomizeQuestions(List<string> list)
        {
            //implement randomization here
            return QuestionList;
        }


    }
}
