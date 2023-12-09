
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class save_variable : MonoBehaviour
{

    public TMP_InputField inputFields;
    public static string savedtext;

    private void Start()
    {
        // Subscribe to the onValueChanged event of the InputField
        inputFields.onValueChanged.AddListener(OnInputValueChanged);
    }

    private void OnInputValueChanged(string newtext)
    {
        savedtext = newtext;
        Debug.Log("Text: " + newtext);
    }

    
}