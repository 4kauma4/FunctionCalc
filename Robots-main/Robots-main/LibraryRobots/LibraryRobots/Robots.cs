using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryRobots
{
    public class Robots
    {
        private string name;
        private int x;
        private int y;
        private int direction;
        private Thread moveThread;

        public Robots(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            Random rnd = new Random();
            this.direction = rnd.Next(0, 4);
            moveThread = new Thread(Move);
        }

        public void StartMoving()
        {
            moveThread.Start();
        }

        private void Move()
        {
                switch (direction)
                {
                    case 0:
                        y++;
                        break;
                    case 1:
                        y--;
                        break;
                    case 2:
                        x--;
                        break;
                    case 3:
                        x++;
                        break;
                    default:
                        break;
                }

            Thread.Sleep(1000);
    
        }

        public string GetInfo()
        {
            string dir = "";
            switch (direction)
            {
                case 0:
                    dir = "Вперед";
                    break;
                case 1:
                    dir = "Назад";
                    break;
                case 2:
                    dir = "Налево";
                    break;
                case 3:
                    dir = "Направо";
                    break;
                default:
                    break;
            }

            return $"{name} {dir} ({x}, {y})";
        }
    }
}
