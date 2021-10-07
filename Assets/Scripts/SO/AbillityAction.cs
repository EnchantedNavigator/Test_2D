using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbillityAction : ScriptableObject
{
    public abstract void Action(Unit target);
}
