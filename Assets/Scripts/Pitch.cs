using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitch : MonoBehaviour
{

    public float releaseSpeed { get; set; }
    public float MyProperty { get; set; }
    public float releasePosX { get; set; }
    public float releasePosZ { get; set; }
    public float spinRate { get; set; }
    public float breakAngle { get; set; }
    public float breakLength { get; set; }
    public float plateX { get; set; }
    public float plateZ { get; set; }

    public Pitch(float plate_x, float plate_z)
    {
        plateX = plate_x;
        plateZ = plate_z;
    }

    public Pitch(float release_speed, float spin_rate, float plate_x, float plate_z)
    {
        releaseSpeed = release_speed;
        spinRate = spin_rate;
        plateX = plate_x;
        plateZ = plate_z;

    }

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




}