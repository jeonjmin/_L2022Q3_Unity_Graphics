using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Locate : MonoBehaviour
{
    public Transform : PosReference;

    Camera TargetCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        TargetCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TargetCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayAtPoint()
    {
        Vector3 WorldPos = PosReference.position;
        Vector2 ScreenPos = TargetCamera.WorldToScreenPoint(WorldPos);
        transform.position = ScreenPos;
    }
}
