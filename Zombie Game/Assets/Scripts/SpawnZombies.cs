using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombies : MonoBehaviour
{
    public Rigidbody zombieBio;
    public Rigidbody player;
    public Transform environment;

    void Awake()
    {
        Instantiate(player, transform);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(environment);
            Instantiate(zombieBio);
        }
    }
    
}
