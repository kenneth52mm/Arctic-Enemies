using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fillLoading : MonoBehaviour {

	float progress=0.0f;
	private Image image;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Load();
	}

    void Load() 
    {
        if (progress < 1)
        {
            progress += 0.010f;
            Debug.Log("" + progress);
            image = GameObject.Find("load").GetComponent<Image>();
            // new WaitForSeconds(1);
            image.fillAmount = progress;
        }
        else 
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }
}
