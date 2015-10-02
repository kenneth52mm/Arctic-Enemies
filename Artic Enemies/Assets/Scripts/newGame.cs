using UnityEngine;
using System.Collections;

public class newGame : MonoBehaviour
{

    // Use this for initialization
    public void StartGame()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
