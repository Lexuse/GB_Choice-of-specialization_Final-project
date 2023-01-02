//программа  из имеющегося массива строк формирует новый массив из строк, длина которых  равна 3 символам.
Console.Clear();

string[] array = GenerateArray();
string[] array2 = new string[array.Length];
CutArrayTo3(array, array2);
PrintArray(array2);



