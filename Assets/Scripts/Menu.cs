using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : UIManager
{
    public Image BackgroundImage;
    public TextMeshProUGUI Title;
    public TextMeshProUGUI Description;
    public Button MainButton;
    public Button BackButton;

    private void Start()
    {
        string filename = "tools.json";
        ToolResult tools = Utilities.ImportJson<ToolResult>(filename);
        // Debug.Log(tools.Count);
        foreach (Tool t in tools.Data)
        {
            Debug.Log(t.Name);
            GameObject newBox = gameObject;
            CurrentCanvas = MenuParent.transform.GetChild(0).gameObject;
            newBox = Instantiate(PrefabBox);
            newBox.transform.SetParent(CurrentCanvas.transform, false);
            newBox.GetComponent<Box>().SetData(t);
            newBox.SetActive(true);
        }
        BackButton.onClick.AddListener(() => {
            StartParent.SetActive(true);
            MenuParent.SetActive(false);
        });
        // List<Tool> tools = JsonSerializer.Deserialize<List<Tool>>("" + filename);
    }
}
