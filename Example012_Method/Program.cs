// Вид1 методы, которые ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("Метод1");
}

//Обращение к этому методу
Method1();

//Вид2 методы которые ничего не возвращают но на входе принимают какойто аргумент.
void Method2(string msg1, string msg2)
{
   Console.WriteLine(msg1); 
   Console.WriteLine(msg2);
}

//Обращение к этому методу
Method2("метод2", "Лекция3");
//Если аргументов несколько то можно еще указать, аргументы указанные можно вписывать не по порядку - вывод будет таким же как и в предыдущем
Method2(msg2: "Лекция3", msg1: "метод2");

//Вид3 методы которые не принимает аргументы но возвращает
string Method3()
{
    return Console.ReadLine();
}

//Обращение к этому методу
string a = Method3();
Console.WriteLine(a);


//Вид4 методы которые принимают на вход и что-то возвращают
string Method4(int count, string c)
{
    int i=0;
    string resalt = string.Empty; // пустая строка
    while(i<count)
    {
        resalt = resalt + c;
        i++;
    }
    return resalt;
}

//Обращение к этому методу
string res = Method4(5, "Метод4");
Console.WriteLine(res);
