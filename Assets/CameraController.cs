using System.Collections;
using System.Collections.Generic;
// using System.Numerics; 있으면 오류뜸
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 deltaPosition;
    public GameObject playerObject;

    void Awake()
    {
        // new -> 함수 안에서 할당
        deltaPosition = new Vector3(0, 7, -10);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerObject.transform.position + deltaPosition;
    }
}
