using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float vitesse;
    public float vitesseRotate;
    float rotation;

    //public GameObject prefab;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        bool fire = Input.GetButton("Fire1");
        //float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float rotate = Input.GetAxis("Rotate");

        //Debug.Log("H : " + horizontal);
        Debug.Log("V : " + vertical);
        Debug.Log("fire : " + fire);

        Vector2 move = new Vector3(0,vertical,rotate);
        // transmet les mouvements a l'objet. Time permet de gérer le temps depuis la dernière frame(ici déplacement d'une unité par seconde).
        rotate *= vitesseRotate * Time.deltaTime;
        transform.Rotate(0, 0, rotate);
        Debug.Log("Rotate : " + rotate);

        //transform.position += (Vector3)move * vitesse * Time.deltaTime;
        transform.Translate((Vector3)move * vitesse * Time.deltaTime, Space.Self);
        //transform.rotation = Quaternion.Euler(Vector3.zero); Rotation
        //transform.Rotate(Vector3.zero); Rotation

        

    }
}
