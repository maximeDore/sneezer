using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class PlayerMovement : MonoBehaviour {

    // Handling
    [SerializeField]
    private float movementSpeed = 5f;

    // Components
    private Rigidbody2D rb;
    private Camera cam;
    private Animator anim;

    // System
    private Vector2 movement;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        anim = GetComponent<Animator>();
    }

    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Set the moving state to the animator
        anim.SetBool("isMoving", movement.x != 0 ? true : movement.y != 0 ? true : false);
    }

    void FixedUpdate() {
        // Movement
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
