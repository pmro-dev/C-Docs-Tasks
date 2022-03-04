
Console.WriteLine("Hello, World!\n");


/*Console.WriteLine("Work with Data | First Challenge\n");

string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine(pangram);

string[] splitedPangramToStrings = pangram.Split(" ");
string[] reversedPangram = new string[splitedPangramToStrings.Length];
int i = 0;

foreach (string word in splitedPangramToStrings)
{
    char[] splitedWordToChar = word.ToCharArray();

    Array.Reverse(splitedWordToChar);

    string newWord = String.Join("", splitedWordToChar);

    Console.WriteLine(newWord);

    reversedPangram[i] = newWord;
    i++;
}

string newPangram = String.Join(" ", reversedPangram);
Console.WriteLine(newPangram);*/



Console.WriteLine("Work with Data | Second Challenge\n");

/*

Our job is to write new code that will output the Order ID 
of new orders where the Order ID starts with the letter "B". 
This will be used by our fraud team to investigate further.

Using the code below as a starting point, you'll need to parse Order IDs 
out of a string containing a sequence of incoming orders (the orderStream). 
Then, you'll print each Order ID that starts with the letter "B".


*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

Console.WriteLine(orderStream);

string[] arrayStream = orderStream.Split(',');

string[] rightStream = new string[arrayStream.Length]; ;
int i = 0;

foreach (string id in arrayStream)
{
    if (id.Contains("B"))
    {
        rightStream[i] = id;
        i++;
    }


    /*
      
    if(id.StartsWith("B"))
    {
        Console.WriteLine(item);
    }    
        
     */
}

foreach (string id in rightStream)
{
    Console.WriteLine(id);
}