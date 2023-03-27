using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrochetCommande: MonoBehaviour
{
    //Declaration des variables
    public GameObject Crochet;
    public string axe;

    void Update()
    {
        float input = Input.GetAxis(axe);
        EtatCrochet moveState = EtatTranslationPrInput(input);
        CrochetControleur controller = Crochet.GetComponent<CrochetControleur>();
        controller.translationEtat = moveState;
    }

    EtatCrochet EtatTranslationPrInput(float input)
    {
        if (input > 0)
        {
            return EtatCrochet.Positif;
        }
        else if (input < 0)
        {
            return EtatCrochet.Negatif;
        }
        else
        {
            return EtatCrochet.Fixe;
        }
    }
}
