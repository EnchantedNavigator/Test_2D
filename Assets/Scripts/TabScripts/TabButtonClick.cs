using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabButtonClick : MonoBehaviour
{
    public Button[] OtherButtons;
    public GameObject[] OtherPannels;
    public GameObject MyPannel;
    public Button MyButton;
    public void OnButtonClicked()
    {
        MyPannel.SetActive(true);
        MyButton.image.color = Color.green;
        foreach(GameObject pannel in OtherPannels)
        {
            pannel.SetActive(false);
        }
        foreach (Button button in OtherButtons)
        {
            button.image.color = Color.gray;
        }


        //Text.SetActive(state);
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
