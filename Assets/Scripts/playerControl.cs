using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Rigidbody body;
    public float forwardSpeed = 1500;
    public float controllSpeed = 1000;

    void Start()
    {
        Debug.Log("I work!");
    }

    void FixedUpdate()
    {
        body.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            body.AddForce(controllSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            body.AddForce(-controllSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
