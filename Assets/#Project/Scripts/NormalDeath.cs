using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDeath : MonoBehaviour, IDie
{
    public void Die()
    {
        Debug.Log("I am dying normally!");
        Destroy(gameObject);//détruit le gameObject à la fin de la frame. On détruit toute l'instance
    }
}
