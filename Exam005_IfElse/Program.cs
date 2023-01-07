Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if(username.ToLower() == "vera")
{
    Console.WriteLine("Ура, это же Vera!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
