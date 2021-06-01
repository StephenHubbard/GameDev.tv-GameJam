using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField] public GameObject[] itemsArray;
    
    private PlayerControls playerControls;

    private void Awake() {
        playerControls = new PlayerControls();
    }

    private void OnEnable() {
        playerControls.Enable();
    }

    private void OnDisable() {
        playerControls.Disable();
    }

    void Start()
    {
        playerControls.Hotbar.KeySelection_1.performed += _ => ItemSlotOne();
        playerControls.Hotbar.KeySelection_2.performed += _ => ItemSlotTwo();
        playerControls.Hotbar.KeySelection_3.performed += _ => ItemSlotThree();
    }

    private void ItemSlotOne() {
        foreach (var item in itemsArray)
        {
            item.GetComponent<Outline>().enabled = false;
        }

        itemsArray[0].GetComponent<Outline>().enabled = true;
    }

    private void ItemSlotTwo() {
        foreach (var item in itemsArray)
        {
            item.GetComponent<Outline>().enabled = false;
        }

        itemsArray[1].GetComponent<Outline>().enabled = true;
    }

    private void ItemSlotThree() {
        foreach (var item in itemsArray)
        {
            item.GetComponent<Outline>().enabled = false;
        }

        itemsArray[2].GetComponent<Outline>().enabled = true;
    }
}
