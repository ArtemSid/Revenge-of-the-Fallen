using UnityEngine;

public class HealthMonitor : MonoBehaviour
{
    public static int healthValue;
    public int internalHealth;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    void Start()
    {
        healthValue = 1;
    }

    void Update()
    {
        internalHealth = healthValue;

        if (healthValue == 1)
        {
            Heart1.SetActive(true);
        }

        if (healthValue == 2)
        {
            Heart2.SetActive(true);
        }

        if (healthValue == 3)
        {
            Heart3.SetActive(true);
        }
    }
}