using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum TurnState
    {
        PlayerTurn,
        DealerTurn,
        Stand,
        Bust,
        Win,
        Lose,
        Draw
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScoreKeeper.Instance.AddToPlayerScore("QS");
        }
    }
}