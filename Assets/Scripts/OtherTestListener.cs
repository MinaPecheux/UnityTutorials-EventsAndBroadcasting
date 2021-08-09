using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OtherTestListener : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private UnityAction onTest;

    private void Awake()
    {
        onTest = new UnityAction(OnTest);
    }

    private void OnEnable()
    {
        EventManager.StartListening("Test", onTest);
        EventManager.StartListening("ChangeColor", OnChangeColor);
    }

    private void OnDisable()
    {
        EventManager.StopListening("Test", onTest);
        EventManager.StopListening("ChangeColor", OnChangeColor);
    }

    private void OnTest()
    {
        Debug.Log($"{gameObject.name} received VERY SPECIAL test!");
    }

    private void OnChangeColor(object data)
    {
        Color c = (Color)data;
        spriteRenderer.color = c;
    }
}
