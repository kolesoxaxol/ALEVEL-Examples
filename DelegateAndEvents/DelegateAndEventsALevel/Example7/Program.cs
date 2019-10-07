using System;

delegate void UI();

class MyEvent
{
    UI[] evnt = new UI[5];

    // Объявляем событие
    public event UI UserEvent
    {
        // Используем аксессоры событий
        add
        {
            evnt[1] = value;
        }

        remove
        {
            evnt[1] = null;
        }
    }

    // Используем метод для запуска события
    public void OnUserEvent()
    {
        evnt[1]();
    }
}

class UserInfo
{
    string uiName, uiFamily;
    int uiAge;

    public UserInfo(string Name, string Family, int Age)
    {
        this.Name = Name;
        this.Family = Family;
        this.Age = Age;
    }

    public string Name { set { uiName = value; } get { return uiName; } }
    public string Family { set { uiFamily = value; } get { return uiFamily; } }
    public int Age { set { uiAge = value; } get { return uiAge; } }

    // Обработчик события
    public void UserInfoHandler()
    {
        Console.WriteLine("Событие вызвано!\n");
        Console.WriteLine("Имя: {0}\nФамилия: {1}\nВозраст: {2}", Name, Family, Age);
    }
}

class Program
{
    static void Main()
    {
        MyEvent evt = new MyEvent();  
        UserInfo user1 = new UserInfo(Name: "Alex", Family: "Erohin", Age: 26);

        // Добавляем обработчик события
        evt.UserEvent += user1.UserInfoHandler;

        // Добавляем обработчик события
        evt.UserEvent += user1.UserInfoHandler;

        // Запустим событие
        evt.OnUserEvent();

        Console.ReadLine();
    }
}