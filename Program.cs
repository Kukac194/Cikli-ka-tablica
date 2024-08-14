internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int brojRedova;
            int brojStupaca;

            // Unos broja redova i stupaca
            Console.WriteLine("Unesi broj redova: ");
            brojRedova = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi broj stupaca: ");
            brojStupaca = int.Parse(Console.ReadLine());

            int lijevo = 0;
            int gore = 0;
            int desno = brojStupaca - 1;
            int dole = brojRedova - 1;

            int dimenzije = brojRedova * brojStupaca;
            int broj = 1;

            // Inicijalizacija matrice
            int[][] matrix = new int[brojRedova][];
            for (int i = 0; i < brojRedova; i++)
            {
                matrix[i] = new int[brojStupaca];
            }

            // Popunjavanje matrice
            while (broj <= dimenzije)
            {
                // Popunjavanje s lijeva na desno
                for (int i = lijevo; i <= desno && broj <= dimenzije; i++)
                {
                    matrix[gore][i] = broj++;
                }
                gore++;

                // Popunjavanje s gore na dole
                for (int i = gore; i <= dole && broj <= dimenzije; i++)
                {
                    matrix[i][desno] = broj++;
                }
                desno--;

                // Popunjavanje s desna na lijevo
                for (int i = desno; i >= lijevo && broj <= dimenzije; i--)
                {
                    matrix[dole][i] = broj++;
                }
                dole--;

                // Popunjavanje s dolje na gore
                for (int i = dole; i >= gore && broj <= dimenzije; i--)
                {
                    matrix[i][lijevo] = broj++;
                }
                lijevo++;
            }

            // Ispis matrice
            for (int i = 0; i < brojRedova; i++)
            {
                for (int j = 0; j < brojStupaca; j++)
                {
                    Console.Write(matrix[i][j].ToString().PadLeft(2));
                }
                Console.WriteLine();
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.ToString());
        }
    }
}
