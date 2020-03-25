using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Abilities/ProjectileAttack")]
public class ProjectileAttack : Ability {
    
    public float projectileVelocity = 100f;
    public Rigidbody2D projectile;

    private ProjectileShootTriggerable launcher;

    public override void Initialize(GameObject obj) {
        launcher = obj.GetComponent<ProjectileShootTriggerable>();
        launcher.projectileVelocity = projectileVelocity;
        launcher.projectile = projectile;
    }

    public override void TriggerAbility() {
        launcher.Launch();
    }

}
