namespace CardSort.Models;

public class Card
{
    public int CardId { get; set; }
    public string Name { get; set; } = string.Empty;
    public CardType CardType { get; set; }
    public CardColor CardColor { get; set; }
    public string CardCost { get; set; }
    public CardRarity CardRarity { get; set; }
    
    public Deck Deck { get; set; }
}