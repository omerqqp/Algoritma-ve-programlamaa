namespace dizi__ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir doğal sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[n, n];
            Random rnd = new Random();
            int asalköşegenToplam = 0;
            int yardımcıköşegençarpım = 1;
            int negatifSayiAdedi = 0;
            int ençoktekrarEdenSayi = 0;
            Console.WriteLine("oluşturulan matris: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matris[i, j] = rnd.Next(-9, 10);
                    Console.Write(matris[i, j] + "  ");
                    if (i == j)
                    {
                        asalköşegenToplam += matris[i, j];
                    }
                    if (matris[i, j] < 0)
                    {
                        negatifSayiAdedi++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int k = -9; k <= 9; k++)
            {
                int sayac = 0;
                for (int l = 0; l < n; l++)
                {
                    for (int m = 0; m < n; m++)
                    {
                        if (matris[l, m] == k)
                        {
                            sayac++;
                        }
                    }
                }
                if (sayac > ençoktekrarEdenSayi)
                {
                    ençoktekrarEdenSayi = k;
                }
            }
            int toplamasal = 0;
            int sayacasal = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int sayi = matris[i, j];
                    bool asal = true;
                    if (sayi < 2)
                    {
                        asal = false;
                    }
                    else
                    {
                        for (int k = 2; k <= Math.Sqrt(sayi); k++)
                        {
                            if (sayi % k == 0)
                            {
                                asal = false;
                                break;
                            }
                        }
                    }
                    if (asal)
                    {
                        toplamasal += sayi;
                        sayacasal++;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                yardımcıköşegençarpım *= matris[i, n - i - 1];
            }
            Console.WriteLine("ana köşegen toplamı: " + asalköşegenToplam);
            Console.WriteLine("yardımcı köşegen çarpımı: " + yardımcıköşegençarpım);
            Console.WriteLine("negatif sayı adedi: " + negatifSayiAdedi);
            Console.WriteLine("en sık tekrar eden sayı: " + ençoktekrarEdenSayi);
            Console.WriteLine("asal sayıların ortalaması: " + toplamasal / sayacasal);
            Console.WriteLine();
            Console.WriteLine("saat yönünde 90' döndürülmüş hali: ");
            for (int t = 0; t < n; t++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matris[n - j - 1, t] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
