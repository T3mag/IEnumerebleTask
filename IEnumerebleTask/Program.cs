namespace IEnumerableTask;

public static class Program
{
    public static void Main()
    {
        var str = "asdasd asdasdas sad asdasdas sadasdasdas s";
        MyStringConverter strings = new MyStringConverter(str);
        
        foreach (var i in strings)
            Console.WriteLine(i);
            
    }
}