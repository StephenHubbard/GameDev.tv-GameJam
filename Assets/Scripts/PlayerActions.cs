using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] private Tilemap foregroundTilemap;
    [SerializeField] private Transform hitSpot;
    
    private PlayerControls playerControls;
    private Animator animator;
    private ItemManager itemManager;
    

    private void Awake() {
        playerControls = new PlayerControls();
        animator = GetComponent<Animator>();
        itemManager = FindObjectOfType<ItemManager>();
    }

    private void OnEnable() {
        playerControls.Enable();
    }

    private void OnDisable() {
        playerControls.Disable();
    }

    void Start()
    {
        playerControls.PlayerActions.Action.performed += _ => UseActiveItem();
        playerControls.PlayerActions.Action.canceled += _ => CancelActiveItem();
    }

    void Update()
    {
        
    }

    private bool IsTile() {
        Vector3Int gridPosition = foregroundTilemap.WorldToCell((Vector3)hitSpot.position);
        if (foregroundTilemap.HasTile(gridPosition)) {
            return true;
        }
        else {
            return false;
        }
    }

    private void UseActiveItem() {
        if (itemManager.itemsArray[0].GetComponent<Outline>().isActiveAndEnabled) {
            animator.SetBool("Swinging", true);
        }
    }

    private void CancelActiveItem() {
        animator.SetBool("Swinging", false);
    }

    private void HitPickaxeEvent() {
        if (IsTile()) {
            Vector3Int gridPosition = foregroundTilemap.WorldToCell((Vector3)hitSpot.position);
            foregroundTilemap.SetTile(gridPosition, null);
        }
    }
}
