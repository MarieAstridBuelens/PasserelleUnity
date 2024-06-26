using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{

    //private struct Speed
    //{
    //    public const float slow = 1f;
    //    public const float med = 5f;
    //    public const float fast = 10f;
    //}
    
    enum Direction
    {
        right, up, forward
    }

    [SerializeField] private Direction direction = Direction.forward;
    [SerializeField] private float speed = 1f;

    [SerializeField] private Color color = Color.red;//variables statiques, raccourci vers les couleurs

    // Start is called before the first frame update
    void Start() //se fait à la première frame du composant
    {
        GetComponent<Renderer>().material.color = color;//on chope un composant présent sur l'objet sur lequel on est en train de travailler. Marche pour classes parents.
            
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = new(1, 3, 5); //on déclare une variable vector3 qui a une position 1, 3, 5.


        Vector3 dir;//Vector3 par rapport au monde, transform par rapport à l'objet

        switch (direction)
        {
            case Direction.forward:
                dir = transform.forward; break;
            case Direction.up:
                dir = transform.up; break;
            case Direction.right:
                dir = transform.right; break;
            default:
                dir = Vector3.zero;
                Debug.LogWarning($"{dir} is not handled.");
                break;

        }


        transform.position += dir * Time.deltaTime * speed; 
        //forward = 1 vers l'avant de l'objet; Vector3 : structure. Tu donnes une position sur trois positions. Vector3.forward : avancer le 1 dans le monde
        //transform = nom de la variable, position = propriété

        //Vector3 pos = transform.position; //on déclare une nouvelle position
        //pos = pos + transform.forward;
        //transform.position = pos; //ça fait la même chose
    }
}
