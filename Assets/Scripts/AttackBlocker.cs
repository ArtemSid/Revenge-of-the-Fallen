using UnityEngine;

public class AttackBlocker : MonoBehaviour
{
    public static int blockSword;
    public int internalBlock;

    void Update()
    {
        internalBlock = blockSword;
    }
}