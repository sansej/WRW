using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comon : MonoBehaviour
{
    [SerializeField] private float Speed = 3f;
    [SerializeField] int Lives = 5;
    [SerializeField] private float JumpForce = 15f;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetButton("Horizontal"))
            Run();
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis ("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, Speed * Time.deltaTime);
    }
}
