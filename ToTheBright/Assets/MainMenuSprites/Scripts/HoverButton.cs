using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject PlayButton;
    public GameObject OptionButton;
    public GameObject ExitButton;

    public RectTransform Button;

    void Start()
    {
        Button.GetComponent<Animator>().Play("HoverOff");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("HoverOn");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("HoverOff");
    }
}
