Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ариша")
{
    Console.WriteLine("Ура, это же АРИША!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}