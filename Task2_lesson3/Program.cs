// 1ый вид метода НИЧЕГО НЕ ПРИНЕМАЮТ НИЧЕГО НЕ ВОЗВРАЩАЮТ 
//2ой вид метода принемают , но ничего не возвращают 
//3ий вид метода  ничего не принемают, но что-то возвращают 
//4ый вид метода что -то принимаю и что-то возвращают 

//вид 1
void Method1() //наиминование в скобках нет аргументов
{
Console.WriteLine("автор..."); // что-то выводит на экран
}
 Method1();//что-то вызаваем
 
 
 
 // вид 2
void Method21( string msg, int count); 
int i =0;
while (i<count)
{
Console.WriteLine("msg");
i++;
}

//Method21(msg: "текст",  count: 4); 
Method21(count: 4, msg: "новый текст");

//3 вид
 int Method3()
 {
 return DateTime.Now.Year;
 }
int year = Method3();
System.Console.WriteLine(year);

// 4 вид 

string Method4(int count,  string text )
{
int i =0;
string result = String.Empty;
while (i<count)
{
  result=result+text;
  i++;
}
return result;
}
string res = Method4(10, "Z");
Console.WriteLine(res);