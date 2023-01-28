void Metod1()
{
	for (int i = 0; i < 1000; i++)
	{
		Console.WriteLine(i);
	}
}

void Metod2()
{
	for (int i = 0; i < 100; i++)
	{
		Console.WriteLine("ILKER");
	}
}

//Metod1();
//Metod2();


ThreadStart ts1 = new ThreadStart(Metod1);
ThreadStart ts2 = new ThreadStart(Metod2);
Thread t1 = new Thread(ts1);
Thread t2 = new Thread(ts2);

t1.Start();
t2.Start();