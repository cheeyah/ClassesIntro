namespace ClassesIntro;

public class Player
{
    /*
     * Akcje:
     * - poruszanie się
     * - wyświetlanie swojego awatara
     * - podnoszenie przedmiotów
     * - zarządzanie ekwipunkiem
     * - otrzymywanie obrażeń
     * - atak
     * - rozmowa z NPC
     * - podejmowanie i wykonywanie zadań
     *
     * Dane:
     * - pozycja
     * - prędkość poruszania się
     * - awatar (reprezentacja graficzna gracza)
     * - zasięg interakcji
     * - ekwipunek (sposób przechowania go)
     * - hp (aktualne, maskymalne, określające jakieś ograniczenia ruchu?)
     * - siła ataku
     * - zasięg ataku
     * - częstotliwość ataku
     * - celność
     * - info czy z kimś rozmawialiśmy
     * - dziennik
     * - lista zadań ze statusem ich realizacji
     */
    private string avatar = "@";
    private Vector2 position;

    public void Display()
    {
        Console.SetCursorPosition(position.x, position.y);
        Console.Write(avatar);
    }

    public void ClearAtPosition()
    {
        Console.SetCursorPosition(position.x, position.y);
        Console.Write(" ");
    }

    public void Move(int diffX, int diffY)
    {
        Vector2 targetPosition = new Vector2(position.x + diffX, position.y + diffY);
        
        if (targetPosition.x >= 0 && targetPosition.x < Console.BufferWidth)
        {
            position.x = targetPosition.x;
        }

        if (targetPosition.y >= 0 && targetPosition.y < Console.BufferHeight)
        {
            position.y = targetPosition.y;
        }
    }
}