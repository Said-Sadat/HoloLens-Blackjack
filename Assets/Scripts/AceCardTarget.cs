using UnityEngine;

public class AceCardTarget : CardTarget
{
    [SerializeField] GameObject aceButtons;

    private void Update()
    {
        aceButtons.transform.forward = new Vector3(
            -(Camera.main.transform.position.x - transform.position.x), 
            transform.position.y, 
            transform.position.z);
    }
    public override void CardRevealed()
    {
        if (revealed) return;

        if (targetBehaviour.ImageTarget.Name.Contains("A"))
            aceButtons.SetActive(true);
    }

    public void OnButtonValueClicked(int value)
    {
        revealed = true;

        ScoreKeeper.Instance.AddToPlayerScore(value);

        cardValueText.gameObject.SetActive(true);

        cardValueText.text = value.ToString();

        aceButtons.SetActive(false);
    }
}