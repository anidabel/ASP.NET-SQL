using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Players.Models
{
    public class Player
    {
        public string PlayerId { get; set; }
        public int Jersey { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Position { get; set; }
        public DateTime BirthDay { get; set; }
        public int Weigth { get; set; }
        public int Height { get; set; }
        public string BirthCity { get; set; }
        public string BirthState { get; set; }
    }
}
