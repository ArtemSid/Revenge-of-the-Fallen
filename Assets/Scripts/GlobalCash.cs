using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public GameObject goldDisplay;

    public static int goldAmount;
    public int internalGold;

    void Start()
    {
        
    }

    void Update()
    {
        internalGold = goldAmount;
        goldDisplay.GetComponent<Text>().text = "GOLD: " + internalGold;
    }
}