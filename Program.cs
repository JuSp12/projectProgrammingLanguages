using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("languages.tsv")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();

            //All languages calling by Prettify method
            //foreach (Language language in languages)
            //{
            //    Console.WriteLine(language.Prettify());
            //}

            //Query
            //var eachLanguage = languages
            //    .Select(l => l.Prettify());

            //foreach(var l in eachLanguage)
            //{
            //    Console.WriteLine(l);
            //}

            //Language with C# name
            //var languageC = languages
            //    .Where(l => l.Name == "C#");


            //foreach (var l in languageC)
            //{
            //    Console.WriteLine(l.Prettify());
            //}

            //Microsoft in ChiefDeveloper 

            //var languageMicrosoft = languages
            //.Where(l => l.ChiefDeveloper.Contains("Microsoft"));


            //foreach (var l in languageMicrosoft)
            //{
            //    Console.WriteLine(l.Prettify());
            //}

            //Lisp
            //var languageLisp = languages
            //.Where(l => l.Predecessors.Contains("Lisp"));


            //foreach (var l in languageLisp)
            //{
            //    Console.WriteLine(l.Prettify());
            //}

            //Scripts 
            //var languageScripts = languages
            //.Where(l => l.Name.Contains("Script"));


            //foreach (var l in languageScripts)
            //{
            //    Console.WriteLine(l.Prettify());
            //}

            //How many languages are included in the languages list
            //var languageValue = languages
            //.Select(l => l.Name);


            //Console.WriteLine($"On the list is: {languageValue.Count()} languages");

            //How many languages were launched between 1995 and 2005
            //var languageLaunched1995_2005 = languages
            //.Where(l => l.Year >= 1995 && l.Year <= 2005);


            //Console.WriteLine(languageLaunched1995_2005.Count());




        }



    }
}
