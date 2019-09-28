using UnityEngine;

public class SpiderAI : MonoBehaviour
{
    public GameObject thePlayer;

    void Update()
    {
        transform.LookAt(thePlayer.transform);
    }
}