using System.Collections;
using UnityEngine;

public class MetalonEnemy : MonoBehaviour
{
    public int enemyHealth = 10;

    void DeductPoints(int damageAmount)
    {
        enemyHealth -= damageAmount; 
    }

    void Update()
    {
        if (enemyHealth <= 0)
        {
            StartCoroutine(DeathMetalon());
        }
    }

    IEnumerator DeathMetalon ()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}