﻿namespace behaviac
{
    using Assets.Scripts.GameLogic;
    using System;

    internal class Action_bt_WrapperAI_Soldier_BTSoldierPro_node79 : behaviac.Action
    {
        protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
        {
            uint variable = (uint) pAgent.GetVariable((uint) 0x47e01b5e);
            ((ObjAgent) pAgent).SelectTarget(variable);
            return EBTStatus.BT_SUCCESS;
        }
    }
}

