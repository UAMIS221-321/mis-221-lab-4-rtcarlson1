
int decision = 0;

decision = Menu();

while(decision != 3)
{
    int height = GetRandomHeight();
    if(decision == 1)
    {
        GetFull(height);
    }
    else if(decision == 2)
    {
        GetPartial(height);
    }



    decision = Menu();
}



static int Menu()
{
    System.Console.WriteLine("Enter 1 to display full triangle");
    System.Console.WriteLine("Enter 2 to display partial triangle");
    System.Console.WriteLine("Enter 3 to exit");

    string choice = Console.ReadLine();

    return int.Parse(choice);
}

static int GetRandomHeight()
{
    Random rand = new Random();
    int height = rand.Next(7) + 3;
    return height;
}

static void GetFull(int height)
{
    for(int i = 0; i < height; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            System.Console.Write("o ");
        }
        System.Console.WriteLine("");
    }
}

static void GetPartial(int height)
{
    for(int i = 0; i < height; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            Random rand = new Random();
            int broken = rand.Next(2);
            
            if(broken == 0)
            {
                System.Console.Write("o ");
            }
        }
        System.Console.WriteLine("");
    }
}