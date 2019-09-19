using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Buttons : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject noticeCam;
    public GameObject UIQuest;
    public GameObject activeQuestBox;
    public GameObject Objective01;
    public GameObject Objective02;
    public GameObject Objective03;

    public void AcceptQuest()
    {
        thePlayer.SetActive(true);
        noticeCam.SetActive(false);
        UIQuest.SetActive(false);
        StartCoroutine(SetQuestUI());
    }

    public void DiclineQuest()
    {
        thePlayer.SetActive(true);
        noticeCam.SetActive(false);
        UIQuest.SetActive(false);
    }

    IEnumerator SetQuestUI()
    {
        activeQuestBox.GetComponent<Text>().text = "My first weapon";
        Objective01.GetComponent<Text>().text = "Reach the clearing in the wood";
        Objective02.GetComponent<Text>().text = "Open the chest";
        Objective03.GetComponent<Text>().text = "Retrieve the weapon";

        QuestManager.activeQuestNumber = 1;
        yield return new WaitForSeconds(0.5f);
        activeQuestBox.SetActive(true);
        yield return new WaitForSeconds(1);
        Objective01.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective02.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective03.SetActive(true);
        yield return new WaitForSeconds(9);
        activeQuestBox.SetActive(false);
        Objective01.SetActive(false);
        Objective02.SetActive(false);
        Objective03.SetActive(false);
    }
}