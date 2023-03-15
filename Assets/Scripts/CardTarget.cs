using UnityEngine;
using Vuforia;

public class CardTarget : MonoBehaviour
{
    ImageTargetBehaviour targetBehaviour;

    void Awake()
    {
        targetBehaviour = GetComponent<ImageTargetBehaviour>();
    }

    public void CardRevealed()
    {
        ScoreKeeper.Instance.AddToPlayerScore(targetBehaviour.ImageTarget.Name);
    }
}
