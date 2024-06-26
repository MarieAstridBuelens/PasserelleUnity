using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToDestination : MonoBehaviour
{
    private Vector3 start;
    private Vector3 temp;
    [SerializeReference] private Vector3 end;
    [SerializeReference] private float speed;
    [SerializeField] private Color startColor = Color.red;
    [SerializeField] private Color endColor = Color.blue;
    private Color tempColor;

    private float time;
    private float chrono = 0f;//c'est float qu'on utilise en unity

    // Start is called before the first frame update
    void Start()
    {
        
        start = transform.position;
        GetComponent<Renderer>().material.color = startColor;
        time = Vector3.Distance(start, end) / speed;//méthode statique qui calcule la distance absolue entre deux vector3
        
    }

    // Update is called once per frame
    void Update()
    {
        
        chrono += Time.deltaTime;
        float ratio = chrono / time; //donne portion de voyage déjà faite entre le start et le end

        transform.position = Vector3.Lerp(start, end, ratio);//donne la position à un temps précis à par exemple 1/5e de mon voyage

        GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, ratio);

        if (ratio >= 1f)
        {
            //transform.position = -transform.position;

            temp = start;
            start = end;
            end = temp;

            tempColor = startColor;
            startColor = endColor;
            endColor = tempColor;

            chrono = 0f;

        }

    }

    
}
