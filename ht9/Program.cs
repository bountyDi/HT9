int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task64()
{
    //Задайте значения M и N. Напишите рекурсивный метод, который
    //выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    int m = Input("Enter start number");
    int n = Input("Enter final number");
    while (m<=n)
    {
        if (m%3==0) Console.WriteLine(m);
        m++;
    }
}

void Recurcion64(int m, int n)
{
    if (m>n) return;
    if (m%3==0) Console.WriteLine(m);
    m++;
    Recurcion64(m, n);
}


void Task66()
{
    //Задайте значения M и N. Напишите рекурсивный метод, кот. 
    //найдёт сумму натуральных элементов в промежутке от M до N.
    int m = Input("Enter start number");
    int n = Input("Enter final number");
    int sum = 0;
    while (m<=n)
    {
        sum+=m;
        m++;
    }
    Console.WriteLine(sum);
}

void Recurcion66(int m, int n, int sum)
{
    if (m>n) 
    {
        return;
        Console.WriteLine(sum);
    }
    sum+=m;
    Recurcion66(m+1, n, sum);
}
//Recurcion66(1, 15, 0); 



