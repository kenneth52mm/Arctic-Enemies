using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		float time = GameObject.Find("Fader").GetComponent<SceneFadeInOut> ().BeginFade (1);
		yield return new WaitForSeconds (time);
		Application.LoadLevel(1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
