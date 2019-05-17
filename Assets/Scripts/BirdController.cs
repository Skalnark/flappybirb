using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public int points = 0;
    public TextMesh scoreHolder;

    private Rigidbody2D rb;
    private int hiscore = 0;

    [SerializeField]
    private float force = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);

        scoreHolder.text = points + " pts";

        if (transform.position.y < -4.7 || transform.position.y > 4.7)
            lose();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        lose();
    }

    private void lose()
    {
        points = 0;
        transform.position = Vector2.zero;
        PipeGenerator.Reset();
        rb.velocity = Vector2.zero;
    }
}
