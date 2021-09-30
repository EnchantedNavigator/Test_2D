using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _jumpForce;
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        _rigidbody2D.AddForce(Vector2.up * _jumpForce);
        _rigidbody2D.angularVelocity = 30;
        var fadeInJob = StartCoroutine(BlockStoper(1));
    }

    private IEnumerator BlockStoper(float duration)
    {
        
        return WaitForSeconds(duration);

    }
    // Start is called before the first frame update
    void Start()
    {
        var stoping = StartCoroutine(BlockStoper(1));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
