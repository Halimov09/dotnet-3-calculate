
// calc
Console.Write("first number ");
double firstNumber = double.Parse(Console.ReadLine());

Console.Write("second number ");
double secondNumber = double.Parse(Console.ReadLine());

Console.Write("enter operations ");
string operations = Console.ReadLine();

if (operations == "+"){
    Console.WriteLine($"{firstNumber + secondNumber}");
}else if(operations == "-"){
    Console.WriteLine($"{firstNumber - secondNumber}");
}else if(operations == "*"){
    Console.WriteLine($"{firstNumber * secondNumber}");
}else if(operations == "/"){
    Console.WriteLine($"{firstNumber / secondNumber}");
}



// add number
int inc = 0;
Console.Write("enter the number ");
int getNumber = int.Parse(Console.ReadLine());



for (int i = 0; i <= getNumber; i++)
{
  inc += i;
}

Console.WriteLine(inc);


// couple or odd
Console.Write("enter the number ");
double equal = double.Parse(Console.ReadLine());



if (equal % 2 == 0)
{
    Console.WriteLine("couple");
}else{
    Console.WriteLine("odd");
}
