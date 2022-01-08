﻿
FindNumber();

void FindNumber()
{
    List<int> numbers = new List<int>(9);
    int count = 0;

    while (true)
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 10);
        count++;

        if (!numbers.Any(f => f == number))
        {
            numbers.Add(number);

            if (numbers.Count() == 9)
            {
                break;
            }
        }
    }

    Console.WriteLine(string.Join(",", numbers) + " Random fonksiyonu " + count + " kere çalışmıştır.");
}




//9 büyüklüğündeki bir listeyi 1 den 9 a kadar tekrar etmeyecek şekilde random olarak dolduran ve
//kaç kere random kodunun çağrıldığını output a yazan kod. Bu sorunun cevabında
//beklenen; random fonksiyonun minimum seviyede çağırılmasıdır. Random fonksiyonun çağırım
//adedine göre puanlama yapılacaktır.
//Varsayımlar ve kurallar:
//•İndise eklenen bir rakam tekrar edemez.
//•Eklenecek rakam hardcode olarak eklenemez.
//Örnek 1:
//5,2,3,8,1,4,6,9,7 Random fonksiyonu 24 kere çalışmıştır.
//Örnek 2:
//4,1,3,2,7,9,5,6,8 Random fonksiyonu 86 kere çalışmıştır.