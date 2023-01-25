using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

class MyClass
{
    static void Main(string[] args)
    {
        Test();
        Console.ReadLine();
    }
    async static Task Test()
    {
        await Calculate();
    }
    private async static Task Calculate()
    {
        //Task<int> task1 = Task.Run(() =>
        //{
        //    return Calculate1();

        //});

        //TaskAwaiter<int> awaiter1 = task1.GetAwaiter();
        //awaiter1.OnCompleted(() =>
        //{
        //    int result1 = awaiter1.GetResult();
        //    Calculate2(result1);
        //});

        await Calculate_1And2();
        
        Calculate3();

    }
   static async Task Calculate_1And2()
        {
            var result1 = await Task.Run(() =>
            {
                return Calculate1();
            });
            Calculate2(result1);
        }
    private static int Calculate1()
    {
        Thread.Sleep(3000);
        Console.WriteLine("Calculating result1");
        return 50;
    }

    private static int Calculate2(int result1)
    {
        Console.WriteLine("Calculating result2");
        return 150+result1;
    }

    private static int Calculate3()
    {
        Console.WriteLine("Calculating result3");
        return 179;
    }
}