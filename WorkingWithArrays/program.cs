static void Main(string[] args)
{
    string message = "Hello World";
    // string is an array of characters
    for (int i = 0; i < message.Length; i++)
    {
        if (i > 6 && i < 12)
        {
            Console.WriteLine(message[i]);
        }

    }


}