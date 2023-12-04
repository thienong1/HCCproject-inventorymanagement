using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class dropdown_hyperlinks : MonoBehaviour
{

    public TextMeshProUGUI output;

    public void HandleInputData(int val)
    {
        if (val == 1)
        {
            Application.OpenURL("https://www.amazon.com/blackfriday/?tag=admarketus-20&ref=pd_sl_e9d2329d488c3311777372456d51537681049f85305540b2149a5a15&mfadid=adm");
        }
        if (val == 2)
        {
            Application.OpenURL("https://www.ebay.com");
        }

        if (val == 4)
        {
            Application.OpenURL("https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf");
        }
    }
}
