using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionControl : MonoBehaviour
{
    public float speed = 1.0f;
    public float turnSpeed = 1.0f;
    public float thrust = 1.0f;
    private float horizontalInput;
    private float forwardInput;

    public Rigidbody rb;
    public ParticleSystem ps;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ParticleSystem.EmissionModule em = ps.emission;
        em.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        ps = GetComponent<ParticleSystem>();
        Vector3 movementV = new Vector3(0, 0, speed * Time.deltaTime);
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(movementV * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetButtonDown("Boost"))
        {
            ParticleSystem.EmissionModule em = ps.emission;
            em.enabled = true;
            rb.AddForce(transform.forward * thrust, ForceMode.Acceleration);
            Debug.Log("warp mode enabled");
        }

    }
}
