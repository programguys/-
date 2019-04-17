using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour {

    public float time;
    public GameObject inst_obj;
    public GameObject FPSplayer;
    public Vector3 vect;
	 
	void Start () {
        StartCoroutine(instobj());
    }

    IEnumerator instobj () {
        while (true)
        {
            Instantiate(inst_obj, new Vector3(2, -2, -11), Quaternion.identity);
            yield return new WaitForSeconds(time);
        } 
    }
}
