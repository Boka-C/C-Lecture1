int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index); // нашли число файнд (4/18), в массиве под номером 3 (нумерация с 0)
    }
    //index = index + 1; то же самое что и в слю строке
    index++; 

}