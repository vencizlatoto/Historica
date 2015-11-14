using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Lost : MonoBehaviour, IPointerEnterHandler, IDropHandler, IPointerExitHandler
{


    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        Application.LoadLevel("Lost");


    }
    public void OnPointerExit(PointerEventData eventData)
    {


    }

}
