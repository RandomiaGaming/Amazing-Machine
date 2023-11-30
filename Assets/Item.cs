using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    private void Update()
    {
        if(TilemapManager.tm.WorldToCell(transform.position) == InputManager.CursorPos && !BallScript.playing)
        {
            if (InputManager.Place)
            {
                if((Vector2)transform.up == new Vector2(0, 1))
                {
                    transform.up = new Vector2(1, 0);
                }else if ((Vector2)transform.up == new Vector2(1, 0))
                {
                    transform.up = new Vector2(0, -1);
                }
                else if ((Vector2)transform.up == new Vector2(0, -1))
                {
                    transform.up = new Vector2(-1, 0);
                }
                else if ((Vector2)transform.up == new Vector2(-1, 0))
                {
                    transform.up = new Vector2(0, 1);
                }
            }else if (InputManager.Delete)
            {
                Destroy(gameObject);
            }
        }
    }
}
