using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputToText : MonoBehaviour
{
    public TMP_Text Text;
    // Start is called before the first frame update
    public void ToText(string str)
    {
        Text.text = str;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
