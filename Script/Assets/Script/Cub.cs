using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cub : MonoBehaviour {

    public float range = 5f, moveSpeed = 3f, TurnSpeed = 40f;
    public float Boost;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.forward * moveSpeed * Boost * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -TurnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
    }

}
