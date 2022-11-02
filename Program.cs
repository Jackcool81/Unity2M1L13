using System;

class Project1Template{    
    //Create variables here
    static string[] enemyActions = new string[]{"Heal", "Punched"};
    static int maxEnemyHP = 30;
    static int currEnemyHP = 30;
    static int currPlayerHP = 45;
    static int maxPlayerHP = 45;

    static bool running;


    //TODO Part 1 While Loop
    public static void Main() {
        Console.WriteLine("Welcome to the fight club!");
        
    }

    //TODO Part 2 Commands Method

    //TODO Part 3 Player Method
    public static void player(){
        int num = 0;
        int amount = 0;
        string userinput = "";
        Console.WriteLine("Its your turn Input a number to Attack!");
        //The student will have to make some of the plaer functions

        if (userinput == "1") {
           
        }
        else if (userinput == "2") {
            
            
        }
        else if (userinput == "3") {
            
        }
        Console.WriteLine('\n');

    }

    
    public static string input(){
        string input = Console.ReadLine();
        return input;
    }

    public static void enemyTurn(){
        int num = 0;
        int amount = 0;
        int x = Random.Range(1,2);
        if (x == 1){
            //Enemy Heal
            amount = Random.Range(1,4);
            int heal = amount + currEnemyHP;
            if (heal >= maxEnemyHP) {
                currEnemyHP = maxEnemyHP;
            }
            else {
                currEnemyHP = heal;
            }
            num = 0;
        }
        else {
            //Enemy Damage
            amount = Random.Range(1,4);
            num = 1;
            int dmg = currPlayerHP - amount;
            if (dmg <= 0) {
                Console.WriteLine("You Have Been Defeated");                
                running = false;
                return;
            }
            else {
                currPlayerHP = dmg;
            }
        }
        Console.WriteLine('\n');
        Console.WriteLine("Enemy " + enemyActions[num] + " for " + amount.ToString());
        Console.WriteLine('\n');      
    }
}