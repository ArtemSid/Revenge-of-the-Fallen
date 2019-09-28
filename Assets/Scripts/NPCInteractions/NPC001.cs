using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC001 : MonoBehaviour
{
    public float theDistance;

    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject thePlayer;
    public GameObject textBox;
    public GameObject npcName;
    public GameObject npcText;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            AttackBlocker.blockSword = 1;
            actionText.GetComponent<Text>().text = "Talk";
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3)
            {
                AttackBlocker.blockSword = 2;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                //thePlayer.SetActive(false);
                StartCoroutine(NPC001Active());
            }
        }
    }

    void OnMouseExit()
    {
        AttackBlocker.blockSword = 0;
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

    IEnumerator NPC001Active ()
    {
        textBox.SetActive(true);
        npcName.GetComponent<Text>().text = "Samurai";
        npcName.SetActive(true);
        npcText.GetComponent<Text>().text = "Hello friend. I may have a quest for you if you wish tto accept it. Please come back later on this aftermoon";
        npcText.SetActive(true);
        yield return new WaitForSeconds(5.5f);
        npcName.SetActive(false);
        npcText.SetActive(false);
        textBox.SetActive(false);
        actionDisplay.SetActive(true);
        actionText.SetActive(true);
    }
}