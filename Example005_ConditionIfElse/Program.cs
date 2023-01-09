Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") // оператор перевода всех символов строки в нижний регистр
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
    Console.WriteLine("Привет, " + username + "!");
}
