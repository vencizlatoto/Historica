using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IPointerEnterHandler, IDropHandler, IPointerExitHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
       
    }
    public void OnDrop (PointerEventData eventData)
    {
        string[] zones = new string[5] { "вп1", "вп2", "вп3", "вп4", "вп5" };
        int random = Random.Range(0, 5);
        Application.LoadLevel(zones[random]);


    }
    public void OnPointerExit(PointerEventData eventData)
    {
      

    }

}
