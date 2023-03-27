using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationFlecheCommande : MonoBehaviour
{
void Update()
{
    //Affectation de l'objet Mat.
    float input = Input.GetAxis("Mat");
    EtatRotationFleche rotationEtat = MoveStateForInput(input);
    foreach (GameObject brasObject in GameObject.FindGameObjectsWithTag("Mat"))
    {
        RotationFlecheControleur brasControleur = brasObject.GetComponent<RotationFlecheControleur>();
        if (brasControleur != null)
        {
            brasControleur.rotationEtat = rotationEtat;
        }
    }
}


    EtatRotationFleche MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatRotationFleche.Positif;
        }
        else if (input < 0)
        {
            return EtatRotationFleche.Negatif;
        }
        else
        {
            return EtatRotationFleche.Fixe;
        }
    }
}
