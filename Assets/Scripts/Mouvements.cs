using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour{

    //init de la grue
    public Rigidbody mobilecrane;

    //init de la vitesse de déplacement par défaut du joueur
    public float speed = 0.01f;
    public float Rotationspeed = 1;
    
    public ArticulationBody articulation;

    void Start(){
        //Definit l'objet grue
        mobilecrane = GetComponent<Rigidbody>();
        articulation = GameObject.Find("support_av_ga_01").GetComponent<ArticulationBody>();
    }

    // Update is called once per frame
    void Update(){
    
        //Si les bras sont déployer , il est impossible de bouger la grue
        var drive = articulation.xDrive;
            if(drive.target >= 0 ){
                //deplacement vers l'arrière
                if (Input.GetKey(KeyCode.DownArrow)){
                    transform.Translate(Vector3.forward * speed);
                }

                //deplacement vers l'avant
                if (Input.GetKey(KeyCode.UpArrow)){
                    transform.Translate(Vector3.forward * -speed);
                }

                //deplacement vers la gauche
                if (Input.GetKey(KeyCode.LeftArrow)){
                    transform.Rotate(Vector3.down , Rotationspeed);
                }

                //deplacement vers la droite
                if (Input.GetKey(KeyCode.RightArrow)){
                    transform.Rotate(Vector3.up, Rotationspeed);
                }
            }
    }
}
