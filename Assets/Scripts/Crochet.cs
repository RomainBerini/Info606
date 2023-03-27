using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crochet : MonoBehaviour
{

    void Start(){
        
    }

    void Update(){
        //La touche ESPACE lache l'objet attaché
        if (Input.GetKey(KeyCode.Space)){
            Destroy(this.gameObject.GetComponent<FixedJoint>());
        }
        
    }

    //Si le crochet rentre en colition avec l'objet , il l'agrippe
    void OnCollisionEnter(Collision Collision){
        if (Collision.gameObject.GetComponent<ArticulationBody>() != null){
        FixedJoint joint = this.gameObject.AddComponent<FixedJoint>();
        joint.connectedArticulationBody = Collision.articulationBody;
        }
    }

}
