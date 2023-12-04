using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class home_scene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("scene1(home)");
    }
}
