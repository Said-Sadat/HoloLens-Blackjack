using System;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int playerScore;
    int dealerScore;

    public static ScoreKeeper Instance;
    public Action OnPlayerScoreUpdated;

    public int PlayerScore => playerScore;
    public int DealerScore => dealerScore;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddToPlayerScore(int count)
    {
        playerScore += count;
        OnPlayerScoreUpdated?.Invoke();
    }

    public void AddToDealerScore(int count)
    {
        dealerScore += count;
    }

    public void ResetScore()
    {
        playerScore = 0;
        dealerScore = 0;
    }
}
