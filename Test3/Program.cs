int[] createArray()
{
    int[] ints = new int[8];
    Random ran = new Random();
    for(int i = 0; i < ints.Length; i++)
    {
        ints[i] = ran.Next();
    } return ints;
}
string getArrayAsString(int[] array)
{
    string result = " ";
    for (int i = 0; i < array.Length; i++)
    {
        result+=$"{array[i].ToString()}, ";
    } return result;
}
System.Console.WriteLine(getArrayAsString(createArray()));