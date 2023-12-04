using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tab_opener : MonoBehaviour
{
    public GameObject MMenuTab;
    public Image MMTabImage;
    public Transform open;
    public Transform closed;
    public MMTabState state;
    public int MMTabIndexCall = 0;

    public enum MMTabState
    {
        closed,
        top,
        bottom
    }

    private void Start()
    {
        MMTabImage = transform.parent.GetComponent<Image>();
    }

    private void Update()
    {
        MMTabIndexCall = transform.parent.GetSiblingIndex();

        int MMTabQuantity = transform.parent.parent.childCount;

        if (state != MMTabState.closed)
        {
            if (MMTabIndexCall != MMTabQuantity - 1)
            {
                state = MMTabState.bottom;
                MMTabImage.color = new Color32(200, 200, 200, 255);
            }

            else if (MMTabIndexCall == MMTabQuantity - 1)
            {
                state = MMTabState.top;
                MMTabImage.color = new Color32(255, 255, 255, 255);
            }
        }

        if (state == MMTabState.closed)
        {
            if (MMTabQuantity < 5)
            {
                MMTabImage.color = new Color32(255, 255, 255, 150);
            }

            else if (MMTabQuantity == 5)
            {
                MMTabImage.color = new Color32(255, 255, 255, 255);
            }
        }
    }

    public void OpenMenuTabs()
    {

        if (MMenuTab != null)
        {
            if (state == MMTabState.closed)
            {
                Animator animator = MMenuTab.GetComponent<Animator>();
                if (animator != null)
                {

                    bool isOpen = animator.GetBool("open");

                    animator.SetBool("open", !isOpen);
                }
                state = MMTabState.top;
                MMenuTab.transform.SetParent(open);
                transform.parent.SetSiblingIndex(4);
            }

            else if (state == MMTabState.top)
            {
                Animator animator = MMenuTab.GetComponent<Animator>();
                if (animator != null)
                {

                    bool isOpen = animator.GetBool("open");

                    animator.SetBool("open", !isOpen);
                }
                state = MMTabState.closed;
                MMenuTab.transform.SetParent(closed);
                transform.parent.SetSiblingIndex(0);
            }

            else if (state == MMTabState.bottom)
            {
                state = MMTabState.top;
                transform.parent.SetSiblingIndex(4);
            }

        }
    }

}
