using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownToText : MonoBehaviour
{
    public TMP_Text Text;
    public TMP_Dropdown Dropdown;
        
    public void DropdownToText(int num)
    {
        Text.text = Dropdown.options[num].text;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
