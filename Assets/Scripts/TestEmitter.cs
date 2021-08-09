using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEmitter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            EventManager.TriggerEvent("Test");
        if (Input.GetMouseButtonDown(1))
            EventManager.TriggerEvent("ChangeColor", Color.gray);
    }
}
