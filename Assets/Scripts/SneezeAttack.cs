using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneezeAttack : MonoBehaviour {

    [HideInInspector] public float baseDamage; 

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Ennemy") {
            // Trigger the damage method of the ennemy
        }
    }
}
