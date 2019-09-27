using System.Collections;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{
    public GameObject theSpider;
    public int enemyHealth = 10;
    public int spiderStatus;
    public int baseXP = 10;
    public int calculatedXP;

    void DeductPoints(int damageAmount)
    {
        enemyHealth -= damageAmount; 
    }

    void Update()
    {
        if (enemyHealth <= 0)
        {
            if (spiderStatus == 0)
            {
                StartCoroutine(DeathSpider());
            }
        }
    }

    IEnumerator DeathSpider ()
    {
        spiderStatus = 6;
        calculatedXP = baseXP * GlobalLevel.currentLevel;
        GlobalXP.currentXP += calculatedXP;
        yield return new WaitForSeconds(0.5f);
        theSpider.GetComponent<Animation>().Play("die");
    }
}