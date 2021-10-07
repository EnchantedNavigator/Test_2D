using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class TowerBuilder : MonoBehaviour, ISceneLoadHandler<LevelConfig>
{
    public void OnSceneLoaded(LevelConfig argument)
    {
        Debug.Log(argument.TowerSize);
    }
}
