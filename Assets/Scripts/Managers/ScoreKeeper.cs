using System;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] CardsScriptableObject cardsSO;

    int playerScore;
    int dealerScore;
    int winStreak;

    public static ScoreKeeper Instance;
    public Action OnPlayerScoreUpdated;
    public Action<string> OnResult;
    public Action WinStreakUpdated;
    public Action OnReset;

    public int PlayerScore => playerScore;
    public int DealerScore => dealerScore;
    public int WinStreak => winStreak;

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
        
        count = GetCardValue(cardname);

        playerScore += count;
        OnPlayerScoreUpdated?.Invoke();

        DetermineResult(playerScore);
    }

    public void AddToPlayerScore(int value)
    {
        playerScore += value;
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

        OnReset?.Invoke();
    }

    void DetermineResult(int handvalue)
    {
        if(handvalue == 21)
        {
            OnResult?.Invoke("Win!");
            winStreak++;
        }
        else if(handvalue > 21)
        {
            OnResult?.Invoke("Bust...");
            winStreak = 0;
        }
        if (handvalue == -1)
            OnResult?.Invoke("");

        WinStreakUpdated?.Invoke();
    }

    public int GetCardValue(string cardname)
    {
        return cardsSO.Cards.Find(x =>
            x.CardTargetName.Contains(cardname)).CardValue; 
    }
}