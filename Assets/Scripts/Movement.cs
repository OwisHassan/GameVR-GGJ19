using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public event GvrControllerInput.OnStateChangedEvent OnStateChanged;

    public float Speed;
    void Start ()
    {
		
	}


    void Update ()
    {
        //GvrControllerInput.tou

        //GvrControllerInput.OnStateChangedEvent

        //Vector2 f = GvrControllerInput.TouchPos();
        

        float X = Input.GetAxis("Vertical");
        transform.Translate(Speed * X * Time.deltaTime,0,0);
	}
}
