Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if (username?.ToLower() == "vera") // чтобы разрешить переменной username = null, добален "?" после username
{
    Console.WriteLine("Ура, это же Vera!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
