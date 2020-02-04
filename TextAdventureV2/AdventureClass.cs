﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureBuilder
{
    public class AdventureClass
    {
        public string name;
        public string description;
        public string openDialog;
        public Room[] rooms;
        public Player pc;
        public int completionZoneId;
        public string completionMessage;
        public bool isCompleted = false;
    }
}
