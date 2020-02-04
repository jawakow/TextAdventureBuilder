using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureBuilder;

namespace TextAdventureBuilderGui
{
    public class Handler
    {
        GameWindow gameWindow;

        public Handler(GameWindow gameWindow)
        {
            this.gameWindow = gameWindow;
        }

        public void SearchRoom()
        {
            List<string> itemList;
            foreach (string item in itemList)
            {
                gameWindow.OutputWindow.Text += item;
            }
        
        }
    }
}
