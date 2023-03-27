using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatRotationFleche { Fixe = 0, Positif = 1, Negatif = -1 };

public class RotationFlecheControleur : MonoBehaviour
{
    //Declaration des variables
    public EtatRotationFleche rotationEtat = EtatRotationFleche.Fixe;
    public float vitesse = 30.0f;

    //Declaration des ArticulationBody
    private ArticulationBody articulation;
    public ArticulationBody articulationEnabled;

    void Start()
    {
        //Met les Articulation body dans des variables
        articulation = GetComponent<ArticulationBody>();
        articulationEnabled = GameObject.Find("support_av_ga_01support_av_ga_03").GetComponent<ArticulationBody>();
    }

    void FixedUpdate()
    {   
        //Si le vehicule n'a pas ses bras stabilisateurs sorti , on ne peut pas bouger la grue
        var driveEnabled = articulationEnabled.xDrive;
        if(driveEnabled.target <= -50 ){
            if (rotationEtat != EtatRotationFleche.Fixe)
            {
                    float rotationChange = (float)rotationEtat * vitesse * Time.fixedDeltaTime;
                    float rotationGoal = AxeRotation() + rotationChange;
                    RotationVers(rotationGoal);
            }
        }

    }

    float AxeRotation()
    {
        float RotationRads = articulation.jointPosition[0];
        float Rotation = Mathf.Rad2Deg * RotationRads;
        return Rotation;
    }

    void RotationVers(float primaryAxisRotation)
    {
        var drive = articulation.xDrive;
            drive.target = primaryAxisRotation;
            articulation.xDrive = drive;
    }
}
