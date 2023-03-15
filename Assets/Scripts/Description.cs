using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Description : UIManager
{
    // Start is called before the first frame update
    public Image BackgroundImage;
    public TextMeshProUGUI Title;
    public TextMeshProUGUI DescriptionText;
    public Button ARButton;
    public Button BackButton;
    public Button StartButton;
    public Tool currentTool;
    void Start()
    {
        BackButton.onClick.AddListener(() =>
        {
            StartParent.SetActive(true);
            MenuParent.SetActive(true);
            Destroy(gameObject);
        });
        StartButton.onClick.AddListener(() =>
        {
            StartParent.SetActive(true);
            MenuParent.SetActive(true);
            Destroy(gameObject);
        });

        ARButton.onClick.AddListener(() =>
        {
            // ARParent.SetActive(true);
            MenuParent.SetActive(false);
            StartParent.SetActive(false);
            ARParent.GetComponent<ARParent>().SetData(currentTool, gameObject);
            gameObject.SetActive(false);
        });
    }

    public void SetData(Tool tool)
    {
        BackgroundImage.sprite = Resources.Load<Sprite>("Images/Tools/" + tool.Name);
        Title.text = tool.Name;
        DescriptionText.text = tool.Description;
        currentTool = tool;
    }
}
