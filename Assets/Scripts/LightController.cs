using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

    public float MaxD, MinD = 0;
    public bool IsTalking = false;
    Light LI;
    public float GHGHGH;

	void Start () {
        LI = GetComponent<Light>();
        LI.type = LightType.Spot;
    }

    void Update()
    {

        if (!IsTalking)
        {
            MaxD = Camera.main.GetComponent<MicrophoneV>().MicLoudness * 80;

            if (MaxD >= 60f)
                StartCoroutine(GG());
        }

        //Debug.Log(Mathf.Round(Camera.main.GetComponent<MicrophoneV>().MicLoudness * 100f) / 100f);

    }

    IEnumerator GG()
    {
        IsTalking = true;
        MinD += 1f;
        LI.spotAngle = MinD;

        yield return new WaitForSeconds(0.01f);

        if (MinD < MaxD)
            StartCoroutine(GG());
        else
        {
            MaxD = 0;
            MinD = 0;
            LI.spotAngle = MinD;
            yield return new WaitForSeconds(10f);
            IsTalking = false;
        }

    }
}
