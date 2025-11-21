using UnityEngine;


public class Card
{
    public string Title => data.name;
    public string Description => data.Description;
    public Sprite Image => data.Image;
    public int Mana { get; private set; }
    private readonly CardData data;
    public Card(CardData cardDate)
    {
        data = cardDate;
        Mana = cardDate.Mana;
    }


}