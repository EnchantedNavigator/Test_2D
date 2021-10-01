using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Vector2 _jumpVector;
    [SerializeField] private float _jumpForce;
    [SerializeField] private bool _isStoping;
    [SerializeField] private float _stopTime;
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        _rigidbody2D.AddForce(_jumpVector * _jumpForce);
        _rigidbody2D.angularVelocity = 30;
        if (_isStoping == true)
        {
            var stoping = StartCoroutine(BlockStoper(_stopTime));
        }
        _rigidbody2D.isKinematic = false;
        //var fadeInJob = StartCoroutine(BlockStoper(1));
    }

    private IEnumerator BlockStoper(float duration)
    {

        yield return new WaitForSeconds(duration);
        _rigidbody2D.isKinematic = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
