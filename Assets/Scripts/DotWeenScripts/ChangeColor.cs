using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOFade(0, 1).SetLoops(-1,LoopType.Yoyo);
        _spriteRenderer.DOColor(Color.red, 2).SetLoops(-1,LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
