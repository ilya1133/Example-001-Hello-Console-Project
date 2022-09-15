Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "настя")
{
    Console.WriteLine("Привет, любимая Настена!");
} 
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username); 
}