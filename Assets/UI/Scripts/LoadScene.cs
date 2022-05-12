﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public string sceneName;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(loadScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void loadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
