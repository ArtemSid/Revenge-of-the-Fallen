using UnityEngine;
using UnityEngine.UI;

public class Quest001Complete : MonoBehaviour
{
    public float theDistance;

    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject UIQuest;
    public GameObject thePlayer;
    public GameObject exMark;
    public GameObject completeTrigger;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            actionText.GetComponent<Text>().text = "Complete quest";
        }

        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3)
            {
                QuestManager.subQuestNumber = 0;
                exMark.SetActive(false);
                GlobalExp.currentExp += 100;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                completeTrigger.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}