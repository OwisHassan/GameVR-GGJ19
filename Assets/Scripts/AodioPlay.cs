using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AodioPlay : MonoBehaviour {

    public float TimeToStart;
    public GameObject AAA;
    void Start ()
    {
        AAA.SetActive(false);
        StartCoroutine(GG());

    }

    IEnumerator GG()
    {

        TimeToStart = Random.Range(5f, 15f);
        yield return new WaitForSeconds(TimeToStart);
        AAA.SetActive(true);
        yield return new WaitForSeconds(39.5f);
        AAA.SetActive(false);
        StartCoroutine(GG());

    }

}
