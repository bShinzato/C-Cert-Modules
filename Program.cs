// *****C# arrays

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "HAHA";

// Console.WriteLine($"Reassigned First: {fraudulentOrderIDs[0]}");

// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "Reassigned Value";

// Console.WriteLine($"Reassigned First: {fraudulentOrderIDs[0]}");

// Note: The Length property of an array is not zero-based.

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");





// *****C# Foreach Looping -- Iteration

// string[] names = { "Brandon", "Adam", "Lina" };
// foreach (string name in names)
// {
//   Console.WriteLine(name);
// }

// int[] inventory = { 100, 150, 200, 250, 300, 350, 400 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//   sum += items;
//   bin++;
//   Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");


// Challenge -- Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.

// string[] fraudulentOrderIDs = { "b123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
// foreach (string items in fraudulentOrderIDs)
// {
//   if (items.StartsWith("B"))
//   {
//     Console.WriteLine(items);
//   }
// }


/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//   int prefixValue = random.Next(65, 70);
//   string prefix = Convert.ToChar(prefixValue).ToString();
//   string suffix = random.Next(1, 1000).ToString("000");

//   orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//   Console.WriteLine(orderID);
// }

// Random dice = new Random();
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//   if ((roll1 == roll2) && (roll2 == roll3))
//   {
//     Console.WriteLine("You rolled triples!  +6 bonus to total!");
//     total += 6;
//   }
//   else
//   {
//     Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//     total += 2;
//   }
// }

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
  if (letter == 'o')
  {
    letterCount++;
  }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");