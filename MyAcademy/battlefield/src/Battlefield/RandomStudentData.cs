using System;
using System.Collections.Generic;

namespace Battlefield
{
    class RandomStudentData
    {
        public string Name;
        public int Mathematics;
        public int Swedish;
        public int English;

        public RandomStudentData()
        {
            Name = GenerateName();
            Mathematics = GetRandomScore();
            Swedish = GetRandomScore();
            English = GetRandomScore();
            GenerateName();
        }

        private static readonly Random getrandom = new Random();

        private string GenerateName()
        {
            List<string> names = new List<string>(){
                    "Erik Andersson","Lars Johansson","Karl Karlsson",
                    "Anders Nilsson","Johan Eriksson","Per Larsson",
                    "Nils Olsson","Carl Persson","Mikael Svensson",
                    "Jan Gustafsson","Hans Pettersson","Lennart Jonsson",
                    "Peter Jansson","Olof Hansson","Gunnar Bengtsson",
                    "Sven Carlsson","Fredrik Jönsson","Bengt Lindberg",
                    "Daniel Petersson","Bo Magnusson","Gustav Lindström",
                    "Alexander Gustavsson","Göran Olofsson","Åke Lindgren",
                    "Magnus Axelsson","Martin Bergström","Andreas Lundberg",
                    "Stefan Lundgren","John Berg","Mats Jakobsson",
                    "Leif Berglund","Ulf Sandberg","Thomas Fredriksson",
                    "Björn Mattsson","Henrik Sjöberg","Jonas Forsberg",
                    "Axel Henriksson","Bertil Lindqvist","Christer Lind",
                    "Arne Engström","Robert Eklund","Ingemar Lundin",
                    "David Danielsson","Emil Ali","Kjell Håkansson",
                    "Håkan Holm","Stig Gunnarsson","Rolf Bergman",
                    "Mattias Samuelsson","William Fransson","Oskar Nyström",
                    "Roland Lundqvist","Tommy Björk","Patrik Holmberg",
                    "Michael Wallin","Joakim Johnsson","Simon Arvidsson",
                    "Christian Söderberg","Roger Nyberg","Marcus Isaksson",
                    "Gustaf Nordström","Sebastian Mårtensson","Anton Lundström",
                    "Oscar Björklund","Ingvar Eliasson","Eric Berggren",
                    "Olov Ahmed","Tomas Sandström","Viktor Nordin",
                    "Johannes Ström","Tobias Åberg","Niklas Ekström",
                    "Kent Hermansson","Hugo Holmgren","Ove Hedlund",
                    "Elias Sundberg","Emanuel Sjögren","Adam Dahlberg",
                    "Robin Mohamed","Jörgen Martinsson","Rune Öberg",
                    "Filip Hellström","Kenneth Strömberg","Gösta Månsson",
                    "Ali Blom","Wilhelm Ek","Linus Abrahamsson",
                    "Arvid Falk","Jonathan Blomqvist","Albin Norberg",
                    "Kurt Åkesson","Sten Lindholm","Dan Sundström",
                    "Rickard Löfgren","Alf Åström","Olle Jonasson",
                    "Vilhelm Dahl","Oliver Söderström","Claes Jensen",
                    "Torbjörn Andreasson"
                    };
            
            int min = 0;  int max = names.Count;
            lock(getrandom)
            {
                int random_index =  getrandom.Next(min, max);
                return names[random_index];
            }
        }
        

        private static int GetRandomScore()
        {
            int min = 0;  int max = 20;
            lock(getrandom)
            {
                return getrandom.Next(min, max);
            }
        }
    }
}
