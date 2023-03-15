using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartParent : UIManager
{
    public Button Menu;
    void Start()
    {
        Menu.onClick.AddListener(() => {
            MenuParent.SetActive(true);
        });
    }
}
