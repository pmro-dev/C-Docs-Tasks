
Console.WriteLine("Hello, World!\n");


/*
 
Console.WriteLine("Work with Data | #1 Challenge\n");

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
Console.WriteLine(newPangram);



Console.WriteLine("Work with Data | #2 Challenge\n");

/*

Our job is to write new code that will output the Order ID 
of new orders where the Order ID starts with the letter "B". 
This will be used by our fraud team to investigate further.

Using the code below as a starting point, you'll need to parse Order IDs 
out of a string containing a sequence of incoming orders (the orderStream). 
Then, you'll print each Order ID that starts with the letter "B".


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
        
}

foreach (string id in rightStream)
{
    Console.WriteLine(id);
}


string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols = { '[', '{', '(' };

Console.WriteLine("Work with Data | Modify the content | #3 Challenge UNIT 2 \n");

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

*/

Console.WriteLine("Work with Data | Modify the content | #4 Challenge UNIT 5 \n");

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
int startingPosition = input.IndexOf("<div>");
int closingPosition = input.IndexOf("</div>");
int divLength = String.Format("<div>").Length;
int lookingWordLength = closingPosition - (startingPosition + divLength);
output = input.Substring(startingPosition + divLength, lookingWordLength);
output = output.Replace("&trade", "&reg");

int spanLength = String.Format("<span>").Length;
int startingPositionSpan = input.IndexOf("<span>") + spanLength;
int closingPositionSpan = input.IndexOf("</span>");
int lookingWordLength2 = closingPositionSpan - startingPositionSpan;
quantity = input.Substring(startingPositionSpan, lookingWordLength2);

Console.WriteLine(quantity);
Console.WriteLine(output);
