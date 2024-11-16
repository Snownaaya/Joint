using UnityEngine;
using System;

public class KeyboardInput : MonoBehaviour
{
    public event Action QkeyDown;
    public event Action EKeyDown;
    public event Action SpaceDown;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
            QkeyDown?.Invoke();

        if (Input.GetKeyDown(KeyCode.E))
            EKeyDown?.Invoke();

        if(Input.GetKeyDown(KeyCode.Space))
            SpaceDown?.Invoke();
    }
}
