using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI resultTextUI;

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        ScoreKeeper.Instance.PlayerWin += ShowResult;
        ScoreKeeper.Instance.OnReset += ResetResult;
    }

    void ShowResult(bool playerwin)
    {
        if (playerwin)
            resultTextUI.text = "You Win!";
        else
            resultTextUI.text = "Bust...";

        animator.SetBool("PlayerWin", playerwin);
    }

    void ResetResult()
    {
        animator.SetBool("PlayerWin", false);
        resultTextUI.text = "";
    }
}