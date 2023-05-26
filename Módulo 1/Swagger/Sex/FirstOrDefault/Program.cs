List<int> numeros = new List<int>{1,2,3,4,5};

int primeiroNumero = numeros.FirstOrDefault(n => n > 3);
Console.WriteLine(primeiroNumero);
