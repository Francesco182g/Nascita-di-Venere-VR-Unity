using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo5 : MonoBehaviour
{

    public GameObject soggetto;
    public GameObject ostacolo5;


    // Use this for initialization
    void Start()
    {
        soggetto.GetComponent<GameObject>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collido con Ostacolo5");
        Main.attivaPasso9();
        ostacolo5.SetActive(false);

    }
}