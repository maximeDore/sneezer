using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Handling
    public float walkSpeed = 5f;
    public float runSpeed = 8f;

    // Components
    private Rigidbody2D rb;
    private Camera cam;
    private AttackController ac;
    private Animator anim;

    // System
    private Vector2 mousePos;
    private float angle;


    // Methods
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        ac = GetComponentInChildren<AttackController>();
        cam = Camera.main;
        anim = GetComponent<Animator>();
    }

    private void Update() {
        // Get mouse position
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition).normalized;

        // Set the Animator's properties for orientation sprite animations
        anim.SetFloat("horizontal", mousePos.x);
        anim.SetFloat("vertical", mousePos.y);


    }

    private void FixedUpdate() {
        // Determine the angle from the player to the mouse position
        Vector2 orientation = mousePos - rb.position;
        angle = Mathf.Atan2(orientation.y, orientation.x) * Mathf.Rad2Deg - 90f;
        // Send the angle to the Attack controller for attack direction
        ac.Rotation = angle;
    }
    












    // Reference stuff, trash

    // // Start is called before the first frame update
    // void Start() {
    //     rb = GetComponent<Rigidbody2D>();
    // }

    // // Update is called once per frame
    // void Update() {
    //     Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

    //     if (input != Vector3.zero) {
    //         targetRotation = Quaternion.LookRotation(input);
    //         transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y, targetRotation.eulerAngles.y, Time.deltaTime);
    //     }

    //     Vector3 motion = input;
    //     motion += Vector3.up * -8;
    //     motion *= (Mathf.Abs(input.x) == 1 && Mathf.Abs(input.z) == 1) ? .7f:1;
    //     motion *= (Input.GetButton("Run")) ? runSpeed:walkSpeed;
    //     controller.Move(motion * Time.deltaTime);
    // }
}
