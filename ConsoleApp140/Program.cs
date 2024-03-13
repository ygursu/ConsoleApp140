do
{

} while (oku != (char)ConsoleKey.Escape);
char oku;
do
{
    Console.Clear();
    Console.Write("Sayı giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    sayi = Math.Abs(sayi);



} while (oku != (char)ConsoleKey.Escape);
while (sayi >= 1)
{
 
    sayi /= 10;
    basamak++;
}