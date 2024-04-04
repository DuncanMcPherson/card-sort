
using System.ComponentModel.DataAnnotations.Schema;

namespace CardSort.Models;

[Table("Decks")]
public class Deck
{
    public int DeckId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DeckType DeckType { get; set; }
    public ICollection<Card> Cards { get; } = [];
}