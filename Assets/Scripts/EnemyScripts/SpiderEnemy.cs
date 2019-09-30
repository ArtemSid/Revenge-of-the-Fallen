using System.Collections;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{
    public SpiderAI spiderAIScript;

    public GameObject theSpider;

    public static int globalSpider;
    public int enemyHealth = 10;
    public int spiderStatus;
    public int baseXP = 10;
    public int calculatedXP;

    void Start()
    {
        spiderAIScript = GetComponent<SpiderAI>();
    }

    void DeductPoints(int damageAmount)
    {
        enemyHealth -= damageAmount; 
    }

    void Update()
    {
        globalSpider = spiderStatus;

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
        spiderAIScript.enabled = false;
        spiderStatus = 6;
        calculatedXP = baseXP * GlobalLevel.currentLevel;
        GlobalXP.currentXP += calculatedXP;
        yield return new WaitForSeconds(0.5f);
        theSpider.GetComponent<Animation>().Play("die");
    }
}