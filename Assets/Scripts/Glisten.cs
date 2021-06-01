using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Glisten : MonoBehaviour
{
    [SerializeField] private GameObject flowerPrefab;
    [SerializeField] private GameObject enemyPrefab;

    private Tilemap foregroundTilemap;

    private void Awake() {
        foregroundTilemap = GameObject.Find("Foreground").GetComponent<Tilemap>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Torch")) {
            int randomNum = Random.Range(1, 3);

            if (randomNum == 1) {
                Instantiate(flowerPrefab, transform.position, transform.rotation);
            }
            else if (randomNum == 2) {
                Instantiate(enemyPrefab, transform.position, transform.rotation);
            }

            // Vector3Int gridPosition = foregroundTilemap.WorldToCell((Vector3)transform.position);
            // if (foregroundTilemap.HasTile(gridPosition)) {
            //     foregroundTilemap.SetTile(gridPosition, null);
            // }

            Destroy(transform.gameObject);
        }
    }
}
