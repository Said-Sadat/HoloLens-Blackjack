using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Card
{
    [SerializeField] List<string> cardImageTargetName;
    [SerializeField] int cardValue;

    public List<string> CardTargetName => cardImageTargetName;
    public int CardValue => cardValue;
}

[CreateAssetMenu(fileName = "Cards", menuName = "ScriptableObjects/CardsScriptableObject", order = 1)]
public class CardsScriptableObject : ScriptableObject
{
    [SerializeField] List<Card> cards;

    public List<Card> Cards => cards;
}