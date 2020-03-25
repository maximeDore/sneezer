using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class SneezeAbility : MonoBehaviour {

//     private Transform spawnPoint;
//     private GameObject sneezePrefab;

//     // Components
//     private PlayerController player;

//     // Handling
//     private float damage = 10f;
//     // private float velocity = 20f;

//     private void Start() {
        
//     }

//     // Update is called once per frame
//     private void Update() {
        
//     }

//     private void Attack() {
//         GameObject sneeze = Instantiate(sneezePrefab, spawnPoint.position, spawnPoint.rotation);

//         // rb = sneeze.GetComponent<Rigidbody2D>();
//         // rb.AddForce(spawnPoint.up * velocity, ForceMode2D.Impulse);
//     }
// }

[CreateAssetMenu (menuName = "Abilities/MeleeAttack")]
public class MeleeAttack : Ability {

    // The A is for Ability
    public int baseDamage = 1;

    private SneezeAttack prefab;

    public override void Initialize(GameObject obj) {
        prefab = obj.GetComponent<SneezeAttack>();
        // prefab.Initialize

        prefab.baseDamage = baseDamage;
    }

    public override void TriggerAbility() {
        // prefab.Attack();
    }

}