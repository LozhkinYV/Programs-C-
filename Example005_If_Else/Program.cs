Console.Write("Введите имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша") // .ToLower() позволяет вкл нижний регистр, т.е. мыможем хоть строчные хоть заглавные в имени писать - это все одно будет
{
    Console.WriteLine("Ура, это же МАША!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}