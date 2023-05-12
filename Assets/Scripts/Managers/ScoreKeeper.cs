using System;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] CardsScriptableObject cardsSO;

    int playerScore;
    int winStreak;

    public static ScoreKeeper Instance;

    public Action OnPlayerScoreUpdated;
    public Action<bool> PlayerWin;
    public Action WinStreakUpdated;
    public Action OnReset;

    public int PlayerScore => playerScore;
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

    public void ResetScore()
    {
        playerScore = 0;

        OnPlayerScoreUpdated?.Invoke();

        OnReset?.Invoke();
    }

    void DetermineResult(int handvalue)
    {
        if(handvalue == 21)
        {
            PlayerWin?.Invoke(true);
            winStreak++;
        }
        else if(handvalue > 21)
        {
            PlayerWin?.Invoke(false);
            winStreak = 0;
        }

        WinStreakUpdated?.Invoke();
    }

    public int GetCardValue(string cardname)
    {
        return cardsSO.Cards.Find(x =>
            x.CardTargetName.Contains(cardname)).CardValue; 
    }
}