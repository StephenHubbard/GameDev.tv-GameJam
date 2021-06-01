using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private Transform hitSpot;
    
    private Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        hitSpot = GameObject.Find("HitSpot").transform;
    }

    private void Start() {
        rb.velocity = hitSpot.position * speed;
    }
}
