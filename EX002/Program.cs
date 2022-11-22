/*
18 Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

int QuarterNumber = new Random().Next(1, 5);
string Quarter = "";

    if (QuarterNumber == 1) 
  {
    Quarter = "x > 0, y > 0";
  }
    else if (QuarterNumber == 2) 
  {   
    Quarter = "x < 0, y > 0";
  }
    else if (QuarterNumber == 3) 
  {
    Quarter = "x < 0, y < 0";
  }

 else if (QuarterNumber == 4)
  {
    Quarter = "x > 0, y < 0";
  }
if (QuarterNumber > 4) 
  {
    Console.WriteLine($"Для {QuarterNumber}-й четверти нет коодинат точек");
  }
else
  {
    Console.WriteLine($"Для {QuarterNumber}-й четверти координаты точки должны быть заданы в диапазоне ( {Quarter} )");
    Console.WriteLine();
  }