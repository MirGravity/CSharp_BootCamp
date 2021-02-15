using System;

namespace CSharpBootCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeworkDemo();
        }

        private static void HomeworkDemo()
        {
            string name = GetString("Enter your name: ");
            string surename = GetString("Enter your surename: ");

            int age = GetInt("Enter your age: ");

            float weight = GetFloat("Enter your weight: ");
            float height = GetFloat("Enter your height: ");

            Console.WriteLine($"{name} {surename} is {age} years old, " +
                $"his weight is {weight} kg and his height is {height} cm.");

            ShowBMI(weight, height);
        }

        private static string GetString(string msg)
        {
            Console.WriteLine(msg);
            string name = Console.ReadLine();
            return name;
        }
        private static int GetInt(string msg)
        {
            Console.WriteLine(msg);
            int name = int.Parse(Console.ReadLine());
            return name;
        }
        private static float GetFloat(string msg)
        {
            Console.WriteLine(msg);
            float name = float.Parse(Console.ReadLine());
            return name;
        }

        private static void ShowBMI(float w, float h)
        {
            h = h / 100;
            float BMI = w / h / h;
            Console.WriteLine($"Your body mass index(BMI) is: {BMI}.");
        }
    }
}
