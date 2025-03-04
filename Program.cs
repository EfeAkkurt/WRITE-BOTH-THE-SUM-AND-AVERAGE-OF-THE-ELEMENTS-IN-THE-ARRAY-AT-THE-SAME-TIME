int[] numbers = [5, 25, 12, 28, 2, 36, 45, 99, 12, 3]; // Sayılar dizisi
int total = 0; // Toplamı tutacak değişken
int average = 0; // Ortalamayı tutacak değişken

for (int start = 0; start < numbers.Length; start++) // Diziyi döngüyle geziyor
{
    total += numbers[start]; // Her sayıyı toplama ekliyor
    average += numbers[start]; // Her sayıyı ortalama için topluyor
}

Console.WriteLine($"total : {total}  average : {average / numbers.Length}"); // Sonuçları yazdırıyor