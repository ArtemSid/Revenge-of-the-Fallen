using UnityEngine;
using UnityEngine.UI;

public class Q001Objective03 : MonoBehaviour
{
    public float theDistance;
    public int closeObjective;

    public GameObject fakeSword;
    public GameObject realSword;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject theObjective;
    public GameObject chestBlock;
    public GameObject questComplete;
    public GameObject exMark;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;

        if (closeObjective == 3)
        {
            if (theObjective.transform.localScale.y <= 0.0f)
            {
                closeObjective = 0;
                theObjective.SetActive(false);
            }
            else
            {
                theObjective.transform.localScale -= new Vector3(0.0f, 0.01f, 0.0f);
            }
        }
    }

    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            actionText.GetComponent<Text>().text = "Take sword";
            actionText.SetActive(true);
            actionDisplay.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                fakeSword.SetActive(false);
                realSword.SetActive(true);
                chestBlock.SetActive(true);
                closeObjective = 3;
                actionText.SetActive(false);
                actionDisplay.SetActive(false);
                exMark.SetActive(true);
                questComplete.SetActive(true);
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}