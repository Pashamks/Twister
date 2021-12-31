using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twister
{
    public class Twister
    {
        Random rand;
        string []_bodyParts;
        string[] _colors;
        public Twister()
        {
            rand = new Random();
            _bodyParts = new string[] { "Right foot", "Left foot", "Left hand", "Right hand" };
            _colors = new string[] { "Green", "Red", "Blue", "Yellow" };
        }
        public string GetMove()
        {
            int index = rand.Next(4);
            return $"Put your {_bodyParts[index]} on {_colors[index]}"; 
        }
    }
}
