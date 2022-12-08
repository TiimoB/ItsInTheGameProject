using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMouse : MonoBehaviour
{
    [SerializeField] private Texture2D cursor;

    void Start()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }
}
