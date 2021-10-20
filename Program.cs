using System;

namespace Program
{
   class Program
   {
      static void Main(string[] args)
      {
         //Console.WriteLine("Цикл while");
         //int t = 0;


         //do
         //{
         //   Console.WriteLine(t);

         //   Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
         //   switch (Console.ReadLine())
         //   {
         //      case "red":
         //         Console.BackgroundColor = ConsoleColor.Red;
         //         Console.ForegroundColor = ConsoleColor.Black;

         //         Console.WriteLine("Your color is red!");
         //         break;

         //      case "green":
         //         Console.BackgroundColor = ConsoleColor.Green;
         //         Console.ForegroundColor = ConsoleColor.Black;

         //         Console.WriteLine("Your color is green!");
         //         break;

         //      case "cyan":
         //         Console.BackgroundColor = ConsoleColor.Cyan;
         //         Console.ForegroundColor = ConsoleColor.Black;

         //         Console.WriteLine("Your color is cyan!");
         //         break;
         //      default:
         //         Console.BackgroundColor = ConsoleColor.Yellow;
         //         Console.ForegroundColor = ConsoleColor.Red;

         //         Console.WriteLine("Your color is yellow!");
         //         break;
         //   }

         //   t++;

         //} while (t < 3);
         (string FirstName, string SecondName, string Login, bool Pet, double Age, string[] Colors) User;
         int t = 0;
         do
         {
            Console.WriteLine("Введите имя");
            User.FirstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.SecondName = Console.ReadLine();
            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
            int LenghtLogin = User.Login.Length;
            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            string Answer = Console.ReadLine();
            User.Pet = Answer == "Да";
            Console.WriteLine("Введите возраст пользователя");
            User.Age = double.Parse(Console.ReadLine());
            User.Colors = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя");
            for (var i = 0; i < User.Colors.Length; i++)
            {
               User.Colors[i] = Console.ReadLine();
            }
            t++;
         } while (t < 3) ;
      }
   }
}
