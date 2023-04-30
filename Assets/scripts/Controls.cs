using UnityEngine;

public class Controls : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    float maxV = 10000;
    public int boost = 60;

    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;
    [SerializeField]
    KeyCode gpadP;
    [SerializeField]
    KeyCode gpadN;
    [SerializeField]
    KeyCode BoostButton;
    void FixedUpdate()
    {
        if (Input.GetKey(BoostButton) && boost <= 10)
         {
            boost++;
         }
         else if (boost >= 1)
         {
                boost--;
         }
        Debug.Log(boost);

        if (Input.GetKey(keyPositive) || Input.GetKey(gpadP))
            updateSpeed(v3Force * boost);
        else if (Input.GetKey(keyNegative) || Input.GetKey(gpadN))
        {
            updateSpeed(-v3Force * boost);
        }
    }

    private void updateSpeed(Vector3 update)
    {
        Vector3 velocity = GetComponent<Rigidbody>().velocity + update;
        GetComponent<Rigidbody>().velocity = new Vector3(
            bound(velocity.x, maxV),
            bound(velocity.y, maxV),
            bound(velocity.z, maxV)
        );
        Debug.Log($"{velocity}");
    }

    private float bound(float a, float bound)
     {
        if (a < -bound)
        {
            return -bound;
        }
        if (a > bound)
        {
            return bound;
        }
        return a;
     }

}
