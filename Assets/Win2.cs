using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Win2 : MonoBehaviour, IPointerEnterHandler, IDropHandler, IPointerExitHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        Application.LoadLevel("Win");


    }
    public void OnPointerExit(PointerEventData eventData)
    {


    }

}
