using System;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] CardsScriptableObject cardsSO;

    int playerScore;
    int dealerScore;

    public static ScoreKeeper Instance;
    public Action OnPlayerScoreUpdated;
    public Action<string> OnResult;

    public int PlayerScore => playerScore;
    public int DealerScore => dealerScore;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddToPlayerScore(string cardname)
    {
        int count = 0;
        
        count = cardsSO.Cards.Find(x => 
            x.CardTargetName.Contains(cardname)).CardValue;

        playerScore += count;
        OnPlayerScoreUpdated?.Invoke();

        DetermineResult(playerScore);
    }

    public void AddToDealerScore(int count)
    {
        dealerScore += count;
    }

    public void ResetScore()
    {
        playerScore = 0;
        dealerScore = 0;

        OnPlayerScoreUpdated?.Invoke();
        DetermineResult(-1);
    }

    void DetermineResult(int handvalue)
    {
        if(handvalue == 21)
        {
            OnResult?.Invoke("Win!");
        }
        else if(handvalue > 21)
        {
            OnResult?.Invoke("Bust...");
        }
        if (handvalue == -1)
            OnResult?.Invoke("");
    }
}