using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleMovement : MonoBehaviour
{
    public KeyCode input;
    private HingeJoint hinge;
    private float targetPressed;
    private float targetRelease;
    // Start is called before the first frame update
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        // Mengambil komponen Spring dari hinge joint
        JointSpring js = hinge.spring;

        if(Input.GetKey(input))
        {
            js.targetPosition = targetPressed;
        }
        else
        {
            js.targetPosition = targetRelease;
        }
        hinge.spring = js;
    }
}
