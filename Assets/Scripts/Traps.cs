using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour{

    bool XX;
    Renderer RNRER;
    public GameObject tirrinn;

    void Start ()
    {
        RNRER = GetComponent<Renderer>();

    }
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("DDdsadasdD");
        if (XX && other.transform.name == "Player")
        {
            tirrinn.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log("fsdf");

        if (!XX && other.transform.name == "Player")
        {
            StartCoroutine(GG());
        }
    }


    IEnumerator GG()
    {
        for (int i = 0; i < 4; i++)
        {
            RNRER.material.color = Color.black;
            yield return new WaitForSeconds(0.5f);
            RNRER.material.color = Color.red;
            yield return new WaitForSeconds(0.5f);

        }

        yield return new WaitForSeconds(0.5f);
        XX = true;
    }


}
