using System.Collections;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
    public GameObject theSword;
    public int swordStatus;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && swordStatus == 0 && AttackBlocker.blockSword == 0)
        {
            StartCoroutine(SwingSwordFunction());
        }
    }

    IEnumerator SwingSwordFunction()
    {
        swordStatus = 1;
        theSword.GetComponent<Animation>().Play("DaggerEpicAnim");
        swordStatus = 2;
        yield return new WaitForSeconds(1.0f);
        swordStatus = 0;
    }
}