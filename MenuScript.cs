using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Button start;
    public Button help;
    public Button quit;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void HelpScreen()
    {
        SceneManager.LoadScene(0);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
