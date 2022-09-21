string[] array1 = new string[5] {"wefwefw", "wceec", "cefef", "87", "xd"};
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
if (array1[i].Length <= 3)
    {
       count++;
    }
    Console.WriteLine();
}
 Console.WriteLine("Число элементов массива содержащие в себе 3 и менее символов = "+count);
 
 string[] array2 = new string[count];
 int j = 0;
 for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
        {
        array2[j]=array1[i];
        Console.WriteLine(array2[j]);
        j++;
        }
}