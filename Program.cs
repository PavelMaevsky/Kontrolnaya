string[] MyArray = { "new", "strong", "man", "412", "red", "stell" };

string[] MyArray1 = new string[MyArray.Length];

int maxLength = 3;

void CutArray(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= maxLength)
            {
                array2[count] = array1[i];
                count++;
            }
        }
    }
void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($" {array[i]} ");
        }
        Console.WriteLine();
    }
CutArray(MyArray, MyArray1);
Console.Write("Дан массив строк: ");
PrintArray(MyArray);
Console.Write("Массив строк <= 3 символам:  ");
PrintArray(MyArray1);