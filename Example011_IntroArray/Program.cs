
/*
// Индексы:    0   1   2   3   4  .... 
int[] array = {11, 21, 31, 41, 51, 61, 71, 81, 91};
array[0] = 12; //Так можно записать новое значение элемента массива
Console.WriteLine(array[0]);// Выводим новое значение
*/

//Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

/*
int[] array = { 1, 2, 8, 4, 5, 6, 7, 8 };

int n = array.Length;
int find = 8;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //Прерывает цикл, если искомый элемент уже найден
    }
    index++; //index = index + 1
}
*/

//Метод заполнения массива рандомными числами и его печати на экран

/*
void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// Следующий метод IndexOf будет искать среди рандомного массива число find и выводить его индекс

int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Для того чтобы при отсутствии нужного элемента выводился не 0, а -1, и мы точно знали, что такого элемента в массиве нет

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10]; //Создаётся новый массив из 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos  = IndexOf(array, 4);
Console.WriteLine(pos);
*/


