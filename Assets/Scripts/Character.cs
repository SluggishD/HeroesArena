using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//*****************************************
//创建人： 和风天 
//功能说明：
//***************************************** 
public class Character : Unit
{
    protected override void Start()
    {
        base.Start();
        meshAgent.speed = unitInfo.speed;
    }

    void Update()
    {
        if (isDead)
        {
            return;
        }
        UnitMove();
    } 
}
