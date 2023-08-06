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

int Recurcion66(int m, int n, int sum =0)
{
    if (m>n) 
    {
        return sum;
    }
    sum+=m;
    return Recurcion66(m+1, n, sum);
}
//int m = Input("Enter start number");
//int n = Input("Enter final number");
//int sum = Recurcion66(m, n);
//Console.WriteLine($"Сумма чисел в промежутке от m до n = {sum}"); 

int A(int m, int n)
{
    if (m==0) return n+1;
    else if (n==0) return A(m-1, 1);
    else 
    {
        return A(m-1,A(m,n-1));
    }
}
int m = Input("Enter firs number");
int n = Input("Enter second number");
Console.WriteLine($"Ackermann({m}, {n}) = {A(m,n)}");


