using System;
namespace ЛР_5
{
internal class Program
{
static void Main()
{
Console.OutputEncoding = UTF8Encoding.UTF8;
char[] word1 = Console.ReadLine().ToCharArray();//Зчитуємо слова та оразу конвертуємо їх в буквенний масив
char[] word2 = Console.ReadLine().ToCharArray();
if (BezPovtoru(word1, word2) == true) { Console.WriteLine("Друге слово можна утворити з букв першого не повторюючи їх."); }
else if (ZPovtorom(word1, word2) == true) { Console.WriteLine("Друге слово можна утворити з букв першого повторюючи їх."); }
else { Console.WriteLine("Друге слово не можливо утворити з літер першого."); }
}
static bool ZPovtorom(char[] word1, char[] word2)
{
bool BukvaIe = false;
for (int o = 0; o < word2.Length; o++)
{
BukvaIe = false;
for (int i = 0; i < word1.Length; i++)
{
if (word2[o] == word1[i]) { BukvaIe = true; }//Якщо буква другого слова є в першому, то BukvaIe=true
}
if (BukvaIe == false) { break; }//Якщо не має, то далі перевіряти немає сенсу
}
return BukvaIe;
}
static bool BezPovtoru(char[] word1, char[] word2)
{
int character = 0;
bool BezPovtoru = false;
char[] word_check = new char[word2.Length];
Array.Copy(word2, word_check, word2.Length);//копіюємо друге слово щоб не змінювати оригінал
for (int i = 0; i < word1.Length; i++)
{ //Індекс букв першого слова
for (int o = 0; o < word2.Length; o++)
{//Індекс букв другого слова
if (word1[i] == word_check[o])
{//якщо буква першого слова = якійсь з букв другого слова
character++;//То кількість однакових символів++
word_check[o] = '_';//І замінюємо цю букву другого слова на якийсь символ, щоб воно потім не зарахувало його ще раз
break;//Зупиняємо пошук для букви
}
}
}
if (character == word2.Length)
{
BezPovtoru = true;
}
return BezPovtoru;
}
}
}
