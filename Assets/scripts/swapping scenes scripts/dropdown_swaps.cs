using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class dropdown_swaps : MonoBehaviour
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
            SceneManager.LoadScene("scene2(inventory)"); //i want product scene
        }
        //else if (val == 2)
        //{
        //    SceneManager.LoadScene("Scene"); //used hardware scene if i decide to make it.
        //}
    }
}