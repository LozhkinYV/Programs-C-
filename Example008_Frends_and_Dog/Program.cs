//Навстречу идут 2 друга и между ними бегает собака.Сколько раз она подбежит Скорость1 = 1, Скорость2 = 2, расстояние между ними 10000, скорость собаки 5
int cout = 0;
int distance = 10000;
int FFSpeed = 1;
int SFSpeed = 2;
int dogSpeed = 5;
int frend = 2;
int time = 0;
while (distance>10)
{
    if (frend ==1)
    {
        time = distance/(FFSpeed+dogSpeed);
        frend = 2;
    }
    else
    {
        time = distance/(SFSpeed+dogSpeed);
        frend = 1; 
    }
    distance = distance - (FFSpeed+SFSpeed)*time;
    cout++;
}
Console.WriteLine(cout);