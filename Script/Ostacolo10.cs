using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo10 : MonoBehaviour
{

    public GameObject soggetto;
    public GameObject ostacolo10;


    // Use this for initialization
    void Start()
    {
        soggetto.GetComponent<GameObject>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collido con Ostacolo10");
        Main.attivaPasso15();
		ostacolo10.SetActive(false);

    }
}
