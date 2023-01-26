Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "хрен")
{
    Console.WriteLine("Ура, это же Хрен");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}