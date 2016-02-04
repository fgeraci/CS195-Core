﻿using UnityEngine;
using System.Collections;

using TreeSharpPlus;

[LibraryIndex(2)]
public class Evt_GetBall : SmartEvent
{
    public SmartCharacter grabber;
    public SmartTable table;

    [Name("GetBall")]

    [StateRequired(0, StateName.RoleActor, StateName.IsStanding, ~StateName.HoldingBall, ~StateName.IsIncapacitated)]
    [StateRequired(1, StateName.RoleTable, StateName.HoldingBall)]

    [StateEffect(0, StateName.HoldingBall)]
    [StateEffect(1, ~StateName.HoldingBall)]

    public Evt_GetBall(SmartCharacter grabber, SmartTable table)
        : base(grabber, table)
    {
        this.grabber = grabber;
        this.table = table;
    }

    public override TreeSharpPlus.Node BakeTree(Token token)
    {
        return new Sequence(
            new LeafAffordance("TakeBall", this.grabber, this.table));
    }
}
