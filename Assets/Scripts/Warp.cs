using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    
    void Start()
    {

    }

    void Update()
    {
        // récupère la position de l'objet sélectionner en tant qu'entity.
        Vector3 posObject = transform.position;
        Vector2 limitNegative = new Vector2(-24, -14);
        Vector2 limitPositive = new Vector2(24, 14);
        // Si la position de entity est inférieur/supérieur a la limite instaurée alors...
        if(posObject.y <= limitNegative.y)
        {
            posObject.y *= -1;

            Debug.Log(" dépasse -y");
        }
        else if(posObject.x <= limitNegative.x)
        {
            posObject.x *= -1;
            Debug.Log(" dépasse -x");
        }
        else if(posObject.y >= limitPositive.y)
        {
            posObject.y *= -1;
            Debug.Log(" dépasse y");
        }
        else if(posObject.x >= limitPositive.x)
        {
            posObject.x *= -1;
            Debug.Log(" dépasse x");
        }
        // rend la position transformée a posObject.
        transform.position = posObject;
    }
}
