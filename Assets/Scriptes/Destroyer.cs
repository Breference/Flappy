using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private Transform mainCamera;
    // Start is called before the first frame update
    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x <= mainCamera.position.x - 10)
        {
            Destroy(GameObject);
        }
    }
}
