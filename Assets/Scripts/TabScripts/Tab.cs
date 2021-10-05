using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tab : MonoBehaviour
{
    [SerializeField]
    private Button MyButton;
    [SerializeField]
    private GameObject MyPannel;
    
    public  TabManager MyManager;
    public void Show()
    {
        MyPannel.SetActive(true);
        MyButton.image.color = Color.green;
    }
    public void Hide()
    {
        MyPannel.SetActive(false);
        MyButton.image.color = Color.gray;
    }
    public void Select()
    {

        MyManager.TabSelected(this);
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
