using UnityEngine;

public class GlobalExp : MonoBehaviour
{
    public static int currentExp;
    public int internalExp;

    void Update()
    {
        internalExp = currentExp;
    }
}