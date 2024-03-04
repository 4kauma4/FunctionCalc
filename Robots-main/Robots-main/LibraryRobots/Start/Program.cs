// See https://aka.ms/new-console-template for more information
using LibraryRobots;

Robots robot1 = new Robots("Робот 1", 200, 199);
Robots robot2 = new Robots("Робот 2", 200, 199);

robot1.StartMoving();
robot2.StartMoving();


for (int i = 0; i < 5; i++)
{
 
    Console.WriteLine(robot1.GetInfo());
    Console.WriteLine(robot2.GetInfo());

    Thread.Sleep(2000);
    Console.WriteLine("Поток завершен!");
}

