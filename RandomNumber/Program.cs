Random rnd = new Random();


int randomSum = 0;

for(int i = 0; i < 3; i++)
{
    int myRandomNum = rnd.Next(0, 10); //0 - 10
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My Random number is: {myRandomNum}");
}


Console.WriteLine($"random sum total: {randomSum}");


