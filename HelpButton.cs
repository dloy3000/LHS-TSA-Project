using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HelpButton : MonoBehaviour
{
    public static void Help()
    {
        Debug.Log("The Help Button has been clicked.");
        SceneManager.LoadScene(3);
        Debug.Log("This button works.");
    }
}
