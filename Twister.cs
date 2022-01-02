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
            _bodyParts = new string[] { "Right foot", "Left foot", "Left hand", "Right hand", "Right foot", "Left foot", "Left hand", "Right hand" };
            _colors = new string[] { "Green", "Red", "Blue", "Yellow", "Green", "Red", "Blue", "Yellow" };
        }
        public (string, string) GetMove()
        {
            rand = new Random();
            int index = rand.Next(8);
            Random r_new = new Random();
            int _body = r_new.Next(8);
            return ($"Put your {_bodyParts[_body]} on {_colors[index]}", _colors[index]); 
        }
    }
}
