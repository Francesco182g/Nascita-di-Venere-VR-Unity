﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo2 : MonoBehaviour {



    public GameObject soggetto;
    public GameObject ostacolo2;



	// Use this for initialization
	void Start () {
        soggetto.GetComponent<GameObject>();
	}

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collido con Ostacolo2");
        Main.attivaPasso4();
        ostacolo2.SetActive(false);
        //Staccapioggia.Stop();

    }

}