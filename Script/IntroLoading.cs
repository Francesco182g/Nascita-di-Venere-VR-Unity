using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class IntroLoading : MonoBehaviour {
    AsyncOperation op;
    private int tempo = 0;
	// Use this for initialization
	void Start () {
        UnityEngine.XR.XRSettings.enabled = false;
        op = SceneManager.LoadSceneAsync("Nascita Di Venere", LoadSceneMode.Single);
        op.allowSceneActivation = false;
        StartCoroutine(Cronometro());
    
    }
    IEnumerator Cronometro()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            tempo += 1;
            if (tempo == 5)
            {
                op.allowSceneActivation = true;
            }
        }
    }
}
