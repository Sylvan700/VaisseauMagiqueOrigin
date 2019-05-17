using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Asteroid : MonoBehaviour
{
    public float vitesse;

    void Start()
    {
        // L'asteroide prend un angle de rotation aléatoire compris entre -360 & 360 degrés.
        transform.Rotate(0, 0, Random.Range(-360f,360f));
        // Crée un vecteur en 2d avec deux points aléatoire compris entre (-10 & 10x, -10 & 10y). L'emplacement de départ de la météorite est trouvé comme ça.
        Vector2 pos = new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
        transform.position = (pos);
    }

    void Update()
    {
        // sont déplacement. L'astéroide avance de 1(x, 0y)* la vitesse(dosée depuis Unity) * deltatime.
        Vector2 move = new Vector2(1, 0);
        transform.Translate((Vector2)move * vitesse * Time.deltaTime);
    }

}
