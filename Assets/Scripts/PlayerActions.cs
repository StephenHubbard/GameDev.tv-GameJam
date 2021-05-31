using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] private Tilemap foregroundTilemap;
    [SerializeField] private Transform hitSpot;
    
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
        playerControls.PlayerActions.Action.performed += _ => useAction();
    }

    void Update()
    {
        
    }

    private bool isTile() {
        Vector3Int gridPosition = foregroundTilemap.WorldToCell((Vector3)hitSpot.position);
        if (foregroundTilemap.HasTile(gridPosition)) {
            return true;
        }
        else {
            return false;
        }
    }

    private void useAction() {
        if (isTile()) {
            Vector3Int gridPosition = foregroundTilemap.WorldToCell((Vector3)hitSpot.position);
            foregroundTilemap.SetTile(gridPosition, null);
        }
    }
}
