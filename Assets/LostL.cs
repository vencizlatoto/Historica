﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class LostL : MonoBehaviour, IPointerEnterHandler, IDropHandler, IPointerExitHandler
{


    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        Application.LoadLevel("Main");


    }
    public void OnPointerExit(PointerEventData eventData)
    {


    }

}
