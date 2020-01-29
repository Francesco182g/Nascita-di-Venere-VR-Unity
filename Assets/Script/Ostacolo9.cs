using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo9 : MonoBehaviour
{

    public GameObject soggetto;
    public GameObject ostacolo9;


    // Use this for initialization
    void Start()
    {
        soggetto.GetComponent<GameObject>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collido con Ostacolo9");
        Main.attivaPasso14();
		ostacolo9.SetActive(false);

    }
}
