using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrasCommande2 : MonoBehaviour
{
void Update()
{
    //Declaration des variables , et ajout dans un tableau afin que tout s'execute en même temps avec 1 seul script
    float input = Input.GetAxis("Bras2");
    EtatBras2 rotationEtat = MoveStateForInput(input);
    foreach (GameObject brasObject in GameObject.FindGameObjectsWithTag("Bras2"))
    {
        BrasControleur2 brasControleur = brasObject.GetComponent<BrasControleur2>();
        if (brasControleur != null)
        {
            brasControleur.rotationEtat = rotationEtat;
        }
    }
}


    EtatBras2 MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatBras2.Positif;
        }
        else if (input < 0)
        {
            return EtatBras2.Negatif;
        }
        else
        {
            return EtatBras2.Fixe;
        }
    }
}
