using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Max", 10);
            Player player1 = new Player("Ivan", 15);

            player.ShowInfo();
            player1.ShowInfo();
        }
    }

    class Player
    {
        private string _name;
        private int _level; 

        public Player(string name, int level)
        {
            _name = name;
            _level = level;
        }

        public void ShowInfo ()
        {
            Console.WriteLine($"Игрок с ником {_name}. Уровень - {_level}");
        }
    }
}
