using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class InputManager : MonoBehaviour
{
    public Item selected;
    public TileBase CanPlace;
    public static Vector3Int CursorPos;
    public static bool Place;
    public static bool Delete;
    public static int ScrollAxis;
    void Update()
    {
        ScrollAxis = 0;
        Place = false;
        Delete = false;
        if (Input.GetMouseButtonDown(0))
        {
            Place = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            Delete = true;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ScrollAxis = -1;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ScrollAxis = 1;
        }
        CursorPos = TilemapManager.tm.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        transform.position = CursorPos + new Vector3(0.5f, 0.5f, 0);
        if (Place)
        {
            bool canplace = true;
            foreach(GameObject go in GameObject.FindGameObjectsWithTag("Item"))
            {
                if(TilemapManager.tm.WorldToCell(go.transform.position) == CursorPos)
                {
                    canplace = false;
                }
            }
            if (canplace && TilemapManager.tm.GetTile(CursorPos) == canplace && !BallScript.playing)
            {
                Instantiate(selected, transform.position, Quaternion.identity);
            }
        }
    }
}
