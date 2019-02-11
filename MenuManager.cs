using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Button start;
    public Button help;
    public Button credits;
    public Button quit;

    // Use this for initialization
    void Start()
    {
        start.onClick.AddListener(TaskOnClick);
        help.onClick.AddListener(HelpButton.Help);
        credits.onClick.AddListener(CreditButton.Credits);
        quit.onClick.AddListener(QuitButton.Quit);
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }
}
