using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    public float speed;
    public Vector3 vector;
    public float vect;
    public float vect1;
    public Vector3 endvector;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position,vector,Time.deltaTime * speed);

        if (transform.position == vector && vector.x != vect)
        {
            vector.x = vect;
        }
        else if (transform.position == vector && vector.x == vect)
        {
            vector.x = vect1;
        }
        if (transform.position == endvector) {
            Destroy(gameObject);
        }
	}
}
