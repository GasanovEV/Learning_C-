Console.Clear ();
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "kate")
{
    Console.WriteLine ("Ура! Это же Kate!");
}
else
{
    Console.WriteLine("Привет,");
    Console.WriteLine(username);
         
}