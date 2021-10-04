using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Path : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;
    // Start is called before the first frame update
    void Start()
    {
        Tween tween = transform.DOPath(_waypoints, 5, PathType.CatmullRom).SetOptions(true);
        tween.SetEase(Ease.Linear).SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
