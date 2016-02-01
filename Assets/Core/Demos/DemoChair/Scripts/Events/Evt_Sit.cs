//using UnityEngine;
//using TreeSharpPlus;
//using System;
//using System.Collections;

//[RequireComponent(typeof(BehaviorLibrary))]
//public class Evt_Sit : SmartEvent
//{
//    public static float PRIORITY = 0.5f;

//    public override FeatureVector[] ComputeRequirements()
//    {
//        return new FeatureVector[]
//        {
//        };
//    }

//    public override void Execute(params SmartObject[] participants)
//    {
//        SmartObject character = participants[0];
//        SmartObject chair = participants[1];

//        Node root =
//            new Sequence(
//                new LeafInvoke(() => chair.RunAffordance("Sit", character)));

//        new BehaviorEvent(
//            root,
//            PRIORITY,
//            null,
//            "Evt_Sit",
//            character.GetComponent<SmartAgent>());
//    }
//}