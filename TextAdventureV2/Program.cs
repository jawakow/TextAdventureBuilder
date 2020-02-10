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
            TUI tui = new TUI();
            tui.play();
            //mainActivity.CheckCompletion();

            //Console.WriteLine("Hello World!");
            //XmlTextReader textReader = new XmlTextReader("../../../../Docs/AdventureTestScript.xml");
            //textReader.Read();




            //tui = new TUI();
            //tui.Run();



            ////while (textReader.Read())
            ////{
            ////    textReader.MoveToElement();
            ////    Console.WriteLine(textReader.Value);
            ////    Console.WriteLine(textReader.Value.GetType());
            ////}

        }
    }
}
