using System.Collections;
using UnityEngine;

public class Scene01 : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject fadeIn;
    public GameObject fadeOut;
    public GameObject thePlayer;

    void Start()
    {
        StartCoroutine(CutSceneStart());
    }
        
    IEnumerator CutSceneStart()
    {
        yield return new WaitForSeconds(5);
        Camera2.SetActive(true);
        Camera1.SetActive(false);
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(10);
        Camera3.SetActive(true);
        Camera2.SetActive(false);
        yield return new WaitForSeconds(4);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        thePlayer.SetActive(true);
        fadeIn.SetActive(true);
        fadeOut.SetActive(false);
        Camera3.SetActive(false);
    }
}