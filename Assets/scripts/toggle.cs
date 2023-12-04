using UnityEngine;
using TMPro;

public class toggle : MonoBehaviour
{
    public TMP_InputField inputfield1; 

    public void OpenPanel()
    {
        if (inputfield1 != null)
        {
            bool isActive = inputfield1.gameObject.activeSelf;

            inputfield1.gameObject.SetActive(!isActive);
    
        }
    }
}
