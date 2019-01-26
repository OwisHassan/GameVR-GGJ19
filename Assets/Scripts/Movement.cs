using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{

    public float X;
    Vector2 h;
    public Text TT;
    public float Speed;
    int GGHHS = 0;
    public GameObject HsadH;
    Rigidbody RR;


    void Start()
    {
        GGHHS = 0;
        RR = GetComponent<Rigidbody>();

    }


    void Update()
    {


        TT.text = (h.ToString() + "///" + Camera.main.transform.rotation.eulerAngles.ToString() + GGHHS.ToString());
        X = Input.GetAxis("Vertical");
        if (GvrControllerInput.GetDevice(GvrControllerHand.Dominant).GetButton(GvrControllerButton.TouchPadTouch))
        {
            GGHHS++;
            h = GvrControllerInput.GetDevice(GvrControllerHand.Dominant).TouchPos;

        }
        if (GvrControllerInput.GetDevice(GvrControllerHand.Dominant).GetButtonUp(GvrControllerButton.TouchPadTouch))
        {
            GGHHS = 0;
            h = Vector2.zero;
            RR.velocity = Vector3.zero;
            RR.angularVelocity = Vector3.zero;
        }

        RR.AddForce(Camera.main.transform.forward * h.y * Speed);

    }
}
