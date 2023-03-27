using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatBras2 { Fixe = 0, Positif = 1, Negatif = -1 };

public class BrasControleur2 : MonoBehaviour
{

    //Declaration des variables
    public EtatBras2 rotationEtat = EtatBras2.Fixe;
    public float vitesse = 30.0f;
    private ArticulationBody articulation;
    private ArticulationBody articulationEnabled;

    void Start()
    {
        articulation = GetComponent<ArticulationBody>();
        articulationEnabled = GameObject.Find("support_av_ga_01").GetComponent<ArticulationBody>();
    }

    void FixedUpdate()
    {
        var driveEnabled = articulationEnabled.xDrive;
        if(driveEnabled.target <= -25 ){
            if (rotationEtat != EtatBras2.Fixe)
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
