using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotationSpeed = new Vector3(0f, 50f, 0f);

    private void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
