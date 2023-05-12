using TMPro;
using UnityEngine;

public class WinStreakUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winStreakText;

    private void OnEnable() =>
        ScoreKeeper.Instance.WinStreakUpdated += UpdateWinStreakText;

    void UpdateWinStreakText() =>
        winStreakText.text = "Win Streak: " + ScoreKeeper.Instance.WinStreak.ToString();

    private void OnDisable() =>
        ScoreKeeper.Instance.WinStreakUpdated -= UpdateWinStreakText;
}
