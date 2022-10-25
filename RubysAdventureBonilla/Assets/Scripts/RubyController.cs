using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Debug.Log(horizontal);
        Vector2 position = transform.position;
        position.x = position.x + 0.01f * horizontal;
        float vertical = Input.GetAxis("Vertical");
        transform.position = position;
    }
}
