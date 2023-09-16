using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] items;
    private int index;
    [SerializeField] private Text decription;
    private string path = "D:\\GitHub\\testTask\\Description.txt";
    private string path2 = "D:\\GitHub\\testTask\\Information.txt";

    private void Start()
    {
        index = PlayerPrefs.GetInt("ObjectsMenu");
        items = new GameObject[transform.childCount];
        for(int i = 0; i < transform.childCount; i++)
        {
            items[i]=transform.GetChild(i).gameObject;
        }
        foreach(GameObject item in items)
        {
            item.SetActive(false);
        }
        if (items[index])
        {
            items[index].SetActive(true);
        }
    }

    public void LeftSide()
    {
        items[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = items.Length - 1;
        }
        items[index].SetActive(true);
    } 
    public void RightSide()
    {
        items[index].SetActive(false);
        index++;
        if (index == items.Length) 
        {
            index = 0;
        }
        items[index].SetActive(true);
    }
    public void StartScene()
    {
        PlayerPrefs.SetInt("ObjectsMenu",index);
        SceneManager.LoadScene("Menu");
    }
    private void TextFile(string ppath)
    {
        try
        {
            StreamReader sr = new StreamReader(ppath);
            string[] lines = File.ReadAllLines(ppath);
            if (index==0)
            {
                decription.text = lines[lines.Length-1];
            }
            else 
            {
                decription.text = lines[index-1];
            }
            sr.Close();
        }
        catch (System.Exception e)
        {

            Debug.Log(e);
        }
    }
    public void Description()
    {
        TextFile(path);
    }
    public void Information()
    {
        TextFile(path2);
    }
}
