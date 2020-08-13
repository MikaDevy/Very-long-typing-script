using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public AudioSource source;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.H) || Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl) || Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt) || Input.GetKeyDown(KeyCode.LeftWindows) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.CapsLock) || Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Backslash) || Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.LeftBracket) || Input.GetKeyDown(KeyCode.RightBracket) || Input.GetKeyDown(KeyCode.Semicolon) || Input.GetKeyDown(KeyCode.Comma) || Input.GetKeyDown(KeyCode.Slash) || Input.GetKeyDown(KeyCode.Tilde) || Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.F1) || Input.GetKeyDown(KeyCode.F2) || Input.GetKeyDown(KeyCode.F3) || Input.GetKeyDown(KeyCode.F4) || Input.GetKeyDown(KeyCode.F5) || Input.GetKeyDown(KeyCode.F6) || Input.GetKeyDown(KeyCode.F7) || Input.GetKeyDown(KeyCode.F8) || Input.GetKeyDown(KeyCode.F9) || Input.GetKeyDown(KeyCode.F10) || Input.GetKeyDown(KeyCode.F11) || Input.GetKeyDown(KeyCode.F12) || Input.GetKeyDown(KeyCode.Print) || Input.GetKeyDown(KeyCode.ScrollLock) || Input.GetKeyDown(KeyCode.Pause) || Input.GetKeyDown(KeyCode.Insert) || Input.GetKeyDown(KeyCode.Home) || Input.GetKeyDown(KeyCode.PageUp) || Input.GetKeyDown(KeyCode.PageDown) || Input.GetKeyDown(KeyCode.End) || Input.GetKeyDown(KeyCode.Delete) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            source.Play();
        }
    }
}
