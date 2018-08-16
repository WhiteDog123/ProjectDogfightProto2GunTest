using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;


public class Group : MonoBehaviour {
    public enum KIND
    {
        VOXELLERS = 0,
        INVADERS = 1,
        NEUTURAL = 2,
        ITEM = 3,
    }

    [SerializeField]
    private KIND _kind;
    public KIND Kind
    {
        set { _kind = value; }
        get { return _kind; }
    }

    /*
     * -1 적대 0 중립 1 아군
     */
    private int[,] _relationship = new int[4, 4]
        {{1, -1, 0, 0 },
            {-1, 1, 0, 0 },
            {0, 0, 0, 0 },
            {0, 0, 0, 0 } };
    public int[,] Relationship {
        get { return _relationship; }
            }
}
