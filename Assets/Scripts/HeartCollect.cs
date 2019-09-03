using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    public int rotateSpeed;
    public AudioSource collectSound;
    public GameObject thisHeart;

    void Update()
    {
        rotateSpeed = 2;
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

    void OnTriggerEnter()
    {
        collectSound.Play();
        HealthMonitor.healthValue += 1;
        thisHeart.SetActive(false);
    }
}