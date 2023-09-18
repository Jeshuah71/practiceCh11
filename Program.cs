//Loops
Console.WriteLine("First loop num 1 to 10");
int x = 1;
while (x <= 10)
{
    Console.WriteLine(x);
    x++;
}

Console.WriteLine("Second loop num 1 to 20");
int y =1;
while (y <= 20)
{
    Console.WriteLine(y);
    y++;
}
// Loop Asking a user to enter a number between 1 to 10
int playerNum = -1;
while (playerNum < 0 || playerNum >10)
{
    Console.WriteLine("Enter a number between 0 and 10 ");
    
    playerNum = Convert.ToInt32(Console.ReadLine());
    
}
// Do/ while Loop
int player1Number;
do
{
    Console.WriteLine("Enter a number between 0 and 20");
    player1Number = Convert.ToInt32(Console.ReadLine());

}
while (player1Number < 0 || player1Number >20);

int player2Number;
do
{
    Console.WriteLine("Enter a number between 0 and 30 ");
    player2Number = Convert.ToInt32(Console.ReadLine());
}
while (player2Number < 0 || player2Number > 30);

// for loop
for (int z = 1; z <=10; z++)
{
    Console.WriteLine(z);
}
for (int a = 100; a <= 200; a++)
{
    Console.WriteLine(a);
}

// Break out of loops

while (true)
{
    Console.WriteLine("Think of a number and type it here: ");
    string input = Console.ReadLine();

    if(input == "quit" || input == "exit")
    break;
    int number = Convert.ToInt32(input);

    if (number == 12)
    {
        Console.WriteLine("I don't like that number, pick another one ");
        continue;
    }
    Console.WriteLine($"I like that {number}. It is the one before {number + 1 }!");
    break;
}
//Nesting loops 
for (int b = 1; b <= 5 ; b++ )
    for (int c = 1 ; c <= 5 ; c ++)
        Console.WriteLine($"{b} * {c} = {b * c}");

for (int d = 1; d <= 10; d++)
    for (int e = 1 ; e <= 10; e++)
    Console.WriteLine($"{d} + {e} = {d + e}");

// number of * based of the number of rows and columns
int totalRows = 5;
int totalColumns = 10; 
for (int currentRow = 1; currentRow <= totalRows; currentRow++)
{
    for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
    Console.Write("*");
    Console.WriteLine();
}
int totalRows1 = 10;
int totalColumns1 = 20; 
for (int currentRow1 = 1; currentRow1 <= totalRows1; currentRow1++)
{
    for (int currentColumn1 = 1; currentColumn1 <= totalColumns1; currentColumn1++)
    Console.Write("+");
    Console.WriteLine(" Hi, Have a good night ");
}
