using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] GameObject spawn;
    [SerializeField] GameObject player;
    Skrol sk;

    private void Start()
    {
        sk = FindObjectOfType<Skrol>();
    }

    public void Spawn()
    {
        var playerS = Instantiate(player, new Vector2(spawn.transform.position.x, spawn.transform.position.y), Quaternion.identity);
        sk.startTime = Time.time;
        sk.canMove = true;
    }
}
