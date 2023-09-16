using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    private int index;
    private void Start()
    {
        index = PlayerPrefs.GetInt("Menu");
    }
    public void StartScene()
    {
        PlayerPrefs.SetInt("Menu", index);
        SceneManager.LoadScene("ObjectsMenu");
    }
}
