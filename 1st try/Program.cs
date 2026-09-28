Console.WriteLine("Как тебя зовут?");
string name = Console.ReadLine();
Console.WriteLine("Где ты живешь?");
string city = Console.ReadLine();
Console.WriteLine("Сколько тебе лет?");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("===== Информация о пользователе =====");
Console.WriteLine($"Имя: {name}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Город: {city}");
Console.WriteLine("=====================================");