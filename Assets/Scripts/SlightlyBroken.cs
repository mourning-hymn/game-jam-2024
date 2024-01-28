using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlightlyBroken : MonoBehaviour
{
    // public SpriteRenderer spriteRenderer;
    // public Sprite newSprite;
    public HingeJoint2D rightLeg;
    public HingeJoint2D leftLeg;
    public HingeJoint2D leftArm;
    public HingeJoint2D rightArm;
    private JointMotor2D rightLegMotorRef;
    private JointMotor2D leftLegMotorRef;
    private JointMotor2D leftArmMotorRef;
    private JointMotor2D rightArmMotorRef;
    public float hingespeed = 40;
    // Start is called before the first frame update
    void Start()
    {
        rightLegMotorRef = rightLeg.motor;
        leftLegMotorRef = leftLeg.motor;
        leftArmMotorRef = leftArm.motor;
        rightArmMotorRef = rightArm.motor;

        // gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.A))
        {
            leftLeg.useMotor = true;
            rightLeg.useMotor = true;
            leftLegMotorRef.motorSpeed = -hingespeed;
            rightLegMotorRef.motorSpeed = hingespeed;
            leftLeg.motor = leftLegMotorRef;
            rightLeg.motor = rightLegMotorRef;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rightLeg.useMotor = true;
            leftLeg.useMotor = true;
            leftLegMotorRef.motorSpeed = hingespeed;
            leftLeg.motor = leftLegMotorRef;
            rightLegMotorRef.motorSpeed = -hingespeed;
            rightLeg.motor = rightLegMotorRef;
        }
        else
        {
            leftLeg.useMotor = false;
            rightLeg.useMotor= false;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            leftArm.useMotor = true;
            rightArm.useMotor = true;
            leftArmMotorRef.motorSpeed = -hingespeed;
            rightArmMotorRef.motorSpeed = hingespeed;
            leftArm.motor = leftArmMotorRef;
            rightArm.motor = rightArmMotorRef;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rightArm.useMotor = true;
            leftArm.useMotor = true;
            leftArmMotorRef.motorSpeed = hingespeed;
            leftArm.motor = leftArmMotorRef;
            rightArmMotorRef.motorSpeed = -hingespeed;
            rightArm.motor = rightArmMotorRef;
        }
        else
        {
            leftArm.useMotor = false;
            rightArm.useMotor = false;
        }
        /* else
         {
             rightLeg.useMotor = false;
         }

         if (Input.GetKeyDown(KeyCode.G))
         {
             hingespeed = hingespeed * -1;
         }*/
    }

    // private void OnTriggerEnter2D(Collider2D other) 
    // {

    //     if(other.gameObject.name == "rock"){
    //         spriteRenderer.sprite = newSprite;
    //     }
        
    // }

}
