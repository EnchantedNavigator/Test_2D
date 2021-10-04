using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Screenshot
{
    private Sprite _image;
    private DateTime _creationTime;

    public Screenshot(Sprite image, DateTime creationTime)
    {
        _image = image;
        _creationTime = creationTime;
    }
    public Sprite Image => _image;
    public DateTime CreationTime => _creationTime;
    // Start is called before the first frame update

}
