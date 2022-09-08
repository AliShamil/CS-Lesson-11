namespace CS_Lesson_11;


delegate void Func(string str);


class MyClass
{

    public readonly string? _str;

    public MyClass(string? str) => _str = str;

    public void Space(string str) => Console.WriteLine(string.Join('_', str.ToCharArray()));

    public void Reverse(string str) => Console.WriteLine(str.ToCharArray().Reverse().ToArray());


}





class Run
{
    public void runFunc(Func del, string str) => del(str);
}




class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string");

        var str = Console.ReadLine();
        MyClass cls = new MyClass(str);
        
        Func funcDell = (Func)Delegate.Combine((Func)cls.Space, (Func)cls.Reverse);// Delegatin source koduna baxdim ordan Combine in paramsnan islediyini gordum,
                                                                                   // ona uygun bele qeribe birsey alindi
        Run run = new Run();
        run.runFunc(funcDell, str);



    }

}