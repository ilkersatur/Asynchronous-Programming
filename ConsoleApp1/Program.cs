using System.Diagnostics;

Stopwatch sw = new Stopwatch();

sw.Start();
//Islem1();
//Islem2();
//Islem1Async();
//Islem2Async();
//await Islem1Async();
//await Islem2Async();
 
//Program 10 saniyede tamamlandı
await Task.WhenAll(Islem1Async(), Islem2Async());
sw.Stop();

void Islem1()
{
    Console.WriteLine("Islem1 basladi..." + sw.ElapsedMilliseconds);
    Thread.Sleep(10000);
    Console.WriteLine("Islem1 Bitti" + sw.ElapsedMilliseconds);
}

void Islem2()
{
    Console.WriteLine("Islem2 basladi..." + sw.ElapsedMilliseconds);
    Thread.Sleep(6000);
    Console.WriteLine("Islem2 Bitti" + sw.ElapsedMilliseconds);
}


///////////////////////////////////////////////////////////////////////////

async Task Islem1Async()
{
    Console.WriteLine("Islem1 basladi..." + sw.ElapsedMilliseconds);
    await Task.Delay(10000);
    Console.WriteLine("Islem1 Bitti" + sw.ElapsedMilliseconds);
}

async Task Islem2Async()
{
    Console.WriteLine("Islem2 basladi..." + sw.ElapsedMilliseconds);
    await Task.Delay(6000);
    Console.WriteLine("Islem2 Bitti" + sw.ElapsedMilliseconds);
}