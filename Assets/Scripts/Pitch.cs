using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitch
{

    private float releaseSpeed;
    private float releasePosX;
    private float releasePosZ;
    private float spinRate;
    private float breakAngle;
    private float breakLength;
    private float plateX;
    private float plateZ;


    public Pitch(float release_speed, float release_pos_x, float release_pos_z, float spin_rate, float break_angle, float break_length, float plate_x, float plate_z)
    {
        releaseSpeed = release_speed;
        releasePosX = release_pos_x;
        releasePosZ = release_pos_z;
        spinRate = spin_rate;
        breakAngle = break_angle;
        breakLength = break_length;
        plateX = plate_x;
        plateZ = plate_z;
    }

    public float GetPlateX()
    {
        return plateX;
    }

    public float GetPlateZ()
    {
        return plateZ;
    }

}