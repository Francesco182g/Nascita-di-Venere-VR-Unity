using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo7 : MonoBehaviour
{

    public GameObject soggetto;
    public GameObject ostacolo7;


    // Use this for initialization
    void Start()
    {
        soggetto.GetComponent<GameObject>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collido con Ostacolo7");
        Main.attivaPasso12();
		ostacolo7.SetActive(false);

    }
}
