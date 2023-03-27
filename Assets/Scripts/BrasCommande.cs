using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrasCommande : MonoBehaviour
{
void Update()
{
    //Declaration des variables
    float input = Input.GetAxis("Bras");
    EtatBras rotationEtat = MoveStateForInput(input);
    foreach (GameObject brasObject in GameObject.FindGameObjectsWithTag("Bras"))
    {
        BrasControleur brasControleur = brasObject.GetComponent<BrasControleur>();
        if (brasControleur != null)
        {
            brasControleur.rotationEtat = rotationEtat;
        }
    }
}
    
    EtatBras MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatBras.Positif;
        }
        else if (input < 0)
        {
            return EtatBras.Negatif;
        }
        else
        {
            return EtatBras.Fixe;
        }
    }
}
