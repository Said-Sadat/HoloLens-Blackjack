using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI resultTextUI;

    private void OnEnable()
    {
        ScoreKeeper.Instance.OnResult += ShowResult;
    }

    void ShowResult(string result)
    {
        resultTextUI.text = result;
    }
}
