namespace CardLib;

public class Deck
{
    public const int CardCount = 52;
    public const int SuitCount = 4;
    public const int RankCount = 13;

    private readonly Card[] cards_;

    public Deck()
    {
        cards_ = new Card[CardCount];

        for (int suitVal = 0; suitVal < SuitCount; ++suitVal)
        {
            for (int rankVal = 0; rankVal < RankCount; ++rankVal)
            {
                cards_[rankVal + suitVal * RankCount] = new Card((Suit)suitVal, (Rank)(rankVal+1));
            }
        }
    }

    public Card? GetCard(int index)
    {
        if (index < 0 || index >= cards_.Length)
        {
            return null;
        }
        else
        {
            return cards_[index];
        }
    }

    public void Shuffle()
    {
        Random engine = new Random();
        
        for (int i = 0; i < cards_.Length; ++i)
        {
            for (int j = i; j < cards_.Length - 1; ++j)
            {
                var index = engine.Next(j, cards_.Length);
                (cards_[index], cards_[j]) = (cards_[j], cards_[index]);
            }
        }
    }
}
