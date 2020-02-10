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
            tui.play();
=======
            //tui = new TUI();
            //tui.Run();
>>>>>>> 27c44d1df9a77eaf6a4320bfb91433d31b193f94


            ////while (textReader.Read())
            ////{
            ////    textReader.MoveToElement();
            ////    Console.WriteLine(textReader.Value);
            ////    Console.WriteLine(textReader.Value.GetType());
            ////}

        }
    }
}
