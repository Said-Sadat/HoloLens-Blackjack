using UnityEngine;

public class AceCardTarget : CardTarget
{
    [SerializeField] GameObject aceButtons;

    public override void CardRevealed()
    {
        //foreach (Transform t in transform)
        //{
        //    t.gameObject.SetActive(true);
        //}

        //if (!revealed)
        //    revealed = true;
        //else
        //    return;

        if (targetBehaviour.ImageTarget.Name.Contains("A"))
            aceButtons.SetActive(true);
    }

    public void OnButtonValueClicked(int value)
    {
        ScoreKeeper.Instance.AddToPlayerScore(value);
        cardValueText.gameObject.SetActive(true);
        cardValueText.text = value.ToString();

        aceButtons.SetActive(false);
    }
}