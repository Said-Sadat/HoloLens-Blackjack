using TMPro;
using UnityEngine;
using Vuforia;

public class CardTarget : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI cardValueText;

    protected ImageTargetBehaviour targetBehaviour;
    protected bool revealed;

    void Awake()
    {
        targetBehaviour = GetComponent<ImageTargetBehaviour>();
    }

    public virtual void CardRevealed()
    {
        cardValueText.text = ScoreKeeper.Instance.GetCardValue(targetBehaviour.ImageTarget.Name).ToString();
        ScoreKeeper.Instance.AddToPlayerScore(targetBehaviour.ImageTarget.Name);
    }
}
