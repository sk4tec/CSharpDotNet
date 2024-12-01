// See https://aka.ms/new-console-template for more information

/* In some role playing games, the player's character battles non-player characters, 
 * which are usually monsters or the "bad guys". Sometimes, a battle consists of each character generating a 
 * random value using dice and that value is subtracted from the opponent's health score. Once either 
 * character's health reaches zero, they lose the game.

 * In this challenge, we boil down that interaction to its essence. 
 * A hero and a monster start with the same health score. 
 * During the hero's turn, they generate a random value that is subtracted from the monster's health. 
 * If the monster's health is greater than zero, they take their turn and attack the hero.
 * As long as both the hero and the monster have health greater than zero, the battle resumes.
 */

/*
 * Monster was damaged and lost 1 health and now has 9 health.
 * Hero was damaged and lost 1 health and now has 9 health.
 * Monster was damaged and lost 7 health and now has 2 health.
 * Hero was damaged and lost 6 health and now has 3 health.
 * Monster was damaged and lost 9 health and now has -7 health.
 * Hero wins!
 */

Console.WriteLine("Battle Game!");

int heroHealth = 10;
int monsterHealth = 10;

var attack = new Random();

while (heroHealth > 0 && monsterHealth > 0) {
    int hit = attack.Next(1, 11);
    monsterHealth -= hit; // hero attacks
    
    Console.WriteLine($"Monster was damaged and lost {hit} health and now has {monsterHealth} health");

    if (monsterHealth > 0 ) {
        hit = attack.Next(1, 11);
        heroHealth -= hit; // monster attacks next
        
        Console.WriteLine($"Hero was damaged and lost {hit} health and now has {heroHealth} health");
    }
}

if (heroHealth == 0) {
    Console.WriteLine("Monster Wins!");
} else {
    Console.WriteLine("Hero Wins!");
}
