//Баранович Артур
//6. * Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
study.pause();
study.print();

class study
{
    static public void print()
    {
        Console.WriteLine("Расписание на завтра:\n1.Английский\n2.Геометрия\n3.Алгебра\n4.География");
    }
    static public void pause()
    {
        Console.ReadKey(true);
    }
}