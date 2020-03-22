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

    // System
    Vector2 movement;
    Vector2 mousePos;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate() {
        // Movement
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);

        Vector2 orientation = mousePos - rb.position;

        float angle = Mathf.Atan2(orientation.y, orientation.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = angle;
    }
}
