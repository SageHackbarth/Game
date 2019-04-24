using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomHealth : MonoBehaviour
{
    public int startingHealth = 5;
    private int currentHealth;
    public Rigidbody lazer;
    public int lazerDam = 1;

    private SphereCollider sphereCollider;
    // Start is called before the first frame update
    void Awake()
    {
        sphereCollider = GetComponent<SphereCollider>();
        lazer = GetComponent<Rigidbody>();

        currentHealth = startingHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == lazer)
        {
            TakeDamage(lazerDam);
        }
    }
}
