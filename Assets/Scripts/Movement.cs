using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float Speed;
    void Start ()
    {
		
	}


    void Update ()
    {
        float X = Input.GetAxis("Vertical");
        transform.Translate(Speed * X * Time.deltaTime,0,0);
	}
}
