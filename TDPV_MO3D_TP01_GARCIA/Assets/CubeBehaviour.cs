using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{

    Vector3 rotacion;


    [SerializeField]
    public float RotationSpeed;
    private float rotationSpeed { get => RotationSpeed; set => RotationSpeed = value; }

    public float InputHorizontal;
    private float inputHorizontal { get => InputHorizontal; set => InputHorizontal = value; }

    public float InputVertical;
    private float inputVertical { get => InputVertical; set => InputVertical = value; }


    private void RotateObject()
    {

        rotacion = new Vector3(InputHorizontal, InputVertical, 0) * RotationSpeed * Time.deltaTime;
        transform.Rotate(rotacion);
    }

    void FixedUpdate()
    {
        RotateObject();
    }
}