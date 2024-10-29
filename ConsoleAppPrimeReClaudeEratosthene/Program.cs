namespace ConsoleAppPrimeReClaudeEratosthene
{
  internal class Program
  {
    static void Main()
    {
      Console.WriteLine("calcul des nombres premiers avec le crible d'Ératosthène");
      var result = TrouverNombresPremiers(20_000_000);
      var displayResult = string.Join(" ", result);
      Console.WriteLine(displayResult);
      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }

    public static List<int> TrouverNombresPremiers(int limite)
    {
      // Liste pour stocker les nombres premiers
      List<int> nombresPremiers = new();

      // Tableau de booléens pour le crible d'Ératosthène
      bool[] estComposite = new bool[limite + 1];

      // 0 et 1 ne sont pas premiers
      estComposite[0] = estComposite[1] = true;

      // Implémentation du crible d'Ératosthène
      for (int i = 2; i * i <= limite; i++)
      {
        if (!estComposite[i])
        {
          // Marquer tous les multiples comme composites
          for (int j = i * i; j <= limite; j += i)
          {
            estComposite[j] = true;
          }
        }
      }

      // Collecter tous les nombres premiers
      for (int i = 2; i <= limite; i++)
      {
        if (!estComposite[i])
        {
          nombresPremiers.Add(i);
        }
      }

      return nombresPremiers;
    }
  }
}
