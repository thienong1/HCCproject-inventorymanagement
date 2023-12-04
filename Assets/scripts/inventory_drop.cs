using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class inventory_drop : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        drag_script draggableitem = dropped.GetComponent<drag_script>();
        draggableitem.parentAfterDrag = transform;
    }
}
