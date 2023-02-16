Console.Clear();

int num = new Random().Next(100,1000);
Console.WriteLine(num);

int secnum = (num/10)%10;

Console.WriteLine($"Вторая цифра в числе {num} -> {secnum}");