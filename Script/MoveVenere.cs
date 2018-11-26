using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVenere : MonoBehaviour {

    public GameObject venere;
    private Vector3 startPos;
    private Vector3 endPos;

    private float distance = 30f;
    public static bool moveVenere = false; //Activation
    private float lerpTime = 14;
    private float currentLerpTime = 0;

	// Use this for initialization
	void Start () {
        startPos = venere.transform.position;
        endPos.x = 297.17f;
        endPos.y = 26.82f;
        endPos.z = 501.21f;

	}
	
    public static void attivaVenere()
    {
        moveVenere = true;
        Debug.Log("MoveVenere: Sto portando Venere nella sua posizione");
    }

	// Update is called once per frame
	void Update () {
		if(moveVenere == true)
        {
            currentLerpTime += Time.deltaTime;

            if(currentLerpTime >= lerpTime)
            {
                currentLerpTime = lerpTime;
            }

            float speed = currentLerpTime / lerpTime;
            venere.transform.position = Vector3.Lerp(startPos, endPos, speed);

        }
	}
}
