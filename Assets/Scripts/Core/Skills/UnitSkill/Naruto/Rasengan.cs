﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rasengan : AttackSkill {

    public override void SetLevel(int level)
    {
        base.SetLevel(level);
        hitInterval = 0.15f;
    }
    //public override bool Filter(Skill sender)
    //{
    //    int i = 0;
    //    var list = Detect.DetectObjects(Range.CreateRange(1, sender.character.position));
    //    //牙通牙判断,牙或赤丸是否在相邻1格内
    //    foreach (var l in list)
    //    {
    //        foreach (var u in l)
    //        {
    //            if (u.GetComponent<CharacterStatus>())
    //            {
    //                if (!sender.character.GetComponent<CharacterStatus>().IsEnemy(u.GetComponent<CharacterStatus>()))
    //                {
    //                    if (u.GetComponent<CharacterStatus>().roleEName == "Kiba")
    //                    {
    //                        i++;
    //                    }
    //                }
    //            }
    //        }
    //    }
    //    //牙判断，i+1，赤丸判断，i+1，所以i == 2
    //    if (i == 2)
    //    {
    //        return base.Filter(sender);
    //    }
    //    return false;
    //}

    protected override void InitSkill()
    {
        base.InitSkill();
        Camera.main.GetComponent<RTSCamera>().FollowTarget(character.position);
        GameController.GetInstance().Invoke(() => {
            FXManager.GetInstance().Spawn("Rasengan", character.GetComponent<Animator>().GetBoneTransform(HumanBodyBones.RightHand), 2.8f);
        },0.2f);
        
    }
}
