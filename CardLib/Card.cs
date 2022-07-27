namespace CardLib;

public enum Suit
{
    Club,
    Diamond,
    Heart,
    Spade,
}

public enum Rank
{
    Ace = 1,
    Deuce,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
}

public class Card
{
    public readonly Suit Suit;
    public readonly Rank Rank;

    public Card(Suit suit, Rank rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public override string ToString() => $"Card[The {Rank} of the {Suit}s]";
}
