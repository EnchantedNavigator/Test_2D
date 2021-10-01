using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;
    // Start is called before the first frame update
    void Start()
    {
        _text1.DOText("Text Changed", 3);
        _text2.DOText("added to Text", 3).SetRelative();
        _text3.DOText("Text Hacked", 3,true,ScrambleMode.All);
        _text3.DOColor(Color.red,3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
