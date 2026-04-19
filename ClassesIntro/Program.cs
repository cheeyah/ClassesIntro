using ClassesIntro;
// See https://aka.ms/new-console-template for more information
// string playerAvatar = "@";
// Console.WriteLine(playerAvatar);
Vector2 startingPosition = new Vector2(4, 2);
Player hero = new Player(startingPosition);

List<Player> heroClones = new List<Player>();
heroClones.Add(hero);
heroClones.Add(new Player(startingPosition));

foreach (Player clone in heroClones)
{
    clone.Display();
}

while (true)
{
    for (int i = 0; i < heroClones.Count; i++)
    {
        Player currentClone = heroClones[i];
        currentClone.Display();
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        currentClone.ClearAtPosition();
    
        if (keyInfo.Key == ConsoleKey.A)
        {
            // ruch w lewo
            currentClone.Move(-1, 0);
        }
        else if (keyInfo.Key == ConsoleKey.D)
        {
            // ruch w prawo
            currentClone.Move(1, 0);
        }
        else if (keyInfo.Key == ConsoleKey.W)
        {
            // ruch w górę
            currentClone.Move(0, -1);
        }
        else if (keyInfo.Key == ConsoleKey.S)
        {
            // ruch w dół
            currentClone.Move(0, 1);
        }
        
        currentClone.Display();
    }
}