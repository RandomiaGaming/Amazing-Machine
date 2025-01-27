using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class TilemapManager : MonoBehaviour {
    public static Tilemap tm;
	// Use this for initialization
	void Start () {
        tm = GetComponent<Tilemap>();
	}
}
