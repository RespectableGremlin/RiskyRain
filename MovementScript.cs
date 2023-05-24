using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody playerBody;

    public float cooldown = 5;

    public float force = 5;

    float timer;

    public bool trigger = false;

    void Start()
    {
        timer = 0;

        trigger = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > cooldown && trigger)
        {
            playerBody.AddForce(transform.forward * force, ForceMode.Impulse);

            timer = 0;
        }
    }

    public void Activate(bool t)
    {
        trigger = t;
    }
}