int[] l = { 1, 5, 7, 12, 5 };

foreach (int i in l)
{
    Console.Write(i + " ");
}
Console.WriteLine();
foreach (int i in l.Reverse())
{
    Console.Write(i + " ");
}