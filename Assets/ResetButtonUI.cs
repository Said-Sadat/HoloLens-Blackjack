using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButtonUI : MonoBehaviour
{
    [SerializeField] Button resetButton;

    // Start is called before the first frame update
    void Start()
    {
        resetButton.onClick.AddListener(() => ScoreKeeper.Instance.ResetScore());
    }
}
