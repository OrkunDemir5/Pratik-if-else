int result; //Dönüşüm başarısız olduğunda varsayılan değer

Console.WriteLine("Lütfen bir sayi giriniz");
string numb = Console.ReadLine();

//int.TryParse(numb, out result);

//sayının tek mi çift mi olduğunu ve int'e dönüşüyor mu kontrol et
if (int.TryParse(numb, out result) && result % 2 == 0)
{
    if (result == 10)
    {
        Console.WriteLine("Sayi 10'a eşittir");
    }
    else if (result < 10)
    {
        Console.WriteLine("Sayi 10'dan küçüktür");
    }
    else if (result > 10)
    {
        Console.WriteLine("Sayi 10'dan büyüktür");
    }
    Console.WriteLine("Sayi çifttir");
}else if (int.TryParse(numb, out result) && result % 2 != 0)
{
    if (result == 10)
    {
        Console.WriteLine("Sayi 10'a eşittir");
    }
    else if (result < 10)
    {
        Console.WriteLine("Sayi 10'dan küçüktür");
    }
    else if (result > 10)
    {
        Console.WriteLine("Sayi 10'dan büyüktür");
    }
    Console.WriteLine("Sayi tektir");
}
else
{
    Console.WriteLine("Hatalı sayı girdiniz");
}

