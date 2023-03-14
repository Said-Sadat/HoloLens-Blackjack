using UnityEngine;

public class CardTarget : MonoBehaviour
{
    [SerializeField] int cardValue;

    public void CardRevealed()
    {
        ScoreKeeper.Instance.AddToPlayerScore(cardValue);
    }
}
