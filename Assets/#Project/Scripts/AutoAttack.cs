using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAttack : MonoBehaviour
{

    [SerializeField] int damage;
    [SerializeField] float frequency;
    [SerializeField] GameObject target;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Attack", 2, frequency);//méthode, temps en sec avant qu'il se lance, intervalle où il rappelle la fonction
    }

    void Attack()
    {
        Health targetHealth = target.GetComponent<Health>();//sur le GameObject target, on demande si on a un composant Health. S'il n'en a pas, return null.
        if (targetHealth != null )
        {
            targetHealth.GetHit(damage);
        }
    }
}
