using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabManager : MonoBehaviour
{
    [SerializeField]
    private Tab[] Tabs;
    private Tab _currentTab;
    [SerializeField]
    private int _defaultTabIndex;
    private Tab _previousTab;
    private void Awake()
    {
        _currentTab = Tabs[_defaultTabIndex];
                
       foreach(Tab tab in Tabs)
        {
            tab.MyManager = this;
        }
    }
    public void TabSelected(Tab tab)
    {
        _previousTab = _currentTab;
        _currentTab = tab;
        if (_previousTab != null) { _previousTab.Hide(); }
        _currentTab.Show();
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
