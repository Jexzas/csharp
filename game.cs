Random damage = new Random();
int playerHP = 10;
int enemyHP = 10;
int turnCounter = 1;

while (playerHP > 0 && enemyHP > 0) {
    int heroDmg = damage.Next(0,11);
    Console.WriteLine($"Turn {turnCounter}:");
    Console.WriteLine($"Hero attacks for {heroDmg} damage!");
    enemyHP -= heroDmg;
    if (enemyHP < 0) {
        enemyHP = 0;
    }
    Console.WriteLine($"Enemy has {enemyHP} left.");
    if (enemyHP < 1) {
        Console.WriteLine("Enemy defeated!");
        break;
    }
    int enemyDmg = damage.Next(0,11);
    Console.WriteLine($"Enemy attacks for {enemyDmg} damage!");
    playerHP -= enemyDmg;
    if (playerHP < 0) {
        enemyHP = 0;
    }
    Console.WriteLine($"Hero has {playerHP} left!");
    if (playerHP < 1) {
        Console.WriteLine("Hero defeated! RIP");
    }
    turnCounter++;
}