using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    private float turnspeed = 45f;
    private float horizontalinput;
    private float forwardinput;

    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardinput);
        transform.Rotate(Vector3.up, turnspeed * horizontalinput * Time.deltaTime);


    }
}
