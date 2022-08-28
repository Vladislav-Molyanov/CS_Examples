Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "лена" ) 
{
    Console.WriteLine("Ура, это же ЛЕНА");
}
else
{
    Console.Write ("Привет,");
    Console.WriteLine(username);

}