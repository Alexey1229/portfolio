void SayHello()
{
    Console.WriteLine("Привет, мир");
}

SayHello();
SayHello();
SayHello();

void Greet(string name)
{
    Console.WriteLine($"Привет, {name}");
}

Greet("Саша");
Greet("Ярослав");
Greet("Анна");

void PrintPerson(string name, int age, string city)
{
    Console.WriteLine($"Имя: {name} Возраст: {age} Город: {city}");
}

PrintPerson("Анна", 17, "Москва");
PrintPerson("Василий", 20, "Мурманск");

int Square(int x)
{
    return x * x;
}

Console.WriteLine(Square(25));

int Add(int a, int b)
{
    return a + b;
}

int Subtract(int a, int b)
{
    return a - b;
}

int Multiply(int a, int b)
{
    return a * b;
}

int Divide(int a, int b)
{
    return a / b;
}

Console.WriteLine("Введите 2 числа и операцию каждое на отдельной строке");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
string s = Console.ReadLine().ToString();


switch (s){
    case "+":
        Console.WriteLine(Add(a, b));
        break;
    case "-":
        Console.WriteLine(Subtract(a, b));
        break;
    case "*":
        Console.WriteLine(Multiply(a, b));
        break;
    case "/":
        Console.WriteLine(Divide(a, b));
        break;
    }



