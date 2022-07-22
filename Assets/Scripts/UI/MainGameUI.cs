using System;
using UnityEngine;
using UnityEngine.UIElements;


[RequireComponent(typeof(UIDocument))]
public abstract class MainGameUI : MonoBehaviour
{
    protected VisualElement _Root;

    private void Awake()
    {
        _Root = GetComponent<UIDocument>().rootVisualElement;
    }

    protected abstract void OnEnable();
    protected abstract void OnDisable();
}
