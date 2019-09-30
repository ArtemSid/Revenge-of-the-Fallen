using System.Collections;
using UnityEngine;

public class Scene01Skip : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        StartCoroutine(FadeQuit());
    }

    IEnumerator FadeQuit()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}