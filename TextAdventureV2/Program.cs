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
            

            XMLParser xmlParser = new XMLParser();

            Adventure adventure = xmlParser.ParseXml("../../../../Docs/AdventureTestScript.xml");
            MainActivity mainActivity = new MainActivity(adventure);

            //mainActivity.CheckCompletion();

            //Console.WriteLine("Hello World!");
            //XmlTextReader textReader = new XmlTextReader("../../../../Docs/AdventureTestScript.xml");
            //textReader.Read();

<<<<<<< HEAD
            TUI tui = new TUI();
            tui.play(mainActivity);


=======




>>>>>>> 44638a94ec1a37da6feaa5aa4daae351f63a7a50



            ////while (textReader.Read())
            ////{
            ////    textReader.MoveToElement();
            ////    Console.WriteLine(textReader.Value);
            ////    Console.WriteLine(textReader.Value.GetType());
            ////}

        }
    }
}
