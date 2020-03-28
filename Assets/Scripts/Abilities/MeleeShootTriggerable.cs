using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeShootTriggerable : MonoBehaviour {

    [HideInInspector] public float attackSpeed;
    public Transform attackOrigin;
    [HideInInspector] public Animator attack;
    
    
    public void Launch() {
        // Instantiate a copy of the attack and store it in a new Animator variable
        Animator clonedAttack = Instantiate(attack, attackOrigin.position, transform.rotation) as Animator;

        // Trigger animation on the attack
        clonedAttack.SetTrigger("Attack");
    }
}