using UnityEngine;
using UnityEngine.UI;
public class toggle_object : MonoBehaviour
{
    public Image imagefield1;
    public Image imagefield2;
    public Image imagefield3;
    public int click_number = 0;

    public void clicks()
    {
        click_number++;
    }


    public void ToggleImage()
    {
        if (click_number == 0)
        {
            bool isActive = imagefield1.gameObject.activeSelf;

            imagefield1.gameObject.SetActive(!isActive);
        }

        if (click_number == 1)
        {
            bool isActive = imagefield2.gameObject.activeSelf;

            imagefield2.gameObject.SetActive(!isActive);
        }

        if (click_number == 2)
        {
            bool isActive = imagefield3.gameObject.activeSelf;

            imagefield3.gameObject.SetActive(!isActive);
        }

        
    }
}
