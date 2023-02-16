Console.Clear();

int num = new Random().Next(1, 1000000);
Console.WriteLine($"Изначальное число: {num}");
int count = 0;
int countAssist = num;
int third = num;

while (countAssist > 0){
    countAssist /= 10;
    count++;
}

Console.WriteLine($"Длина числа: {count} цифр");

if (count >= 3) {
    while (count > 3){
        third /= 10;
        count--;
    }
    third %= 10;
    Console.WriteLine($"{num} -> третья цифра = {third}");
}
else { Console.WriteLine($"{num} -> третьей цифры нет");}
