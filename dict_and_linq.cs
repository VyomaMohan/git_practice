using LearncsClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Learncs2
{
    class Program
    {
        class color
        {
            public string ColorName
            { get; set; }
        }
        class cat
        {
            public string CatName { get; set; } 
        }

        static void Main(string[] args)
        {
            cat c1 = new cat();
            c1.CatName = "cocoa";
            cat c2 = new cat();
            c2.CatName = "meenu";


            ArrayList cats = new ArrayList();
            cats.Add(c1);
            cats.Add(c2);

            foreach(cat i in cats)
            {
                Console.WriteLine(i.CatName);
            }

            Dictionary<string, cat> myDictionary = new Dictionary<string, cat>();
            myDictionary.Add(c1.CatName, c1);
            myDictionary.Add(c2.CatName, c2);

            Console.WriteLine(myDictionary["cocoa"].CatName);

            List<cat> mycats = new List<cat>
            {
                new cat {CatName="Angela"},
                new cat {CatName="Orange"},
                new cat {CatName="Cocoa"},
                new cat {CatName="Meenu"},
            };

            foreach(cat j in mycats)
            {
                Console.WriteLine(j.CatName);
            }

            var ang = from cat in mycats
                      where cat.CatName == "Angela"
                      select cat;

            foreach(cat i in ang)
            {
                Console.WriteLine("Hi {0}",i.CatName);
            }

            var firstCat = mycats.OrderByDescending(p => p.CatName).First(p=>p.CatName=="Orange");
            Console.WriteLine(firstCat.CatName);
            /*foreach (cat i in firstCat)
            {
                Console.WriteLine(i.CatName);
            }*/
            Console.WriteLine("second cats");
            var secondCat = mycats.OrderByDescending(p => p.CatName);
            mycats.ForEach(p=>Console.WriteLine(p.CatName));
        }
    }
}
