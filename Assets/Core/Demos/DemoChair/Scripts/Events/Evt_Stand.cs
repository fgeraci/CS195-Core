//using UnityEngine;
//using TreeSharpPlus;
//using System;
//using System.Collections;

//[RequireComponent(typeof(BehaviorLibrary))]
//public class Evt_Stand : SmartEvent
//{
//    public static float PRIORITY = 0.5f;

//    public override FeatureVector[] ComputeRequirements()
//    {
//        return new FeatureVector[]
//        {
//            //new FeatureVector((int)MySetting.Tag.NUM_TAGS, true, MySetting.ToInt(
//            //    MySetting.Tag.IsCharacter,
//            //    MySetting.Tag.IsSitting)),
//            //new FeatureVector((int)MySetting.Tag.NUM_TAGS, true, MySetting.ToInt(
//            //    MySetting.Tag.IsChair))
//        };
//    }

//    public override void Execute(params SmartObject[] participants)
//    {
//        SmartObject character = participants[0];
//        SmartObject chair = participants[1];

//        Node root =
//            new Sequence(
//                new LeafInvoke(() => chair.RunAffordance("Stand", character)));

//        new BehaviorEvent(
//            root,
//            PRIORITY,
//            null,
//            "Evt_Stand",
//            character.GetComponent<SmartAgent>());
//    }
//}