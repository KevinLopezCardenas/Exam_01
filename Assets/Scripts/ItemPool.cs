using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPool : MonoBehaviour , IDropHandler
{
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        DragHandler.itemDragging.transform.SetParent(transform);
    }
    }
