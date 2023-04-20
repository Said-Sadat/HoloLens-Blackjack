using System.Collections;
using TMPro;
using UnityEngine;
using Vuforia;

public class CardTarget : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI cardValueText;

    protected ImageTargetBehaviour targetBehaviour;
    protected bool revealed;

    void Start()
    {
        targetBehaviour = GetComponent<ImageTargetBehaviour>();
        ScoreKeeper.Instance.OnReset += OnReset;
    }

    public virtual void CardRevealed()
    {
        if (revealed) return;
        cardValueText.gameObject.SetActive(true);
        cardValueText.text = ScoreKeeper.Instance.GetCardValue(targetBehaviour.ImageTarget.Name).ToString();
        ScoreKeeper.Instance.AddToPlayerScore(targetBehaviour.ImageTarget.Name);

        revealed = true;
    }

    void OnReset()
    {
        revealed = false;
        cardValueText.gameObject.SetActive(false);
    }
}
