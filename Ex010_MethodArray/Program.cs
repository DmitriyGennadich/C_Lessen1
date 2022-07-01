int[] array = { 1, 12, 23, 27, 15, 16, 27, 68 };
 int n = array.Length;
 int find = 27;
 int index = 0;
 while(index < n)
 {

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
 }
