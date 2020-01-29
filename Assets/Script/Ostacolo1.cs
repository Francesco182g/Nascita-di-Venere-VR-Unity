using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo1 : MonoBehaviour {

    public GameObject soggetto;
    public GameObject ostacolo1;
    public GameObject quadro;

    public GameObject pioggia;
    public AudioSource Spioggia;
    public AudioClip Apioggia;

	// Use this for initialization
	void Start () {
        soggetto.GetComponent<GameObject>();
        Spioggia.clip = Apioggia;

	}

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collido con Ostacolo1");
        Main.attivaPasso2();
        ostacolo1.SetActive(false);
        quadro.SetActive(false);
        pioggia.SetActive(true);
        Spioggia.Play();
        
    }


}
