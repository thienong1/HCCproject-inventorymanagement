using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logout_changescene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("openingScene");
    }
}
