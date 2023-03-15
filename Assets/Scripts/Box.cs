using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Box : UIManager
{
    public Image BackgroundImage;
    public TextMeshProUGUI Title;
    public Button MainButton;
    public Tool Tool;
    private GameObject newScreen;
    public GameObject model;

    private void Start()
    {
        MainButton.onClick.AddListener(() =>
        {
            newScreen = gameObject;
            CurrentCanvas = GameObject.Find("Canvas").GetComponent<Canvas>().gameObject;
            newScreen = Instantiate(PrefabDescription);
            newScreen.SetActive(true);
            newScreen.GetComponent<Description>().SetData(Tool);
            newScreen.transform.SetParent(CurrentCanvas.transform, false);
        });
    }

    public void SetData(Tool tool)
    {
        Tool = tool;
        BackgroundImage.sprite = Resources.Load<Sprite>("Images/Tools/" + tool.Name);
        Title.text = tool.Name;
        model = Resources.Load<GameObject>("Prefabs/" + tool.Name);


        GameObject m = Instantiate(model);
        m.transform.SetParent(ImageTarget.transform, false);
        m.SetActive(false);
    }
}
