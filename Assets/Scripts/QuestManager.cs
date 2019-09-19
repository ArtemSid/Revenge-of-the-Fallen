using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static int activeQuestNumber;
    public int internalQuestNumber;

    void Update()
    {
        internalQuestNumber = activeQuestNumber;   
    }
}