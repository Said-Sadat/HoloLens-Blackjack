using UnityEngine;
using UnityEngine.UI;

public class ResetButtonUI : MonoBehaviour
{
    [SerializeField] Button resetButton;

    void Start() =>
        resetButton.onClick.AddListener(() => ScoreKeeper.Instance.ResetScore());
}
