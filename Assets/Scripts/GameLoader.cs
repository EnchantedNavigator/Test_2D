using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class GameLoader : MonoBehaviour
{
    [SerializeField] private LevelConfig _levelConfig;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Scene1.Load(_levelConfig);
        }
    }
}
