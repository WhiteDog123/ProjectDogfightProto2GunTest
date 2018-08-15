using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTriggeredByCollision : BulletTriggerType {
    private void OnCollisionEnter(Collision collision)
    {
        //어떻게 충돌했을때, 그러니까 어떤 태그랑 충돌하고 어쨋을 때 되는지 구문이 있어야함...
        //아니면, 레이어로 충돌 되고 안되고 구분하고, 아니면 '세력' 변수로 구분하고, 충돌이후 데미지 입힐지 말지는 총알의 함수에서 결정?
        bulletToTrigger.ActivateEffect();
    }
}
