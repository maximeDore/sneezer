using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShootTriggerable : MonoBehaviour {

    [HideInInspector] public float projectileVelocity;
    public Transform projectileSpawn;
    [HideInInspector] public Rigidbody2D projectile;
    
    
    public void Launch() {
        // Instantiate a copy of the projectile and store it in a new RigidBody2D variable
        Rigidbody2D clonedProjectile = Instantiate(projectile, projectileSpawn.position, transform.rotation) as Rigidbody2D;

        // Trigger motion on the projectile
        clonedProjectile.AddForce(projectileSpawn.transform.forward * projectileVelocity);

        // Add force to the projectile to make launch it in a direction
    }
}
