using UnityEngine;

public class GlobalXP : MonoBehaviour
{
    public static int currentXP;
    public int internalXP;

    void Update()
    {
        internalXP = currentXP;
    }
}