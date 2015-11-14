using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Hand : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    internal static object eventData;
    public Transform parentToReturn = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturn = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        this.transform.position = eventData.position;
        this.transform.SetParent(parentToReturn);

}
    public void OnDrag(PointerEventData eventData)
    {
        parentToReturn = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        this.transform.position = eventData.position;
        this.transform.SetParent(parentToReturn);
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        parentToReturn = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        this.transform.position = eventData.position;
        this.transform.SetParent(parentToReturn);
    }
}