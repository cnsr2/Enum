class Prgoram
{
    static void Main(string[] args)
    {
        Console.WriteLine(Günler.cuma);
        Console.WriteLine((int)Günler.cumartesi);
        int sıcaklık = 4;
        if(sıcaklık < (int)HavaDurumu.normal)
        Console.WriteLine("dışarıya çıkmak için biraz daha havanın ısınmasını beklemelisin");
        else if(sıcaklık >= (int)HavaDurumu.sıcak && sıcaklık <= (int)HavaDurumu.cokSıcak)
        Console.WriteLine("dışarıya çıkmak için hava yeterince sıcak");
        else if(sıcaklık < (int)HavaDurumu.soğuk)
        Console.WriteLine("dışarıya çıkmak için hava çok soğuk");
    }
} 
enum Günler
{
    pazartesi = 1,
    salı,
    çarşamba,
    perşembe,
    cuma,
    cumartesi,
    pazar
}
enum HavaDurumu
{
    soğuk = 5,
    normal = 20,
    sıcak = 25,
    cokSıcak = 30
}