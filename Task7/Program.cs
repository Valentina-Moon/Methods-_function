
//модификатор(static) тип вазращаемого значения метода(параметры) 
// {
// тело метода   
// }


static int Sum(int a, int b)
{
    int result = a + b; // можно поменять логику выполнения a*b// valua-1 = a; valua_2= b


    return result;
}

int a, b, c;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

//c= a + b;
int c = Sum(a, b);
Console.WriteLine(c);
