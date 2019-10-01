using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static int activeQuestNumber;
    public static int subQuestNumber;
    public int internalQuestNumber;
    public int internalSubNumber;

    public GameObject mainMark;
    public GameObject objective01Mark;
    public GameObject objective02Mark;
    public GameObject objective03Mark;
    public GameObject pointer;

    void Update()
    {
        internalQuestNumber = activeQuestNumber;
        internalSubNumber = subQuestNumber;
        pointer.transform.LookAt(mainMark.transform);

        if (internalSubNumber == 0)
        {
            pointer.SetActive(false);
        }
        else
        {
            pointer.SetActive(true);
        }

        if (internalSubNumber == 1)
        {
            mainMark.transform.position = objective01Mark.transform.position;
        }

        if (internalSubNumber == 2)
        {
            mainMark.transform.position = objective02Mark.transform.position;
        }

        if (internalSubNumber == 3)
        {
            mainMark.transform.position = objective03Mark.transform.position;
        }
    }
}