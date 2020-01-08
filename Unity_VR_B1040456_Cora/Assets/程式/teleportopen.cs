using UnityEngine;

public class teleportopen : MonoBehaviour
{
    public GameObject teleport;

    private void Update()
    {
        if (GameManager.cube)
        {
            teleport.SetActive(true);
        }
    }
}
