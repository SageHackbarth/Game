using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovemovement : MonoBehaviour
{
    public float speed = 6f;

    private Vector3 movement;
    private Animator anim;
    private Rigidbody playeRigidbody;
    private int floorMask;
    private float camRayLength = 100f;
    private GameObject exitLevel;

    void Awake()
    {
        floorMask = LayerMask.GetMask("Floor");
        anim = GetComponent<Animator>();
        playeRigidbody = GetComponent<Rigidbody>();
        exitLevel = GameObject.FindGameObjectWithTag("Finish");
    }


    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Move(h, v);
        Turning();
        Animating(h, v);

    }

    void Move(float h, float v)
    {
        movement.Set(h,0f,v);
        movement = movement.normalized * speed * Time.deltaTime;

        playeRigidbody.MovePosition(transform.position + movement);
    }

    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;

        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            playeRigidbody.MoveRotation(newRotation);
        }
    }

    void Animating(float h, float v)
    {
        bool walking = h != 0f || v != 0f;
        anim.SetBool("IsWalking", walking);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == exitLevel)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
