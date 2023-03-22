using TMPro;
using UnityEngine;

public class CardCountUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI cardCountText;

    private void Start()
    {
        ScoreKeeper.Instance.OnPlayerScoreUpdated += UpdateCardCount;
    }

    void UpdateCardCount()
    {
        if (cardCountText != null)
            cardCountText.text = "Hand: " + ScoreKeeper.Instance.PlayerScore.ToString();
    }

    private void OnDisable()
    {
        ScoreKeeper.Instance.OnPlayerScoreUpdated -= UpdateCardCount;
    }
}
