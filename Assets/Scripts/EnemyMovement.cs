using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform player;

    private float moveSpeed = 2f;

    private void Awake() {
        player = FindObjectOfType<PlayerMovement>().gameObject.transform;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
    }
}
