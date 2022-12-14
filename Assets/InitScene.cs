using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScene : MonoBehaviour
{
    [SerializeField] private Texture2D cursor;

    void Start()
    {
        Time.timeScale = 1;
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }
}
