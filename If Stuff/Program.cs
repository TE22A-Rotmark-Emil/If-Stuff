bool isRight = false;
string playerAnswer;
int maxInt = 100;
int randomInteger = Random.Shared.Next(maxInt) + 1;
int invalidGuesses = 0;
while (!isRight){
    Console.WriteLine($"guess a number, 1-{maxInt}");
    int playerInt;
    do{
        if (invalidGuesses > 0){
            Console.WriteLine("Ehh wrong you're wrong you didn't type a number dummy");
        }
        playerAnswer = Console.ReadLine();
        if (int.TryParse(playerAnswer, out playerInt)){
            invalidGuesses = 0;
        }
        else{
            invalidGuesses++;
        }
    } while(!int.TryParse(playerAnswer, out playerInt));
    if (playerInt == randomInteger){
        Console.WriteLine("Ding ding ding you are winner you are awesome I love you");
        isRight = true;
    }
    else if (playerInt < randomInteger){
        Console.WriteLine("who do you think I AM? you think I'd pick such a TINY and INSIGNIFICANT number??? shaking my head");
    }
    else{
        Console.WriteLine("WHATTT??+ CAN ANYONE EVEN COUNT THAT HIGH?!??? no wrong number it is smaller");
    }
}
Console.ReadLine();