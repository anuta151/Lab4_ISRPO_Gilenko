Console.WriteLine(" Лабораторная работа №4 ");
Console.WriteLine("Добро пожаловать!");
Console.WriteLine("ФИО: Гиленко Анна");
Console.WriteLine("Группа: ИСП-241");
Console.WriteLine($"Дата и время: {DateTime.Now}");

bool running = true;
while (running)
{
    Console.WriteLine();
    Console.WriteLine("Меню:");
    Console.WriteLine("1 — Показать ФИО");
    Console.WriteLine("2 — Показать группу");
    Console.WriteLine("3 — Показать дату");
    Console.WriteLine("4 — Выход");
    Console.Write("Ваш выбор: ");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine("ФИО: Гиленко Анна");
            break;
        case "2":
            Console.WriteLine("Группа: ИСП-244");
            break;
        case "3":
            Console.WriteLine($"Дата и время: {DateTime.Now}");
            break;
        case "4":
            Console.WriteLine("До свидания!");
            running = false;
            break;
        default:
            Console.WriteLine("Неверный ввод. Попробуйте снова.");
            break;
    }
}