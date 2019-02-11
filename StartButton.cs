using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public static void StartGame()
    {
        Debug.Log("The Start Button has been clicked.");
        SceneManager.LoadScene(1);
        Debug.Log("This button works.");
        //gameObject.transform.Translate(2, 2, 2);
    }
}
