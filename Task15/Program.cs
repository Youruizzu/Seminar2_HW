Console.Clear();

int day = new Random().Next(1,8);

Console.WriteLine($"День недели: {day}");

if (day == 6 || day == 7){
    Console.WriteLine($"{day} -> выходной");
}
else { Console.WriteLine($"{day} -> не выходной");}