using System;
using System.Diagnostics;
using UnityEngine;
using Object = UnityEngine.Object;

public static class Debug
{
    [Conditional("UNITY_EDITOR")]
    public static void Break() =>
        UnityEngine.Debug.Break();

    [Conditional("UNITY_EDITOR")]
    public static void ClearDeveloperConsole() =>
        UnityEngine.Debug.ClearDeveloperConsole();

    [Conditional("UNITY_EDITOR")]
    public static void DebugBreak() =>
        UnityEngine.Debug.DebugBreak();

    [Conditional("UNITY_EDITOR")]
    public static void DrawLine(Vector3 start, Vector3 end) =>
        UnityEngine.Debug.DrawLine(start, end);

    [Conditional("UNITY_EDITOR")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color) =>
        UnityEngine.Debug.DrawLine(start, end, color);

    [Conditional("UNITY_EDITOR")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) =>
        UnityEngine.Debug.DrawLine(start, end, color, duration);

    [Conditional("UNITY_EDITOR")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) =>
        UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);

    [Conditional("UNITY_EDITOR")]
    public static void DrawRay(Vector3 start, Vector3 dir) =>
        UnityEngine.Debug.DrawRay(start, dir);

    [Conditional("UNITY_EDITOR")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color) =>
        UnityEngine.Debug.DrawRay(start, dir, color);

    [Conditional("UNITY_EDITOR")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) =>
        UnityEngine.Debug.DrawRay(start, dir, color, duration);

    [Conditional("UNITY_EDITOR")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) =>
        UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);

    [Conditional("UNITY_EDITOR")]
    public static void Log(object message) => 
        UnityEngine.Debug.Log(message);

    [Conditional("UNITY_EDITOR")]
    public static void Log(object message, Object context) =>
        UnityEngine.Debug.Log(message, context);

    [Conditional("UNITY_EDITOR")]
    public static void LogError(object message) =>
        UnityEngine.Debug.LogError(message);

    [Conditional("UNITY_EDITOR")]
    public static void LogError(object message, Object context) =>
        UnityEngine.Debug.LogError(message, context);

    [Conditional("UNITY_EDITOR")]
    public static void LogException(Exception exception) =>
        UnityEngine.Debug.LogException(exception);

    [Conditional("UNITY_EDITOR")]
    public static void LogException(Exception exception, Object context) => 
        UnityEngine.Debug.LogException(exception,context);

    [Conditional("UNITY_EDITOR")]
    public static void LogWarning(object message) => 
        UnityEngine.Debug.LogWarning(message);

    [Conditional("UNITY_EDITOR")]
    public static void LogWarning(object message, Object context) => 
        UnityEngine.Debug.LogWarning(message,context);
}
