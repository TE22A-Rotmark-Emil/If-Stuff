bool isRight = false;
string playerAnswer;
int randomInteger = Random.Shared.Next(100) + 1;
int invalidGuesses = 0;
while (!isRight){
    Console.WriteLine("guess a number, 1-100");
    int playerInt;
    do{
        if (invalidGuesses > 0){
            Console.WriteLine("Ehh wrong you're wrong you didn't type a number dummy");
        }
        playerAnswer = Console.ReadLine();
        if (int.TryParse(playerAnswer, out playerInt)){
            invalidGuesses = 0;
        }
    } while(!int.TryParse(playerAnswer, out playerInt));
    if (playerInt == randomInteger){
        Console.WriteLine("Ding ding ding you are winner you are awesome I love you");
        isRight = true;
    }
    else{
        Console.WriteLine("You're WRONG and STINKY and I HATE YOU");
    }
}