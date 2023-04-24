using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

//Руда ФІТ 1-4

namespace ЛР_6

{

internal class Program

{

[Flags]//Список предметів для бакалавру

enum Bakalavr

{

Основи_пограмування = 0b00000001,

Обєктноорієнтоване_програмування = 0b00000010,

Операційні_системи = 0b00000011,

Технологія_Java = 0b00000100

}

[Flags]//Список предметів для магустрів

enum Magistr

{

Функціональне_та_логічне_програмування = 0b00000101,

VRтехнології_та_3D_моделювання = 0b00000110,

Технології_проєктування_інформаційних_систем = 0b00000111,

Хмарні_та_Grid_технології = 0b00001000

}

static void Main(string[] args)

{

Console.OutputEncoding = UTF8Encoding.UTF8;

Console.WriteLine("Баакалавр:\n1. " + (Bakalavr)1 + "\n2. " + (Bakalavr)2 + "\n3. " + (Bakalavr)3 + "\n4. " + (Bakalavr)4 + "\nМагістр:\n5. " + (Magistr)5 + "\n6. " + (Magistr)6 + "\n7. " + (Magistr)7 + "\n8. " + (Magistr)8);

Console.WriteLine("Оберіть дисципліни, вводячи їх номер через кому:");

string text = Console.ReadLine();

string[] numbers = text.Split(',');//Введені числа поміщає в масив(числа розділені ',')

Console.WriteLine("\nАвтор програми - Руда" + "\nВи обрали такі предмети:");

Console.WriteLine("\nБакалавр:");

for (int i = 0; i <numbers.Length; i++) {

int n = int.Parse(numbers[i]);

if (n<5)

Console.WriteLine(n + ". " + ((Bakalavr)n));

}

Console.WriteLine("Магістр:");

for (int i = 0; i < numbers.Length; i++)

{

int n = int.Parse(numbers[i]);

if (n > 5)

Console.WriteLine(n+". " + ((Magistr)n));

}

}

}

}
