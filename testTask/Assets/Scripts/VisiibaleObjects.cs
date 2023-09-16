using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class VisiibaleObjects : MonoBehaviour
{
    [SerializeField] private GameObject items;
    [SerializeField] private GameObject description;
    [SerializeField] private GameObject info;
    private static bool isActive = false;
    private void Start()
    {
        items.SetActive(isActive);
        description.GetComponent<Button>().interactable = isActive;
        info.GetComponent<Button>().interactable = isActive;
    }
    public void TurnOn()
    {
        isActive=true;
        items.SetActive(isActive);
    }
}
