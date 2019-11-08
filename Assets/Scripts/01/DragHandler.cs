using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public GameObject ItemDragging; // almacena el item que se esta arrastrando

    Vector3 startPositionItem; //almacena la posisicion inicial del item.
    Transform starParent; // almacena posision de 
    Transform dragParent;
    public static GameObject itemDragging;



    // Start is called before the first frame update
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("dragParent").transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BeginDrag");
        itemDragging = gameObject;

        //guarda la posision inicial del objero que se arrastra
        startPositionItem = transform.position;
        starParent = transform.parent; 
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
        ItemDragging = null;

        if (transform.parent == dragParent)
        {
            transform.position = startPositionItem;
            transform.SetParent(dragParent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
