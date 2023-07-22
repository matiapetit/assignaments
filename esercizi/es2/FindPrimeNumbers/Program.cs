using System;

class Program {
    static void Main(string[] args) {
        int n;
        string input;
        
        Console.WriteLine("Enter a positive integer n: ");
        
        input = Console.ReadLine();

        if (int.TryParse(input, out n)) {

            List<int> primeNumbers;
            GetPrimeNumbers(n, out primeNumbers);

            if (primeNumbers.Count > 0) {
                PrintResult(primeNumbers, n);
            }

        } else {
            Console.WriteLine("Error! You have to enter a positive integer");
        }
    }

    private static void GetPrimeNumbers(int n, out List<int> result) {
        result = new List<int>();
        
        for (int i = 0; i <= n; i++) {
            if (IsPrime(i)) {
                result.Add(i);
            }
            
        }
    }

    private static bool IsPrime(int num) {
        {
            if (num < 2) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++) {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }

    private static void PrintResult(List<int> result, int n) {
        string output = string.Empty;
        Console.WriteLine("Prime numbers less than or equal to " + n + ": " + string.Join(", ", result));
    }
}

