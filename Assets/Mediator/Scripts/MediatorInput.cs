using System;
using UnityEngine;
using Zenject;

public class MediatorInput : MonoBehaviour
{
    private Level _level;

    [Inject]
    private void Construct(Level level) => _level = level;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _level.OnDefeat();
    }
}