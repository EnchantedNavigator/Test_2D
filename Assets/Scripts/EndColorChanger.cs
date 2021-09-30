using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndColorChanger : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _tagetColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Change()
    {
        _renderer.color = _tagetColor;
    }
}
