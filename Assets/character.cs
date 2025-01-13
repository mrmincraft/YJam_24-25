using UnityEngine;

public class Character : MonoBehaviour


{

    public float Movspeed = 5.0f;
    float speedx, speedy;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        speedx = Input.GetAxis("Horizontal") * Movspeed;
        speedy = Input.GetAxis("Vertical") * Movspeed;
        rb.linearVelocity = new Vector2(speedx, speedy);


    }
}