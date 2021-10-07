using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="LevelConfig",menuName ="Create Level Config")]
public class LevelConfig : ScriptableObject
{
    [SerializeField] private int _towerSize;

    public int TowerSize => _towerSize;
}
