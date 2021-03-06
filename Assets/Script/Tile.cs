﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TILE_TYPE
{
    RAND,
    WALL,
    AGENT,
    END,
}

public class Tile : MonoBehaviour {

    [SerializeField]
    private TILE_TYPE _type;
    public TILE_TYPE type { set { _type = value; } get { return _type; } }

    [SerializeField]
    private Point _index;
    public Point index { set { _index = value; } get { return _index; } }

    public float f { set; get; }
    public float g { set; get; }
    public float h { set; get; }
    public Tile nextTile { set; get; }

    private MeshRenderer _renderer = null;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    public void SetPathColor()
    {
        if (!(_type.Equals(TILE_TYPE.AGENT) || _type.Equals(TILE_TYPE.END)))
            _renderer.material = Resources.Load<Material>("Path");
    }
}
