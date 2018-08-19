using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraManager : MonoBehaviour
{
    public Vector3 offset;
    public Transform target;
    // Use this for initialization
    void Start()
    {
        offset = transform.position;
    }

    //왜 여기서 LateUpdate 썼을까?
    //Update에서 플레이어 움직임이 발생하니
    //움직임 발생된 뒤에 따라가져야하니까?
    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}