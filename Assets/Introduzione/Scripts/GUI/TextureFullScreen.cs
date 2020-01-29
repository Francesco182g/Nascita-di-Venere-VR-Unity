using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GUITexture))]
public class TextureFullScreen : MonoBehaviour {
	void Start () {
		GetComponent<GUITexture>().pixelInset = new Rect(-Screen.width * 0.5f, -Screen.height * 0.5f, Screen.width, Screen.height);
		GetComponent<GUITexture>().transform.localPosition = new Vector3(0, 0, 999);
	}
}
