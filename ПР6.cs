using System;
using System.Text;
using System.IO;
namespace ЛР_7
{
internal class Program
{
static void Main(string[] args)
{
Console.OutputEncoding = UTF8Encoding.UTF8;
Console.WriteLine("Введіть текст для запису у перший файл:");//Перезапис даних у другий файл
string text = Console.ReadLine();
using (StreamWriter writer = new StreamWriter("D:\\Урочки\\Основи програмування\\ЛР 7\\Num_1.txt"))
{
writer.Write(text);
}
Console.WriteLine("Введіть текст для запису у другий файл:");//Перезапис данних у перший файл
string text2 = Console.ReadLine();
using (StreamWriter writer = new StreamWriter("D:\\Урочки\\Основи програмування\\ЛР 7\\Num_2.txt"))
{
writer.Write(text2);
}

//Зчитуємо слова з файлів та розділяємо їх
string[] file1Words = File.ReadAllText("D:\\Урочки\\Основи програмування\\ЛР 7\\Num_1.txt").Split(' ');
string[] file2Words = File.ReadAllText("D:\\Урочки\\Основи програмування\\ЛР 7\\Num_2.txt").Split(' ');

//Порівнюємо слова та виводимо їх
Console.WriteLine("Спільні елементи: ");
for (int i = 0; i < file1Words.Length; i++){
for (int o = 0; o < file2Words.Length; o++){
if (file1Words[i] == file2Words[o])
{
Console.Write(" " + file1Words[i]);
}
}
}
Console.WriteLine("");
}
}
}
