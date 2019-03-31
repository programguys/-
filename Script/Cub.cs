using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cub : MonoBehaviour {

    public GameObject obj;
    public float range = 5f, moveSpeed = 3f, TurnSpeed = 40f;
    public float a;

    void Start()
    {
       // obj = Instantiate(obj, new Vector3(0, 2, -21), Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            obj.transform.Translate(Vector3.forward * moveSpeed * a * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            obj.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            obj.transform.Rotate(Vector3.up, -TurnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            obj.transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
    }

}
