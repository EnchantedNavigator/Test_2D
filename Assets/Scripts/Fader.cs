using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    [SerializeField] private Image _image;
    // Start is called before the first frame update


    private IEnumerator FadeIn(float duration)
    {
        var color = _image.color;
        for (int i = 0; i < 255; i++)
        {
            color.a = 1f - (1f / 255f * i);
            _image.color = color;

            yield return null;
           
        }
    }
    private void Start()
    {
        var fadeInJob = StartCoroutine(FadeIn(1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
