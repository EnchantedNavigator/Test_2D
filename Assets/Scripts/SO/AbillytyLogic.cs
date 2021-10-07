using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbillytyLogic : ScriptableObject
{
    public abstract List<Unit> TryGetTargets(Vector2 screenPoint);
}