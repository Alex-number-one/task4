int N = Convert.ToInt16(Console.ReadLine());
int m = 1;
if (N < 0)
{
    Console.WriteLine("Nothing");
}
while (m <= N)
{
    if ( m % 2 == 0)
 { 
    Console.WriteLine(m);
 }
    m++;
}