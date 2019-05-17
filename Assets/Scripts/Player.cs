using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    /// <summary>
    /// Contrôle du joueur: flèches directionnelles ou ZQSD.
    /// </summary>
    public float vitesse;
    public float vitesseRotate;
    float rotation;
    public GameObject prefab;
    public GameObject shoot;

    void Start()
    {
        shoot.SetActive(false);
    }

    void Update()
    {

        //Récupère les touches assignées dans les settings du projet Unity.
        bool fire = Input.GetButton("Fire1");
        //float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float rotate = Input.GetAxis("Rotate");

        //Debug.Log("H : " + horizontal);
        //Debug.Log("V : " + vertical);
        //Debug.Log("fire : " + fire);

        // déclare un nouveau vecteur "move" qui est composé des variables vertical(axe Y) et rotate(axe Z)
        Vector2 move = new Vector2(0, vertical);
        Vector2 moveBullet = new Vector2(1, 0);
        // Modifie la vitesse et le temps depuis la dernière frame de la variable rotate.
        rotate *= vitesseRotate * Time.deltaTime;
        // Rotation 
        transform.Rotate(0, 0, rotate);

        //Debug.Log("Rotate : " + rotate);

        // Active le déplacement vertical sur le vaisseau (et les modifications de vitesse et de temps) et transmet la rotation sur les axes "personnel" du vaisseau.
        transform.Translate((Vector3)move * vitesse * Time.deltaTime, Space.Self);

        // Positionement(et orientation) aléatoire des astéroides a leur apparition.
        Vector2 spawn = new Vector2(Random.Range(-25f, 25f), Random.Range(-12f, 12f));

        // Crée un nouvel astéroide a une position aléatoire(dans les limites instaurées dans les vecteurs).
        if (fire)
        {
            Instantiate(prefab, (Vector2)spawn, Quaternion.Euler(0, 0, Random.Range(-360f, 360f)));
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot.SetActive(true);
            Instantiate(shoot, transform.position, transform.rotation);  
        }



    }
}
