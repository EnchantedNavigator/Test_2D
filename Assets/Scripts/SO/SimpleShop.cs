using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShop : MonoBehaviour
{
    [SerializeField] private List<Goods> _goods;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var good in _goods)
        {
            good.ShowInfo();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
