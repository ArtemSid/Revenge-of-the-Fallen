using UnityEngine;
using UnityEngine.UI;

public class Q001Objective02 : MonoBehaviour
{
    public float theDistance;
    public int closeObjective;

    public GameObject treasureChest;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject theObjective;
    public GameObject takeSword;

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

    void OnMouseOver ()
    {
        if (theDistance <= 3)
        {
            actionText.GetComponent<Text>().text = "Open chest";
            actionText.SetActive(true);
            actionDisplay.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                treasureChest.GetComponent<Animation>().Play("Q01ChestOpen");
                takeSword.SetActive(true);
                closeObjective = 3;
                actionText.SetActive(false);
                actionDisplay.SetActive(false);
            }
        }
    }

    void OnMouseExit ()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}