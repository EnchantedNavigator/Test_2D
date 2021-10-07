using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Abillities/New Abillity")]
public class Abillity : ScriptableObject
{
    [SerializeField] private AbillytyLogic _logic;
    [SerializeField] private List<AbillityAction> _abillityAction;
    public void ApplyAction(List<Unit> targets)
    {
        foreach (var action in _abillityAction)
        {
            foreach(var target in targets)
            {
                action.Action(target);
            }
        }
    }
    public List<Unit> SelectTargets(Vector2 screenPoint)
    {
        return _logic.TryGetTargets(screenPoint);
    }
}
  