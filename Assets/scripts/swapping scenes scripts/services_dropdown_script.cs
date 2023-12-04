using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class services_dropdown_script : MonoBehaviour
{
    public TextMeshProUGUI output;

    public void SwitchScene(int val)
    {
        if (val == 0)
        {
            //nothing this is the scene i am on. 
        }
        else if (val == 1)
        {
            SceneManager.LoadScene("scene3(services)"); //i want new order scene
        }
        else if (val == 2) // i want the current orders requests scene
        {
            SceneManager.LoadScene("scene3(currentservices)"); //used hardware scene if i decide to make it.
        }
    }
}