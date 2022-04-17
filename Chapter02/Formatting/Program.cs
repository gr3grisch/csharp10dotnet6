using static System.Console;

const int numberOfApples = 12;
const decimal pricePerApple = 0.35M;
WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
var formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
//WriteToFile(formatted); // writes the string into a file

WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

const string firstname = "Omar";
const string lastname = "Rudberg";
const string fullname = $"{firstname} {lastname}";
WriteLine($"{fullname}");

const string applesText = "Apples";
const int applesCount = 1234;
const string bananasText = "Bananas";
const int bananasCount = 56789;
WriteLine(
    format: "{0,-10} {1,6}",
    arg0: "Name",
    arg1: "Count");
WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);
WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount);

Write("Type your first name and press ENTER: ");
string? firstName = ReadLine();
Write("Type your age and press ENTER: ");
string? age = ReadLine();
WriteLine(
    $"Hello {firstName}, you look good for {age}.");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers);