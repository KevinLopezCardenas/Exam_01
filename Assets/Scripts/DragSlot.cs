using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;

    // Start is called before the first frame update
    void Start()
    {

    } 

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
        if (!item)
        {
            item = DragHandler.itemDragging; 
            item.transform.SetParent(transform); // se asigna un parent diferente, viene siendo el slot 
            item.transform.position = transform.position;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
            Debug.Log("item = null");

        }
    }
}
