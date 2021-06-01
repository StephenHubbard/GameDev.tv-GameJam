using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField] public GameObject[] itemsArray;
    [SerializeField] private Sprite[] itemSprites;
    [SerializeField] private GameObject activeSprite;
    
    private PlayerControls playerControls;

    private Vector2 pickAxeTransform = new Vector2(.41f, .1799998f);
    private Vector2 torchTransform = new Vector2(.49f, -0.02f);
    private Vector2 gunTransform = new Vector2(0.7f, -0.09f);

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

        ItemSlotOne();
    }

    private void ItemSlotOne() {
        foreach (var item in itemsArray)
        {
            item.GetComponent<Outline>().enabled = false;
        }

        itemsArray[0].GetComponent<Outline>().enabled = true;
        activeSprite.GetComponent<SpriteRenderer>().sprite = itemSprites[0];
        activeSprite.transform.localPosition = pickAxeTransform;
    }

    private void ItemSlotTwo() {
        foreach (var item in itemsArray)
        {
            item.GetComponent<Outline>().enabled = false;
        }

        itemsArray[1].GetComponent<Outline>().enabled = true;
        activeSprite.GetComponent<SpriteRenderer>().sprite = itemSprites[1];
        activeSprite.transform.localPosition = torchTransform;
    }

    private void ItemSlotThree() {
        foreach (var item in itemsArray)
        {
            item.GetComponent<Outline>().enabled = false;
        }

        itemsArray[2].GetComponent<Outline>().enabled = true;
        activeSprite.GetComponent<SpriteRenderer>().sprite = itemSprites[2];
        activeSprite.transform.localPosition = gunTransform;
    }
}
