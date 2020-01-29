using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public Button cardboard;
    public Button Nocardboard;
    public GameObject primoMenu;
    public GameObject cardboard2;


	// Use this for initialization
	void Start () {
        cardboard.GetComponent<Button>();
        Nocardboard.GetComponent<Button>();

        cardboard.onClick.AddListener(EseguiCardboard);
        Nocardboard.onClick.AddListener(EseguiNoCardboard);
	}
	
    public void EseguiCardboard()
    {
        primoMenu.SetActive(false);
        cardboard2.SetActive(true);
        Debug.Log("MENU: Clicco Esegui Cardboard");
        Main.attivaCardboard();
    }

    public void EseguiNoCardboard()
    {
        primoMenu.SetActive(false);
        Debug.Log("MENU: Clicco Esegui no Cardboard");
        Main.attivaNoCardboard();
    }



}
