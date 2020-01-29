using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostacolo4 : MonoBehaviour
{

    public GameObject soggetto;
    public GameObject ostacolo4;


    // Use this for initialization
    void Start()
    {
        soggetto.GetComponent<GameObject>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collido con Ostacolo4");
        Main.attivaPasso8();
        ostacolo4.SetActive(false);
    }
}