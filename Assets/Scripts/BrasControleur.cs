using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatBras { Fixe = 0, Positif = 1, Negatif = -1 };

public class BrasControleur : MonoBehaviour
{

    //Declaration des variables
    public EtatBras rotationEtat = EtatBras.Fixe;
    public float vitesse = 30.0f;
    public ArticulationBody articulation;
    public ArticulationBody articulationEnabled;

    void Start()
    {
        //Definition des composents
        articulation = GetComponent<ArticulationBody>();
        articulationEnabled = GameObject.Find("support_av_ga_01support_av_ga_02").GetComponent<ArticulationBody>();
    }

    void FixedUpdate()
    {
        //Si les bras sont étendu , on ne peut pas les rentré vers la grue
        var driveEnabled = articulationEnabled.xDrive;
        if(driveEnabled.target >= 0 ){
            if (rotationEtat != EtatBras.Fixe)
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
