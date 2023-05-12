using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using UnityEngine;

public class Table : MonoBehaviour
{
    [SerializeField] TapToPlace tapToPlace;
    [SerializeField] Collider tableCollider;

    public void OnTablePlaced()
    {
        tapToPlace.enabled = false;
        CoreServices.SpatialAwarenessSystem.Disable();
        tableCollider.enabled = false;
    }
}
