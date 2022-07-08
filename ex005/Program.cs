Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша")
{
     Console.WriteLine("Ура! Это же Маша!");
}
else 
{
     Console.Write("Ну здрасте) ");
     Console.WriteLine(userName);
}