using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float vitesse;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posObject = transform.position;

        Vector2 move = new Vector2(0, 1);
        transform.Translate((Vector2)move * vitesse * Time.deltaTime);

        Vector2 limitNegative = new Vector2(-24, -14);
        Vector2 limitPositive = new Vector2(24, 14);
        // Si la position (y ou x) de l'objet est en dessous/ au dessus de la limite et que le nom de l'objet est "shoot(clone)" alors détruiser l'objet.
        // Permet de se débarasser des clones de tirs tout en gardant l'objet original pour pouvoir continer a le copié.
        if (posObject.y <= limitNegative.y & gameObject.name == "shoot(Clone)")
        {
            Destroy(gameObject);

        }
        else if (posObject.x <= limitNegative.x & gameObject.name == "shoot(Clone)")
        {
            Destroy(gameObject);
        }
        else if (posObject.y >= limitPositive.y & gameObject.name == "shoot(Clone)")
        {
            Destroy(gameObject);
        }
        else if (posObject.x >= limitPositive.x & gameObject.name == "shoot(Clone)")
        {
            Destroy(gameObject);
        }

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Big Rock") ;
        {
            Destroy(collision.gameObject);
        }
    }


}
