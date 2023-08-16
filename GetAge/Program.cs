using System.Globalization;

namespace GetAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = GetBirthday();
            int age = GetAge(birthday);
            ShowAge(age);
        }

        static void ShowAge(int age)
        {
            Console.WriteLine($"\nYou are {age} years old.");
        }

        static int GetAge(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            if (birthdate > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        static DateTime GetBirthday()
        {
            DateTime dt;
            string dateFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            do Console.Write($"\nWrite your birthday ({dateFormat}): ");
            while (!DateTime.TryParse(Console.ReadLine(), out dt));
            return dt;
        }


    }
}