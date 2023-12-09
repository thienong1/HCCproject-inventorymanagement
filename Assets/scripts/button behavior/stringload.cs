using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class stringload : MonoBehaviour
{
    public TMP_Text textBox;

    private void Start()
    {
        // Subscribe to the onValueChanged event of the InputField
        textBox.SetText(save_variable.savedtext);
    }

}
