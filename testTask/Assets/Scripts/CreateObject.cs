using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] items;
    private int index;

    private void Start()
    {
        items = new GameObject[transform.childCount];
        for(int i = 0; i < transform.childCount; i++)
        {
            items[i]=transform.GetChild(i).gameObject;
        }
        foreach(GameObject item in items)
        {
            item.SetActive(false);
        }
        if (items[0])
        {
            items[0].SetActive(true);
        }
    }

    public void LeftLoad()
    {
        items[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = items.Length - 1;
        }
        items[index].SetActive(true);
    } 
    public void RightLoad()
    {
        items[index].SetActive(false);
        index++;
        if (index == items.Length) 
        {
            index = 0;
        }
        items[index].SetActive(true);
    }
}
