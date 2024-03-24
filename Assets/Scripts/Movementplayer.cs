using UnityEngine;

public class Movementplayer : MonoBehaviour
{
    private float move = 0f;
    public float speed;
    private Rigidbody2D rib;
    public float JumpSpeed;
    public Vector3 Reposition;
    public RepositionDelay rd;
    public GameObject Bulletmove;
    Vector2 bullpos;
    public float firerate = 0.5f;
    float nextfire = 0.0f;
    public static bool forward = true;

    // Start is called before the first frame update
    void Start()
    {
        rib = GetComponent<Rigidbody2D>();
        Reposition = transform.position;
        rd = FindObjectOfType<RepositionDelay>();
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_ANDROID
        // Handle touch input for movement
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                move = Mathf.Sign(touch.deltaPosition.x);
            }
            else
            {
                move = 0f;
            }
        }
        else
        {
            move = 0f;
        }

        // Handle touch input for jump
        if (Input.touchCount > 1)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    sounds.Playsound("jump");
                    rib.velocity = new Vector2(rib.velocity.x, JumpSpeed);
                }
            }
        }
#else
        // Handle keyboard input for movement
        move = Input.GetAxis("Horizontal");

        // Handle keyboard input for jump
        if (Input.GetButtonDown("Jump"))
        {
            sounds.Playsound("jump");
            rib.velocity = new Vector2(rib.velocity.x, JumpSpeed);
        }
#endif

        // Handle firing input
        if (Input.GetButtonDown("Fire1") && Time.time > nextfire)
        {
            nextfire = Time.time + firerate;
            Fire();
        }

        // Apply movement
        if (move > 0f)
        {
            rib.velocity = new Vector2(move * speed, rib.velocity.y);
            transform.localScale = new Vector2(1.09099f, 1f);
            forward = true;
        }
        else if (move < 0f)
        {
            rib.velocity = new Vector2(move * speed, rib.velocity.y);
            transform.localScale = new Vector2(-1.09099f, 1f);
            forward = false;
        }
        else
        {
            rib.velocity = new Vector2(0, rib.velocity.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check collision with checkpoint and fall detector
        if (collision.tag == "Checkpoint")
        {
            Reposition = collision.transform.position;
        }
        if (collision.tag == "FallDetector")
        {
            rd.Delay();
        }
    }

    void Fire()
    {
        // Fire a bullet based on player's facing direction
        if (forward)
        {
            bullpos = new Vector2(transform.position.x + 0.3f, transform.position.y + 0.2f);
            bullpos += new Vector2(1f, -0.43f);
            Instantiate(Bulletmove, bullpos, Quaternion.identity);
        }
        else
        {
            bullpos = new Vector2(transform.position.x - 0.3f, transform.position.y + 0.2f);
            bullpos -= new Vector2(1f, +0.43f);
            Instantiate(Bulletmove, bullpos, Quaternion.identity);
        }
    }
}
