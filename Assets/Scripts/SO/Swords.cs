using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Sword",menuName ="Shop/Sword",order =51)]
public class Swords : Goods
{
    [SerializeField] private int _damage;
    public override void ShowInfo()
    {
        Debug.Log($"Меч - {Label}, это {Description}, стоит{Price}, урон - {_damage}");
    }

    
}
