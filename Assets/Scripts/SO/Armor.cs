using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Armor", menuName = "Shop/Armor", order = 51)]
public class Armor : Goods
{
    [SerializeField] private int _protection;
    public override void ShowInfo()
    {
        Debug.Log($"Броня - {Label}, это {Description}, стоит{Price}, защита - {_protection}");
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
