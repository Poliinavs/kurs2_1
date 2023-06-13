using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace lb13
{
    class Class1
    {
        static void Main(string[] args)
        {
            Game saper = new Game("Applied", "Pacman", "1999");
            Game game1 = new Game("Applied", "Kosnka", "2002");
            Game game2 = new Game("Soft", "Saper", "2003");
            Game game3 = new Game("Progarm", "Snake", "2005");
            Game[] games = new[] { game1, game2, game3, saper };

            BinaryFormatter BForm = new();
            Console.WriteLine("---------------- BINARY ------------------");
            using (FileStream fs = new("game.dat", FileMode.OpenOrCreate))
            {
                BForm.Serialize(fs, saper);
                Console.WriteLine("Объект сериализован");
            }

            using (FileStream fs = new("game.dat", FileMode.OpenOrCreate))
            {
                Game gn = (Game)BForm.Deserialize(fs);

                Console.WriteLine("Объект десериализован:");
                Console.WriteLine(gn.ToString());
            }
            Console.WriteLine("----------------- SOAP -------------------");

            SoapFormatter formatter = new();

            using (FileStream fs = new("game.soap", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, games);

                Console.WriteLine("Объект сериализован");
            }

            using (FileStream fs = new("game.soap", FileMode.OpenOrCreate))
            {
                Game[] gn2 = (Game[])formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован:");

                foreach (Game p in gn2)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            Console.WriteLine("\n----------------- XML --------------------");

            XmlSerializer xmlSerializer = new(typeof(Game));

            using (FileStream fs = new("game.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, game2);

                Console.WriteLine("Объект сериализован!");
            }

            using (FileStream fs = new("game.xml", FileMode.OpenOrCreate))
            {
                Game? newGame = xmlSerializer.Deserialize(fs) as Game;
                Console.WriteLine("Объект десериализован:");
                Console.WriteLine(newGame.ToString());
            }

            Console.WriteLine("\n----------------- JSON -------------------");
            var textJson = JsonSerializer.Serialize(saper);

            using (StreamWriter sr = new($"game.json"))
            {
                sr.Write(textJson);
            }

            using (StreamReader sr = new($"game.json"))
            {
                var obj = JsonSerializer.Deserialize<Game>(sr.ReadToEnd());
                Console.WriteLine(obj.ToString());
            }

            /////////3
            Console.WriteLine("-----------------------------------------------");

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("game.xml");
            XmlElement? xRoot = xDoc.DocumentElement;

            Console.WriteLine("Выбор всех дочерних узлов Soft");
            XmlNodeList? nodes = xRoot?.SelectNodes("*");
            if (nodes is not null)
            {
                foreach (XmlNode node in nodes)
                    Console.WriteLine(node.OuterXml);
            }
            Console.WriteLine("\n--- 2 ---");

            XmlDocument xDoc2 = new();
            xDoc.Load("game.xml");
            XmlElement? xRoot2 = xDoc.DocumentElement;

            XmlNodeList? companyNodes = xRoot?.SelectNodes("//PO_name");
            if (companyNodes is not null)
            {
                foreach (XmlNode node in companyNodes)
                    Console.WriteLine(node.InnerText);
            }
            ///4

            XDocument xdoc = new();

            XElement C = new("gm");
            XAttribute Type1 = new XAttribute("Type", "Soft");
            XAttribute PO_name1 = new XAttribute("PO_name", "Saper");
            XAttribute Game_name1 = new XAttribute("Game_name", "2003");

            // добавляем атрибут и элементы в первый элемент 
            C.Add(Type1);
            C.Add(PO_name1);
            C.Add(Game_name1);

            XElement C2 = new XElement("gm");
            XAttribute Type2 = new XAttribute("Type", "Application");
            XAttribute PO_name2 = new XAttribute("PO_name", "Snake");
            XAttribute Game_name2 = new XAttribute("Game_name", "2002");

            C2.Add(Type2);
            C2.Add(PO_name2);
            C2.Add(Game_name2);

            // создаем корневой элемент
            XElement SF = new("Soft");

            SF.Add(C);
            SF.Add(C2);
            // добавляем корневой элемент в документ
            xdoc.Add(SF);

            xdoc.Save("gm.xml");






            /*    Console.WriteLine("\n----------------- JSON -------------------");

                string fileName = "game.json";
                string json = JsonConvert.SerializeObject(game1);
                Console.WriteLine("Объект сериализован");
                File.WriteAllText(fileName, json);
                Console.WriteLine("Объект десериализован:");
                var data = JsonConvert.DeserializeObject<Game>(json);
                Console.WriteLine("Название: " + data._name);*/


            /* #region P1
             Game saper = new Game("Applied", "Pacman", "1999");
             *//* XmlSerializer xmlSerializer = new XmlSerializer(typeof(Game));
              using (FileStream fs = new FileStream("C:\\instit\\kurs2\\oop\\lab13\\lb13\\lb13\\Game.xml", FileMode.Create))
              {
                  xmlSerializer.Serialize(fs, saper);
                  Console.WriteLine("Object has been serialized");
              }*//*
             CustomSerializer<Game>.ToBinary(saper);
             CustomSerializer<Game>.ToXML(saper);
             CustomSerializer<Game>.ToJson(saper);

             Console.WriteLine("FromBinary: " + CustomSerializer<Game>.FromBinary());
            Console.WriteLine("FromXML: " + CustomSerializer<Game>.FromXML());
             //var a = CustomSerializer<Game>.FromXML();
            // Console.WriteLine(a.Game_name);
             Console.WriteLine("FromJson: " + CustomSerializer<Game>.FromJson());

             /////////2
             Console.WriteLine("-----------------------------------------------");
            Game[] games = new Game[]
          {
            new Game("Applied", "Pacman", "2002"),
            new Game("Soft", "Saper", "2003"),
            new Game("Applied", "Snake", "2005")
         };
             XmlSerializer formatter = new XmlSerializer(typeof(Game[]));

             using (FileStream fs = new FileStream("games.xml", FileMode.OpenOrCreate))
             {
                 formatter.Serialize(fs, games);
             }

             using (FileStream fs = new FileStream("games.xml", FileMode.OpenOrCreate))
             {
                 Game[]? newgames = formatter.Deserialize(fs) as Game[];

                 if (newgames != null)
                 {
                     foreach (Game person in newgames)
                     {
                         Console.WriteLine(person.ToString());
                     }
                 }
             }
             /////////3
             Console.WriteLine("-----------------------------------------------");
          *//*  // Game saper1 = new Game("Applied", "Saper", "2009");
             Game saper2 = new Game("Applied", "Snake", "1989");
             //CustomSerializer<Game>.ToXML(saper1);
             CustomSerializer<Game>.ToXML(saper2);*//*
             XmlDocument xDoc = new XmlDocument();
             xDoc.Load("games.xml");
             XmlElement? xRoot = xDoc.DocumentElement;

             Console.WriteLine("Выбор всех дочерних узлов Soft");
             XmlNodeList? nodes = xRoot?.SelectNodes("*");
             if (nodes is not null)
             {
                 foreach (XmlNode node in nodes)
                     Console.WriteLine(node.OuterXml);
             }

             XmlNodeList? personNodes = xRoot?.SelectNodes("Game_name");
             if (personNodes is not null)
             {
                 foreach (XmlNode node in personNodes)
                     Console.WriteLine(node.SelectSingleNode("@Game_name")?.Value);
             }

             #endregion

     */
        }

    }
}