using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class x_btn : MonoBehaviour

{
    public GameObject image;



    public void closeimage()
    {

        {
            if (image != null)

            image.SetActive(false);
        }
    }
}