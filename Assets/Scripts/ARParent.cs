using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARParent : UIManager
{
    // Start is called before the first frame update
    public List<Transform> models;
    public Tool currentTool;
    public Button BackButton;
    public GameObject Description;
    void Start()
    {
        BackButton.onClick.AddListener(() =>
        {
            for (int i = 0; i < ImageTarget.transform.childCount; i++)
            {
                ImageTarget.transform.GetChild(i).gameObject.SetActive(false);
            }

            Description.SetActive(true);

            // gameObject.SetActive(false);
        });
        // Debug.Log("length " + Models.Count);
        // foreach (GameObject m in Models)
        // {
        //     GameObject model = gameObject;
        //     model = Instantiate(m);
        //     model.transform.SetParent(ARCamera.transform, false);
        //     model.SetActive(true);
        // }


    }

    public void SetData(Tool tool, GameObject description)
    {
        currentTool = tool;
        Description = description;
    }

    public void TurnOnModel()
    {
        for (int i = 0; i < ImageTarget.transform.childCount; i++)
        {
            Debug.Log(ImageTarget.transform.GetChild(i).name + " == " + currentTool.Name);
            ImageTarget.transform.GetChild(i).gameObject.SetActive(false);
            if (ImageTarget.transform.GetChild(i).name.Contains(currentTool.Name))
            {
                ImageTarget.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }

    public void TurnOffModel()
    {
        Debug.Log("Lost model");
    }
}
