using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo3 : MonoBehaviour {

    public GameObject soggetto;
    public GameObject ostacolo3;
    public GameObject pioggiaLeggera;
    public GameObject pioggia;

	// Use this for initialization
	void Start () {
        soggetto.GetComponent<GameObject>();
	}

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collido con Ostacolo3");
        Main.attivaPasso5();
        pioggia.SetActive(false);
        pioggiaLeggera.SetActive(false);
        ostacolo3.SetActive(false);
        
    }
}