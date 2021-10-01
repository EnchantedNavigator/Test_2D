using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeWayChecker : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;
    [SerializeField] private ContactFilter2D _filter;
    // Start is called before the first frame update
    private readonly RaycastHit2D[ ] _results = new RaycastHit2D[1];
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        var collisionCount = _rigidbody2D.Cast(transform.right,_filter, _results , 100);
        if (collisionCount == 0)
        {
            _rigidbody2D.velocity = transform.right * _speed;
        }
        else
            _rigidbody2D.velocity = Vector2.zero;

    }
}
