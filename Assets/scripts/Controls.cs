using UnityEngine;

public class Controls : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    float maxV;

    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;
    [SerializeField]
    KeyCode gpadP;
    [SerializeField]
    KeyCode gpadN;



    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
            updateSpeed(v3Force);
        else if (Input.GetKey(keyNegative))
            updateSpeed(-v3Force);

        if (Input.GetKey(gpadP))
            updateSpeed(v3Force);
        else if (Input.GetKey(gpadN))
            updateSpeed(-v3Force);

    }

    private void updateSpeed(Vector3 update)
    {
        Vector3 velocity = GetComponent<Rigidbody>().velocity + update;

        GetComponent<Rigidbody>().velocity = new Vector3(
            bound(velocity.x, maxV),
            bound(velocity.y, maxV),
            bound(velocity.z, maxV)
        );
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
