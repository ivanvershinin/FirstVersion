using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZVershinin3
{
    class Game
    {
        
        public const int DefaultAge = 18;

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // 6,14,16,18
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Game(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Game(string name) 
            : this(name, DefaultAge) {
        }
    }
}
    

