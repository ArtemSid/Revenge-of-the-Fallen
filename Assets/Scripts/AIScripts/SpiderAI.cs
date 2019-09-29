using UnityEngine;

public class SpiderAI : MonoBehaviour
{
    public RaycastHit shot;

    public GameObject thePlayer;
    public GameObject theEnemy;

    public int attackTrigger;
    public float targetDistance;
    public float allowedRange = 40;
    public float enemySpeed;

    void Update()
    {
        transform.LookAt(thePlayer.transform);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            targetDistance = shot.distance;

            if (targetDistance <= allowedRange)
            {
                enemySpeed = 0.05f;

                if (attackTrigger == 0)
                {
                    theEnemy.GetComponent<Animation>().Play("walk");
                    transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed);
                }
            }
            else
            {
                enemySpeed = 0;
                theEnemy.GetComponent<Animation>().Play("idle");
            }
        }

        if (attackTrigger == 1)
        {
            enemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("attack");
        }
    }

    void OnTriggerEnter()
    {
        attackTrigger = 1;
    }

    void OnTriggerExit()
    {
        attackTrigger = 0;
    }
}