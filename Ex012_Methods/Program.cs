
// вид 1
//ничего не принимает ничего не возвращает
void Method1()
{
    Console.WriteLine("автор ..");
}
Method1();


//вид 2
// принимает но не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("текст");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "hello ", count: 3); // так можно писать не попорядку
Method21(count: 3, msg: "hello 2"); 

//вид 3
// чтото возвращает но ничего не принимает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//вид 4
// чтото принимает чтото возвращает

string Method4(int count, string text)
{
    int i=0;
    string result = string.Empty;//пустая строка

    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);