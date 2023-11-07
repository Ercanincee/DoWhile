//Canavar Oyunu
int KarakterCan = 10;
int CanavarCan = 10;
do
{
    Random randomattack = new Random();
    int attack = randomattack.Next(1, 5);
    CanavarCan = CanavarCan - attack;
    Console.WriteLine("Saldırı Degeri:" + attack);
    Console.WriteLine("CanavarCan:" + CanavarCan);
    Console.WriteLine("KarakterCan:" + KarakterCan);
    if (CanavarCan > 0)
    {
        int saldiri = randomattack.Next(1, 5);
        KarakterCan = KarakterCan - saldiri;
        Console.WriteLine("Saldırı Degeri:" + saldiri);
        Console.WriteLine("Karakter Can:" + KarakterCan);
        Console.WriteLine("CanavarCan:" + CanavarCan);
    }
} while (KarakterCan > 0 && CanavarCan > 0);
if (KarakterCan > 0) { Console.WriteLine("Karakter Kazandı"); }
if (CanavarCan > 0) { Console.WriteLine("CanavarKazandı"); }