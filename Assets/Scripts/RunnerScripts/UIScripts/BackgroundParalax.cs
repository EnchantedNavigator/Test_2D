using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class BackgroundParalax : MonoBehaviour
{
    [SerializeField] private float _speed;
    private RawImage _image;
    private float _imagePositionX;
    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<RawImage>();
        _imagePositionX = _image.uvRect.x;
    }

    // Update is called once per frame
    void Update()
    {
        _imagePositionX += _speed * Time.deltaTime;
        if (_imagePositionX > 1)
            _imagePositionX = 0;

        _image.uvRect = new Rect(_imagePositionX,0,_image.uvRect.width,_image.uvRect.height);
    }
}
