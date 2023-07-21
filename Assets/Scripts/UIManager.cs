using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject PrefabBox;
    public GameObject PrefabDescription;
    public GameObject CurrentCanvas;
    public GameObject StartParent;
    public GameObject MenuParent;
    public GameObject ARParent;
    public GameObject ARCamera;
    public GameObject ImageTarget;
    public TextAsset toolsData;
    private void Awake()
    {
        PrefabBox = Resources.Load<GameObject>("Prefabs/Box");
        PrefabDescription = Resources.Load<GameObject>("Prefabs/Description");
        CurrentCanvas = GameObject.Find("Canvas").GetComponent<Canvas>().gameObject;
        StartParent = GameObject.Find("Start");
        MenuParent = GameObject.Find("Menu");
        ARParent = GameObject.Find("AR");
        ARCamera = GameObject.Find("ARCamera");
        ImageTarget = GameObject.Find("ImageTarget");
        toolsData = Resources.Load<TextAsset>("Data/tools");
        // Debug.Log(Resources.)
    }

    private void Start() {
        StartParent.SetActive(true);
        MenuParent.SetActive(false);
        // ARParent.SetActive(false);
    }

}
