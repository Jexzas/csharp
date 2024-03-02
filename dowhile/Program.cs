// Create a new instance of the Random class
Random random = new Random();
int current = 0;

do {
    // Creates a new random number between 1 and 11
    current = random.Next(1, 11);

    if (current >= 8) continue;
    Console.WriteLine(current);
} while (current != 7);

// program stops if random number is seven

// Same program but with greater/less than
int cur2 = 0;

do {
    cur2 = random.Next(1, 233);
    Console.WriteLine(cur2);
} while (cur2 <= 150);