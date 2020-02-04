using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TextAdventureV2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Adventure adventure = new Adventure();
            //MainActivity mainActivity = new MainActivity(adventure);
            //mainActivity.CheckCompletion();

            Console.WriteLine("Hello World!");
            XmlTextReader textReader = new XmlTextReader("../../../../Docs/AdventureTestScript.xml");
            textReader.Read();

            while (textReader.Read())
            {
                textReader.MoveToElement();
                Console.WriteLine(textReader.Value);
                Console.WriteLine(textReader.Value.GetType());
            }



        }
    }
}
