using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public new Rigidbody2D rigidbody;
    public Vector2 movement;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("movement.x", movement.x);
        animator.SetFloat("movement.y", movement.y);
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}

