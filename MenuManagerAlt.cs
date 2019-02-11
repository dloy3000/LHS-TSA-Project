using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManagerAlt : MonoBehaviour
{
    public Button start;
    public Button help;
    public Button credits;
    public Button quit;
    private int selection;

    private Vector3 startNativeSize;
    private Vector3 helpNativeSize;
    private Vector3 creditsNativeSize;
    private Vector3 quitNativeSize;

    // Use this for initialization
    void Start()
    {
        start.onClick.AddListener(StartButton.StartGame);
        help.onClick.AddListener(HelpButton.Help);
        credits.onClick.AddListener(CreditButton.Credits);
        quit.onClick.AddListener(QuitButton.Quit);

        selection = 1;

        startNativeSize = start.transform.localScale;
        helpNativeSize = help.transform.localScale;
        creditsNativeSize = credits.transform.localScale;
        quitNativeSize = quit.transform.localScale;
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            selection -= 1;

            if (selection < 1)
                selection = 4;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            selection += 1;

            if (selection > 4)
                selection = 1;
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            buttonPress();
        }

        buttonHighlight();
    }

    void buttonHighlight()
    {
        if (selection == 1)
        {
            start.gameObject.transform.localScale = startNativeSize * 1.2f;
            help.gameObject.transform.localScale = helpNativeSize;
            credits.gameObject.transform.localScale = creditsNativeSize;
            quit.gameObject.transform.localScale = quitNativeSize;
        }

        else if (selection == 2)
        {
            start.gameObject.transform.localScale = startNativeSize;
            help.gameObject.transform.localScale = helpNativeSize * 1.2f;
            credits.gameObject.transform.localScale = creditsNativeSize;
            quit.gameObject.transform.localScale = quitNativeSize;
        }

        else if (selection == 3)
        {
            start.gameObject.transform.localScale = startNativeSize;
            help.gameObject.transform.localScale = helpNativeSize;
            credits.gameObject.transform.localScale = creditsNativeSize * 1.2f;
            quit.gameObject.transform.localScale = quitNativeSize;
        }

        else if (selection == 4)
        {
            start.gameObject.transform.localScale = startNativeSize;
            help.gameObject.transform.localScale = helpNativeSize;
            credits.gameObject.transform.localScale = creditsNativeSize;
            quit.gameObject.transform.localScale = quitNativeSize * 1.2f;
        }
    }

    void buttonPress()
    {
        if (selection == 1)
            StartButton.StartGame();

        else if (selection == 2)
            HelpButton.Help();

        else if (selection == 3)
            CreditButton.Credits();

        else if (selection == 4)
            QuitButton.Quit();
    }

}
