Random dice = new Random();

int roll1 = dice.Next(1,6);
int roll2 = dice.Next(1,6);
int roll3 = dice.Next(1,6);

int all = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {all}");

if ((roll1==roll2) || (roll2==roll3) || (roll1==roll3)) {

    if ((roll1 ==roll2) && (roll2==roll3)){
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        all += 6;
        Console.WriteLine($"Now you have {all} points!");
    }
    else {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        all += 2;
        Console.WriteLine($"Now you have {all} points!");
    }   
}

if (all >= 16){
    Console.WriteLine("You win a new car!");
}

else if (all >= 10){
    Console.WriteLine("You win a new laptop!");
}

else if (all >= 7){
    Console.WriteLine("You win a trip for two!");
}

else {
    Console.WriteLine("You win a kitten!");
}

if (all >= 15) {
    Console.WriteLine("You win the game!");
}

else{
    Console.WriteLine("But you still lost the game!");
}