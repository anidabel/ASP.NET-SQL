using Players.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Players
{
    public class SampleData
    {
        public static void Initialize(PlayerContext context)
        {
            if (!context.players.Any())
            {
                context.players.AddRange(
                    new Player
                    {
                        PlayerId = "adamlem",
                        Jersey = 12,
                        FName = "Mike",
                        SName = "Adamle",
                        Position = "RW",
                        BirthDay = new DateTime(2001, 9, 21),
                        Weigth = 73,
                        Height = 197,
                        BirthCity = "Stamford",
                        BirthState = "CT"
                    },
                    new Player
                    {
                        PlayerId = "adamles",
                        Jersey = 17,
                        FName = "Scott",
                        SName = "Adamle",
                        Position = "D",
                        BirthDay = new DateTime(1999, 3, 1),
                        Weigth = 70,
                        Height = 184,
                        BirthCity = "Columbs",
                        BirthState = "OH"
                    },
                    new Player
                    {
                        PlayerId = "aramnova",
                        Jersey = 31,
                        FName = "Arkady",
                        SName = "Aramnov",
                        Position = "LW",
                        BirthDay = new DateTime(1998, 10, 25),
                        Weigth = 71,
                        Height = 195,
                        BirthCity = "Minsk",
                        BirthState = "RU"
                    },
                    new Player
                    {
                        PlayerId = "boolea",
                        Jersey = 8,
                        FName = "Alexi",
                        SName = "Boole",
                        Position = "RW",
                        BirthDay = new DateTime(1997, 09, 14),
                        Weigth = 72,
                        Height = 194,
                        BirthCity = "Kiev",
                        BirthState = "UK"
                    },
                    new Player
                    {
                        PlayerId = "choakd",
                        Jersey = 11,
                        FName = "Dominick",
                        SName = "Choak",
                        Position = "RW",
                        BirthDay = new DateTime(1997, 2, 22),
                        Weigth = 72,
                        Height = 196,
                        BirthCity = "Prague",
                        BirthState = "CZ"
                    },
                    new Player
                    {
                        PlayerId = "clobberk",
                        Jersey = 24,
                        FName = "Kiroy",
                        SName = "Clobber",
                        Position = "D",
                        BirthDay = new DateTime(2002, 6, 21),
                        Weigth = 73,
                        Height = 200,
                        BirthCity = "Bangor",
                        BirthState = "ME"
                    },
                    new Player
                    {
                        PlayerId = "clubbes",
                        Jersey = 7,
                        FName = "Sam",
                        SName = "Clubbe",
                        Position = "LW",
                        BirthDay = new DateTime(1999, 7, 26),
                        Weigth = 75,
                        Height = 190,
                        BirthCity = "Paramus",
                        BirthState = "HJ"
                    },
                    new Player
                    {
                        PlayerId = "finleyp",
                        Jersey = 14,
                        FName = "Peter",
                        SName = "Finley",
                        Position = "D",
                        BirthDay = new DateTime(1987, 6, 8),
                        Weigth = 76,
                        Height = 194,
                        BirthCity = "Denver",
                        BirthState = "CO"
                    },
                    new Player
                    {
                        PlayerId = "fiskj",
                        Jersey = 25,
                        FName = "Jerke",
                        SName = "Fisk",
                        Position = "D",
                        BirthDay = new DateTime(2001, 11, 25),
                        Weigth = 71,
                        Height = 193,
                        BirthCity = "Helsinki",
                        BirthState = "FI"
                    },
                    new Player
                    {
                        PlayerId = "gruberh",
                        Jersey = 29,
                        FName = "Hans",
                        SName = "Gruber",
                        Position = "D",
                        BirthDay = new DateTime(1991, 2, 11),
                        Weigth = 70,
                        Height = 175,
                        BirthCity = "Munich",
                        BirthState = "DE"
                    },
                    new Player
                    {
                        PlayerId = "Grunwala",
                        Jersey = 6,
                        FName = "Allan",
                        SName = "Grunwald",
                        Position = "C",
                        BirthDay = new DateTime(1990, 10, 17),
                        Weigth = 74,
                        Height = 189,
                        BirthCity = "Buffalo",
                        BirthState = "NY"
                    },
                    new Player
                    {
                        PlayerId = "ivanovv",
                        Jersey = 4,
                        FName = "Valerei",
                        SName = "Ivanovich",
                        Position = "C",
                        BirthDay = new DateTime(2004, 9, 20),
                        Weigth = 72,
                        Height = 175,
                        BirthCity = "Moscow",
                        BirthState = "RU"
                    },
                    new Player
                    {
                        PlayerId = "jeffriea",
                        Jersey = 30,
                        FName = "Angus",
                        SName = "Jeffries",
                        Position = "G",
                        BirthDay = new DateTime(1995, 11, 8),
                        Weigth = 70,
                        Height = 185,
                        BirthCity = "Springfield",
                        BirthState = "MA"
                    },
                    new Player
                    {
                        PlayerId = "jonesr",
                        Jersey = 35,
                        FName = "Robert",
                        SName = "Jones",
                        Position = "C",
                        BirthDay = new DateTime(1997, 5, 22),
                        Weigth = 73,
                        Height = 189,
                        BirthCity = "Hartford",
                        BirthState = "CT"
                    },
                    new Player
                    {
                        PlayerId = "lexourb",
                        Jersey = 9,
                        FName = "Bruce",
                        SName = "Lexour",
                        Position = "D",
                        BirthDay = new DateTime(2001, 9, 5),
                        Weigth = 75,
                        Height = 198,
                        BirthCity = "Quincy",
                        BirthState = "IL"
                    },
                    new Player
                    {
                        PlayerId = "lunds",
                        Jersey = 93,
                        FName = "Steven",
                        SName = "Lund",
                        Position = "D",
                        BirthDay = new DateTime(1997, 5, 22),
                        Weigth = 71,
                        Height = 193,
                        BirthCity = "St.Paul",
                        BirthState = "MN"
                    },
                    new Player
                    {
                        PlayerId = "manguirea",
                        Jersey = 34,
                        FName = "Andre",
                        SName = "Manguire",
                        Position = "LW",
                        BirthDay = new DateTime(1999, 12, 8),
                        Weigth = 75,
                        Height = 191,
                        BirthCity = "Detroit",
                        BirthState = "MI"
                    },
                    new Player
                    {
                        PlayerId = "meyersd",
                        Jersey = 28,
                        FName = "Doug",
                        SName = "Meyers",
                        Position = "G",
                        BirthDay = new DateTime(1998, 2, 11),
                        Weigth = 70,
                        Height = 195,
                        BirthCity = "Chicago",
                        BirthState = "IL"
                    },
                    new Player
                    {
                        PlayerId = "olsens",
                        Jersey = 37,
                        FName = "Sandish",
                        SName = "Olsen",
                        Position = "D",
                        BirthDay = new DateTime(1999, 8, 16),
                        Weigth = 72,
                        Height = 192,
                        BirthCity = "Stockholm",
                        BirthState = "IL"
                    },
                    new Player
                    {
                        PlayerId = "quivep",
                        Jersey = 20,
                        FName = "Pierre",
                        SName = "Quive",
                        Position = "LW",
                        BirthDay = new DateTime(1991, 7, 19),
                        Weigth = 71,
                        Height = 197,
                        BirthCity = "Quebec",
                        BirthState = "QU"
                    },
                    new Player
                    {
                        PlayerId = "springej",
                        Jersey = 38,
                        FName = "Junior",
                        SName = "Springer",
                        Position = "C",
                        BirthDay = new DateTime(1995, 10, 14),
                        Weigth = 71,
                        Height = 184,
                        BirthCity = "Toronto",
                        BirthState = "ON"
                    },
                    new Player
                    {
                        PlayerId = "sullivar",
                        Jersey = 39,
                        FName = "Russel",
                        SName = "Sullivan",
                        Position = "G",
                        BirthDay = new DateTime(2000, 3, 8),
                        Weigth = 70,
                        Height = 186,
                        BirthCity = "Vancouver",
                        BirthState = "BC"
                    },
                    new Player
                    {
                        PlayerId = "travisj",
                        Jersey = 19,
                        FName = "John",
                        SName = "Travis",
                        Position = "C",
                        BirthDay = new DateTime(2003, 6, 23),
                        Weigth = 74,
                        Height = 200,
                        BirthCity = "Boston",
                        BirthState = "MA"
                    },
                    new Player
                    {
                        PlayerId = "zauberz",
                        Jersey = 22,
                        FName = "Zeke",
                        SName = "Zauber",
                        Position = "RW",
                        BirthDay = new DateTime(1988, 8, 31),
                        Weigth = 74,
                        Height = 203,
                        BirthCity = "Moosehead",
                        BirthState = "MA"
                    }
                 );
                context.SaveChanges();
            }
        }
    }
}
