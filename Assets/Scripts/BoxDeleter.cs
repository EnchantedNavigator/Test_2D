using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDeleter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("ToDelete");
        foreach (var box in boxes)
        {
            box.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
