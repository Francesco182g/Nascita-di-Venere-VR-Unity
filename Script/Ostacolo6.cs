using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo6 : MonoBehaviour
{

    public GameObject soggetto;
    public GameObject ostacolo6;


    // Use this for initialization
    void Start()
    {
        soggetto.GetComponent<GameObject>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collido con Ostacolo6");
        Main.attivaPasso10();
		ostacolo6.SetActive(false);
        MoveVenere.attivaVenere();
				

    }
}
