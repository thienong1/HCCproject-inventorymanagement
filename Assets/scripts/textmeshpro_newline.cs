using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class textmeshpro_newline : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text outputText;

    private int currentLine = 0;
    private const int maxLines = 15;

    private void Start()
    {
        if (inputField != null)
        {
            inputField.onSubmit.AddListener(OnSubmit);
            inputField.onValueChanged.AddListener(OnValueChanged);
        }
    }

    private void OnSubmit(string text)
    {
        if (outputText != null)
        {
            if (currentLine < maxLines)
            {
                outputText.text += text + "\n";
                currentLine++;
            }
            else
            {
                // Remove the oldest line if the maximum number of lines is reached
                int firstNewLineIndex = outputText.text.IndexOf('\n');
                outputText.text = outputText.text.Substring(firstNewLineIndex + 1) + text + "\n";
            }

            inputField.text = "";
        }
    }

    private void OnValueChanged(string text)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Scroll up through lines if possible
            currentLine = Mathf.Max(0, currentLine - 1);
            DisplayCurrentLine();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Scroll down through lines if possible
            currentLine = Mathf.Min(maxLines - 1, currentLine + 1);
            DisplayCurrentLine();
        }
    }

    private void DisplayCurrentLine()
    {
        // Display the current line in the input field
        string[] lines = outputText.text.Split('\n');
        inputField.text = lines[Mathf.Max(0, lines.Length - currentLine - 1)];
    }
}