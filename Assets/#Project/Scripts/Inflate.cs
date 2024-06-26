using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inflate : MonoBehaviour
{
    [SerializeField] private float scale = 2f;
    private bool isInflating = false;
    private bool isDeflating = false;
    [SerializeField] private float timeToInflate = 2f;
    private float chrono = 0f;
    private Transform otherTransform;


    private void Update()
    {
        if (isInflating)
        {
            chrono += Time.deltaTime;
            float ratio = chrono / timeToInflate;
            otherTransform.localScale = Vector3.Lerp(Vector3.one, Vector3.one * scale, ratio);//Vector3.one = (1, 1, 1)
        }

        if (isDeflating)
        {
            chrono += Time.deltaTime;
            float ratio = chrono / timeToInflate;
            otherTransform.localScale = Vector3.Lerp(Vector3.one * scale, Vector3.one, ratio);//Vector3.one = (1, 1, 1)
        }



    }

    private void OnTriggerEnter(Collider other)//c'est la signature de l'event
    {
        isInflating = true;
        isDeflating = false;
        otherTransform = other.transform;
        chrono = 0f;
        //other.transform.localScale *= 2;//transformera x, y et z de la même façon
    }

    private void OnTriggerExit(Collider other)//c'est la signature de l'event
    {
        isDeflating = true;
        isInflating = false;
        otherTransform = other.transform;
        chrono = 0f;
        //other.transform.localScale /= 2;//transformera x, y et z de la même façon
    }

}
