using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MuoviSinistra : MonoBehaviour {

    public Button left;

	// Use this for initialization
	void Start () {
		
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        Main.VaiSinistra();
    }
}
