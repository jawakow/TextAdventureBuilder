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
            // run TUI first
            tui = new TUI();
            tui.Run();
            // Adventure adventure = new Adventure();
            // MainActivity mainActivity = new MainActivity(adventure);
            // mainActivity.CheckCompletion();

            // Console.WriteLine("Hello World!");
            //XmlTextReader textReader = new XmlTextReader("../../../../Docs/AdventureTestScript.xml");
            //textReader.Read();

            //while (textReader.Read())
            //{
            //    textReader.MoveToElement();
            //    Console.WriteLine(textReader.Name);

            //}

            // XmlDocument xDoc = new XmlDocument();
            // xDoc.Load("../../../../Docs/AdventureTestScript.xml");
            // XmlElement node = (XmlElement)xDoc.SelectSingleNode("/Adventure/Rooms/Room");

            // string neededText = node.InnerText;

            // Console.WriteLine(neededText);
            // Console.WriteLine(neededText.GetType());

            // string contents = File.ReadAllText(neededText);
            // XmlSerializer serializer = new XmlSerializer(typeof(Room));
            //StringReader rdr = new StringReader(contents);
            //User resultingMessage = (User)serializer.Deserialize(rdr);

        }
    }
}
