using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpExample : MonoBehaviour
{
    [SerializeField] private Transform _a;
    [SerializeField] private Transform _b;
    [SerializeField] private Transform _target;
    [SerializeField] private float _pathtime; 
    [SerializeField] private float _pathRunningTime;
    // Start is called before the first frame update
    public void SetNormalizedPosition(float position)
    {
        _target.position = Vector3.Lerp(_a.position, _b.position, position);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        _pathRunningTime += Time.deltaTime;
        _target.position = Vector3.Lerp(_a.position, _b.position, _pathRunningTime/ _pathtime);
    }
}
