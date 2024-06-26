using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingDeath : MonoBehaviour, IDie
{
    public void Die()
    {
        Debug.Log("BOOOOM!");
        Destroy(gameObject);
    }
}
