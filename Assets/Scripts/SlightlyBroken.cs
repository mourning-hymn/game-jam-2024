using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlightlyBroken : MonoBehaviour
{
    public HingeJoint2D rightLeg;
    public HingeJoint2D leftLeg;
    private JointMotor2D rightLegMotorRef;
    private JointMotor2D leftLegMotorRef;
    public float hingespeed = 40;
    // Start is called before the first frame update
    void Start()
    {
        rightLegMotorRef = rightLeg.motor;
        leftLegMotorRef = leftLeg.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            leftLeg.useMotor = true;
            leftLegMotorRef.motorSpeed = hingespeed;
            leftLeg.motor = leftLegMotorRef;
        }
        else if(Input.GetKey(KeyCode.D)) 
        {
            rightLeg.useMotor = true;
            rightLegMotorRef.motorSpeed = -hingespeed;
            rightLeg.motor = rightLegMotorRef;
        }
        else if(Input.GetKeyDown(KeyCode.G))
        {
            hingespeed = hingespeed * -1;
        }
        else  
        {
            leftLeg.useMotor = false;
            rightLeg.useMotor = false;
        }
    }
}
