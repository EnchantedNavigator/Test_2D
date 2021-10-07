using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Abillities/Actions/Damage")]
public class AbillityActionDamage : AbillityAction
{
    [SerializeField] private float _damage;
    public override void Action(Unit target)
    {
        
    }
}
