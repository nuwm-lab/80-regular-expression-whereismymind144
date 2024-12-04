using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LabWork
{
    // Даний проект є шаблоном для виконання лабораторних робіт
    // з курсу "Об'єктно-орієнтоване програмування та патерни проектування"
    // Необхідно змінювати і дописувати код лише в цьому проекті
    // Відео-інструкції щодо роботи з github можна переглянути 
    // за посиланням https://www.youtube.com/@ViktorZhukovskyy/videos 
    class Program
    {
        static void Main(string[] args)
        {
            // Вхідне речення
            Console.WriteLine("Введіть речення:");
            string sentence = Console.ReadLine();

            // Регулярний вираз для знаходження слів
            string pattern = @"\b\w+\b";

            // Створення об'єкта Regex
            Regex regex = new Regex(pattern);

            // Знаходження всіх слів у реченні
            MatchCollection matches = regex.Matches(sentence);

            // Виведення слів у стовпчик
            Console.WriteLine("Слова у стовпчик:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}