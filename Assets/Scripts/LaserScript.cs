using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{

    [SerializeField]
    GameObject projector;
    [SerializeField]
    LineRenderer laserBeam;

    public int beamTime;
    public int beamLenght;
    bool isBeam;

    // Start is called before the first frame update
    void Start()
    {
        laserBeam = projector.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBeam)
        {
            startLasering();
        }

    }

    void startLasering()
    {
        laserBeam.SetPosition(0, projector.transform.position);
        RaycastHit hit;

        if (Physics.Raycast(projector.transform.position, projector.transform.forward, out hit))
        {
            if (hit.collider)
            {
                laserBeam.SetPosition(1, hit.point);
            }
        }
        else laserBeam.SetPosition(1, projector.transform.forward * beamLenght);
    }
}
