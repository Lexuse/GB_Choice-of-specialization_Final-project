//программа  из имеющегося массива строк формирует новый массив из строк, длина которых  равна 3 символам.
Console.Clear();

string[] array = GenerateArray();
string[] array2 = new string[array.Length];
CutArrayTo3(array, array2);
PrintArray(array2);




//###########################################################
string[] GenerateArray()
{
    string[] arr = new String[20] { "box", "seven", "-3", "step", "apple", "arc", "78", "3p", "ele", "orks", "bamb", "32", "-z", "porit", "rabbit", "cha", "stock", "2112", "-tjooos", "zoo" };
    return arr;
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void CutArrayTo3(string[] arr, string[] arr2)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }

}

