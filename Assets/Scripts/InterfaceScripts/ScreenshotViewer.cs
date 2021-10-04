using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScreenshotViewer : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler
{
    [SerializeField] private Image _image;
    [SerializeField] private Text _date;
    private Transform _dragingParent;
    private Transform _previousParent;

    public void Init(Transform dragingParent)
    {
        //transform.SetParent(dragingParent,false);
        _dragingParent = dragingParent;
        
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        _previousParent = transform.parent;
        transform.SetParent(_dragingParent,false);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(_previousParent, false);
    }

    public void Render(Screenshot screenshot)
    {
        _image.sprite = screenshot.Image;
        _date.text = screenshot.CreationTime.ToString();
    }

   
}
