using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] items;

    private void Start()
    {
        for (int i = 0; i < items.Length; i++) 
        { 
            Debug.Log("Îáúåêòû"+ items[i].name); 
        }
        

    }
}
