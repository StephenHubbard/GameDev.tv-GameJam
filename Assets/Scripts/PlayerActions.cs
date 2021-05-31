using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
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

    private void useAction() {
        
    }
}
