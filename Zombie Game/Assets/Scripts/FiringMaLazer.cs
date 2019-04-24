using UnityEngine;

public class FiringMaLazer : MonoBehaviour
{
    public Rigidbody lazer;
    public Transform arrisa;
    private Rigidbody lazerInstance;
    public int lazerDamage = 1;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            lazerInstance = Instantiate(lazer, arrisa.position, arrisa.rotation) as Rigidbody;
            lazerInstance.AddForce(arrisa.forward * 1000);
        }

    }
}
