public class Calculate
{
    //() => ..
    //x=>...
    //(x,y,x) => ...


    public static void Main(string[] args)
    {
        Func<int, int> square = number => number * number;

        //return number * number;

        const int factor = 5;

        Func<int, int> multipler = n => n * factor;

        var result = multipler(10);
    }


}