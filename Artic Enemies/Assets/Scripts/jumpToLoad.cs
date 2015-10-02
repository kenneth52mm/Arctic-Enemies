using UnityEngine;
using System.Collections;

public class jumpToLoad : MonoBehaviour
{

    // Use this for initialization
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        Application.LoadLevel(1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
