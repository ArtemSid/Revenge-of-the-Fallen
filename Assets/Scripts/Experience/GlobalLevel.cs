using UnityEngine;

public class GlobalLevel : MonoBehaviour
{
    public static int currentLevel = 1;
    public int internalLevel;

    void Update()
    {
        internalLevel = currentLevel;
    }
}