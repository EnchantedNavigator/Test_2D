using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishTrigger : MonoBehaviour
{
    private EndPoint[] _points;
    // Start is called before the first frame update
    private void OnEnable()
    {
        _points = gameObject.GetComponentsInChildren<EndPoint>();

        foreach (var point in _points)
        {
            point.Reached += OnEndPointReached;
        }
        
    }
    private void OnDisable()
    {
        foreach (var point in _points)
        {
            point.Reached -= OnEndPointReached;
        }
    }
    private void OnEndPointReached()
    {
        foreach (var point in _points)
        {
            if (point.IsReached == false)
            {
                return;
            }
        }
        Debug.Log("Finish!");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
