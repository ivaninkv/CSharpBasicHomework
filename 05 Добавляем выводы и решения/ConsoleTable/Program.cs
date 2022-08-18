using System.Text;

const char symbol = '+';

var indent = GetIndent();
var userText = GetUserText();
var tableWidth = indent * 2 + userText.Length;
var rowBorder = new StringBuilder().Append(symbol, tableWidth);
Console.WriteLine(rowBorder);
PrintFirstRow(indent, userText);
Console.WriteLine(rowBorder);
PrintSecondRow(indent, userText);
Console.WriteLine(rowBorder);
PrintThirdRow(tableWidth);
Console.WriteLine(rowBorder);

static int GetIndent()
{
    int num;
    do
    {
        Console.Write("Введите размерность таблицы: ");
        var str = Console.ReadLine();
        int.TryParse(str, out num);
    } while (num < 1 || num > 6);

    return num;
}

static string GetUserText()
{
    string str;
    do
    {
        Console.Write("Введите произвольный текст: ");
        str = Console.ReadLine();
    } while (string.IsNullOrEmpty(str));

    return str;
}

static void PrintFirstRow(int indent, string userText)
{
    var tableWidth = indent * 2 + userText.Length;
    var rows = indent * 2 - 1;
    for (var i = 1; i <= rows; i++)
        if (i != indent)
            Console.WriteLine(symbol.ToString() +
                              new StringBuilder().Append(' ', tableWidth - 2) +
                              symbol);
        else
            Console.WriteLine(symbol.ToString() +
                              new StringBuilder().Append(' ', (tableWidth - userText.Length - 2) / 2) +
                              userText +
                              new StringBuilder().Append(' ', (tableWidth - userText.Length - 2) / 2) +
                              symbol);
}

static void PrintSecondRow(int indent, string userText)
{
    var tableWidth = indent * 2 + userText.Length;
    var rows = indent * 2 - 1;
    var oddRow = new StringBuilder().Insert(0, " " + symbol, tableWidth / 2);
    var evenRow = new StringBuilder().Insert(0, symbol + " ", tableWidth / 2);
    for (var i = 1; i <= rows; i++) Console.WriteLine(i % 2 == 0 ? evenRow : oddRow);
}

static void PrintThirdRow(int tableSize)
{
    for (var i = 0; i < tableSize; i++)
    {
        for (var j = 0; j < tableSize; j++)
            Console.Write(i == j || i + j == tableSize - 1 ? symbol : ' ');
        Console.WriteLine();
    }
}