using UnityEngine;

public class UILookatCamera : MonoBehaviour
{
    private void Update()
    {
        gameObject.transform.LookAt(Camera.main.transform.position);
    }
}
