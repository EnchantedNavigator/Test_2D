using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
        Debug.DrawRay(transform.position, transform.right * 1000, Color.red);
        if (hit)
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
