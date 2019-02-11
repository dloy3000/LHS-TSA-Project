using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditButton : MonoBehaviour
{
    public static void Credits()
    {
        Debug.Log("The Credits Button has been clicked.");
        SceneManager.LoadScene(4);
        Debug.Log("This button works.");
    }
}
