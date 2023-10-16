using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private CubeBehaviour cubeBehaviour;
    [SerializeField] private bool manual;
    float horizontalInput;
    float verticalInput;


    //Para rotar el cubo de manera constante, cambiando sus direcciones con las flechas del teclado y detenerlo con Space
    void OnEnable()
    {

        horizontalInput = 1;
        verticalInput = 1;

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInput = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInput = -1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalInput = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalInput = -1;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            verticalInput = 0;
            horizontalInput = 0;
        }



        cubeBehaviour.InputHorizontal = horizontalInput;
        cubeBehaviour.InputVertical = verticalInput;
    }

    //    void Update()
    //    {
    //        //Para realizarlo de forma automatica constante y manual pausada
    //    if (manual)
    //        {
    //            cubeBehaviour = GetComponent<CubeBehaviour>();
    //            horizontalInput = Input.GetAxis("Horizontal");
    //            verticalInput = Input.GetAxis("Vertical");
    //        }
    //        else
    //        {
    //            cubeBehaviour = null;
    //        }
    //        cubeBehaviour.InputHorizontal = horizontalInput;
    //        cubeBehaviour.InputVertical = verticalInput;    
    //    }
}