using System.ComponentModel.Design;

string pas = "1234";
string i = Console.ReadLine().ToString();

if(i == pas)
{
    Console.WriteLine("Доступ разрешен");
}
else
{
    Console.WriteLine("Доступ запрещён");
    for(int k=1; k<=3; k++)
    {
        i = Console.ReadLine().ToString();
        if (i == pas)
        {
            Console.WriteLine("Доступ разрешен");
            break;
        }
        else
        {
            Console.WriteLine("Доступ запрещён");
        }
    }
}