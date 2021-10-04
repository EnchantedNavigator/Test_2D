using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewColorChanger : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Color _from;
    [SerializeField] private Color _to;
    // Start is called before the first frame update
    [ContextMenu("Load From Color")]
    private void LoadFromColor()
    {
        if (_image != null)
        {
            _from = _image.color;
        }
    }
    public void SetPosition(float position)
    {
        _image.color = Color.Lerp(_from,_to, position);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
