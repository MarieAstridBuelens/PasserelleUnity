using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] public float rotationSpeed; //veut dire enregistrer. Dire � Unity de l'afficher dans l'inspecteur, m�me s'il est priv�

    [SerializeField] Space space;
    [HideInInspector] public bool debug; //sera automatiquement mis dans inspector > public. Mais si pas envie que �a aille dans l'inspector, on fait �a. C'est l'inverse de SerializedField

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, space); // tourner le transform du gameObject en Y + Space.World : prend le Y en global et pas en local comme le ferait Space.Self
    }
}
