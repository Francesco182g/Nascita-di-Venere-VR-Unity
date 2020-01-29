using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo0 : MonoBehaviour {

    public GameObject soggetto;
    public GameObject ostacolo0;
    
    // Use this for initialization
    void Start()
    {
        soggetto.GetComponent<GameObject>();
    }

    private void Update()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collido con Ostacolo1");
        Main.attivaPasso1post();
        ostacolo0.SetActive(false);
        
    }
}