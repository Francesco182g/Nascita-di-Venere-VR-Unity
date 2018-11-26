using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo8 : MonoBehaviour
{

    public GameObject soggetto;
    public GameObject ostacolo8;


    // Use this for initialization
    void Start()
    {
        soggetto.GetComponent<GameObject>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collido con Ostacolo8");
        Main.attivaPasso13();
		ostacolo8.SetActive(false);


    }
}
