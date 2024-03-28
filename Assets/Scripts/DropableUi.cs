using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropableUi : MonoBehaviour, IDropHandler
{

    RectTransform rect;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().position = rect.position;
        }
        // Transform data = GetComponent<RectTransform>();
    }
    private void Awake()
    {

        rect = GetComponent<RectTransform>();
    }
}
