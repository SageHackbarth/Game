using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public Rigidbody PlayerRigidbody;

    void Awake()
    {
        Instantiate(PlayerRigidbody, transform);
    }
}
