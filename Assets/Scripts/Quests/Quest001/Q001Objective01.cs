﻿using System.Collections;
using UnityEngine;

public class Q001Objective01 : MonoBehaviour
{
    public GameObject theObjective;
    public int closeObjective;

    void Update()
    {
        if (closeObjective == 1)
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

    void OnTriggerEnter()
    {
        StartCoroutine(FinishObjective());
    }

    IEnumerator FinishObjective()
    {
        theObjective.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        closeObjective = 1;
    }
}