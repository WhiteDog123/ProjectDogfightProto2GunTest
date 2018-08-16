using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NalBullet : Bullet {
    private void OnCollisionEnter(Collision collision)
    {
        Group otherGroup = collision.gameObject.GetComponent<Group>();
        if (otherGroup == null)
        {
            return;
        }
        else
        {
            //적대 관계이라면
            if (CompareTo(otherGroup) == -1)
            {
                //데미지 입히기
                /*
                 * 데미지 입히는 로직
                 * 데미지 입힐 수 있는 녀석인가?
                 * 일단 Explosive 까지 하고 생각해보자.
                 */
                Destroy(gameObject);
            }
        }
    }
}
