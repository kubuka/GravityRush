using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoom : MonoBehaviour
{
    public List<GameObject> pokoje = new List<GameObject>();
    public Transform placeToSpawn;
    RoomCounter rc;
    Vector2 spawnVector;
    int randomRoom = 0;
    bool spawned = false;

    void Start()
    {
        rc = FindObjectOfType<RoomCounter>();
        spawnVector = new Vector2(placeToSpawn.position.x, placeToSpawn.position.y);
    }

    private void Update()
    {
        if (rc.existingRooms <= 4 && !spawned)
        {
            spawned = true;
            randomRoom = Random.Range(0, pokoje.Count);
            var newRoom = Instantiate(pokoje[randomRoom], spawnVector, Quaternion.identity) as GameObject;
            rc.existingRooms++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerDestroyer")
        {
            rc.existingRooms -= 1;
            Destroy(gameObject);           
        }
    }

}
