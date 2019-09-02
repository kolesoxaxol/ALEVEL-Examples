using System;

namespace Example4
{

    public interface IName
    {
        void WriteName();
    }

    public interface INameFamily
    {
        // Объявляем в данном интерфейсе такой же метод
        void WriteName();
        void WriteFamily();
    }

    public interface IUserInfo : INameFamily
    {
        // Обязательно нужно указать ключевое слово new
        // чтобы не скрывались методы базового интерфейса
        new void WriteName();
        void WriteUserInfo();
    }


    // Класс, реализующий два интерфейса
    class UserInfo : IUserInfo, IName
    {
        string ShortName, Family, Name;

        public UserInfo(string Name, string Family, string ShortName)
        {
            this.Name = Name;
            this.Family = Family;
            this.ShortName = ShortName;
        }

        // Используем явную реализацию интерфейсов
        // для исключения неоднозначности
        void IName.WriteName()
        {
            Console.WriteLine("Короткое имя: " + ShortName);
        }

        void INameFamily.WriteFamily()
        {
            Console.WriteLine("Фамилия: " + Family);
        }

        void INameFamily.WriteName()
        {
            Console.WriteLine($"Полное имя: {Name} {Family}");
        }

        void IUserInfo.WriteName()
        {
            Console.WriteLine("user info name");
        }

        public void WriteUserInfo()
        {
            UserInfo obj = new UserInfo(Name, Family, ShortName);
            // Для использования закрытых методов необходимо
            // создать интерфейсную ссылку
            IName link1 = (IName)obj;
            link1.WriteName();
            INameFamily link2 = (INameFamily)obj;
            link2.WriteName();
            link2.WriteFamily();
            IUserInfo link3 = (IUserInfo)obj;
            link3.WriteName();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            UserInfo obj = new UserInfo(Name: "Yevhenii", ShortName: "YK", Family: "Koliesnik");
            obj.WriteUserInfo();
            Console.ReadLine();
        }
    }
}
