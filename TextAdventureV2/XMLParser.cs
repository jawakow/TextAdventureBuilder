﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace TextAdventureV2
{
    class XMLParser
    {
        public Adventure ParseXml(string fileName)
        { 
            ////XmlSerializer serializer = new XmlSerializer(typeof(Adventure));
            Adventure adventure = new Adventure();
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(Path.Combine(Environment.CurrentDirectory, fileName)); // Specify your file name

            XmlNode myNodes = xmlDoc.SelectSingleNode("/adventure"); // You can specify from which node you want to start reading

            adventure.name = myNodes["name"].InnerText;
            adventure.description = myNodes["description"].InnerText;
            adventure.openDialog = myNodes["openingDialog"].InnerText;
            adventure.completionZoneId = int.Parse(myNodes["completionZoneId"].InnerText);
            adventure.completionMessage = myNodes["completionMessage"].InnerText;

            XmlNode playerNode = myNodes.SelectSingleNode("/adventure/player");
            Player player  = new Player
            {
                name = playerNode["name"].InnerText,
                description = playerNode["description"].InnerText,
                health = int.Parse(playerNode["health"].InnerText),
            };

            XmlNode roomNode = myNodes.SelectSingleNode("/adventure/rooms");
            List<Room> rooms = new List<Room>();

            foreach (XmlNode node in roomNode)
            {
                Room room = new Room
                {
                    name = node["name"].InnerText,
                    description = node["description"].InnerText,
                    Id = int.Parse(node["roomId"].InnerText),
                    northDoorRoomId = int.Parse(node["northDoorRoomId"].InnerText),
                    southDoorRoomId = int.Parse(node["southDoorRoomId"].InnerText),
                    eastDoorRoomId = int.Parse(node["eastDoorRoomId"].InnerText),
                    westDoorRoomId = int.Parse(node["westDoorRoomId"].InnerText),
                };

                XmlNode contentNode = roomNode.SelectSingleNode("/adventure/rooms/room/contents");
                List<Item> contents = new List<Item>();
                foreach (XmlNode cNode in contentNode)
                {
                    Item item = new Item
                    {
                        name = cNode["name"].InnerText,
                        description = cNode["description"].InnerText,
                    };
                    contents.Add(item);
                }

                if (node["isNorthAccessible"].InnerText.ToLower().Trim() == "true")
                {
                    room.isNorthAccessible = true;
                }

                if (node["isSouthAccessible"].InnerText.ToLower().Trim() == "true")
                {
                    room.isSouthAccessible = true;
                }

                if (node["isEastAcessible"].InnerText.ToLower().Trim() == "true")
                {
                    room.isWestAccessible = true;
                }

                if (node["isWestAccessible"].InnerText.ToLower().Trim() == "true")
                {
                    room.isEastAccessible = true;
                }

                rooms.Add(room);
            }

            adventure.rooms = rooms.ToArray();
            adventure.pc = player;

            return adventure;
        }
    }
}
