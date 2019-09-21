using UnityEngine;

public class Quest001Take : MonoBehaviour
{
    public float theDistance;

    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject UIQuest;
    public GameObject thePlayer;
    public GameObject noticeCam;

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
        }

        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                UIQuest.SetActive(true);
                noticeCam.SetActive(true);
                thePlayer.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}