using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour {

    [SerializeField]
    private Transform spawnPoint;
    [SerializeField]
    private GameObject sneezePrefab;

    // Components
    private PlayerController player;

    // Handling
    private float damage = 10f;
    private float velocity = 20f;

    private float rotation;
    public float Rotation{
        get { return rotation; }
        set { rotation = value; }
    }

    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
    }

    void Attack() {
        GameObject sneeze = Instantiate(sneezePrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody2D rb = sneeze.GetComponent<Rigidbody2D>();

        // rb.AddForce(spawnPoint.up * velocity, ForceMode2D.Impulse);
    }
}
