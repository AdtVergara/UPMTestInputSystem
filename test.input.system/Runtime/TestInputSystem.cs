#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class TestInputSystem
{
    public string[] GetDevices()
    {
        var devices = new List<string>();
        var inputDevices = InputSystem.devices;
        foreach (var inputDevice in inputDevices)
        {
            switch (inputDevice)
            {
                case Keyboard keyboard:
                    devices.Add(keyboard.description.ToString());
                    break;
                case Mouse mouse:
                    devices.Add(mouse.description.ToString());
                    break;
                case Gamepad _:
                case Joystick _:
                    break;
                case Touchscreen touchScreen:
                    devices.Add(touchScreen.description.ToString());
                    break;
            }
        }
        return devices.ToArray();
    }
}
#endif
