using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(new Vector2(-200,50),3).SetDelay(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
