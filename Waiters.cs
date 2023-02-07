using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Static pool with coroutine waiters.
/// </summary>
public static class Waiters
{
    //WARNING! Do not add WaitForSecondsRealtime! It won't work as expected.

    private static Dictionary<float, WaitForSeconds> waitForSeconds = new();
    private static WaitForEndOfFrame endOfFrame = new();
    private static WaitForFixedUpdate fixedUpdate = new();

    public static WaitForEndOfFrame EndOfFrame => endOfFrame;
    public static WaitForFixedUpdate FixedUpdate => fixedUpdate;

    public static WaitForSeconds WaitForSeconds(float _seconds)
    {
        if (waitForSeconds.ContainsKey(_seconds) == false)
        {
            waitForSeconds.Add(_seconds, new WaitForSeconds(_seconds));
        }

        return waitForSeconds[_seconds];
    }

    public static void Clear()
    {
        waitForSeconds.Clear();
    }
}