/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел/
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

Console.WriteLine("Enter the Number"); 
int Number = Convert.ToInt32(Console.ReadLine());
int Squares = 1;
while (Squares <= Number)
{
    Console.WriteLine(Squares * Squares + "");
    Squares++;
}
