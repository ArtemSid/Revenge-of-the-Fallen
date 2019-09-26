using UnityEngine;

public class InfictDamage : MonoBehaviour
{
    public int damageAmout = 5;
    public float targetDistance;
    public float allowedRange = 2.7f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                targetDistance = hit.distance;

                if (targetDistance <= allowedRange)
                {
                    hit.transform.SendMessage("DeductPoints", damageAmout, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}