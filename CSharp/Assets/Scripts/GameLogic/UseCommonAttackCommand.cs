﻿namespace Assets.Scripts.GameLogic
{
    using Assets.Scripts.Framework;
    using Assets.Scripts.GameLogic.GameKernal;
    using CSProtocol;
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), FrameCommandClass(FRAMECMD_ID_DEF.FRAME_CMD_USECOMMONATTACK)]
    public struct UseCommonAttackCommand : ICommandImplement
    {
        public sbyte Start;
        public uint ObjID;
        [FrameCommandCreator]
        public static IFrameCommand Creator(ref FRAME_CMD_PKG msg)
        {
            FrameCommand<UseCommonAttackCommand> command = FrameCommandFactory.CreateFrameCommand<UseCommonAttackCommand>();
            command.cmdData.Start = msg.stCmdInfo.stCmdPlayerUseCommonAttack.chStart;
            command.cmdData.ObjID = msg.stCmdInfo.stCmdPlayerUseCommonAttack.dwObjID;
            return command;
        }

        public bool TransProtocol(ref FRAME_CMD_PKG msg)
        {
            msg.stCmdInfo.stCmdPlayerUseCommonAttack.chStart = this.Start;
            msg.stCmdInfo.stCmdPlayerUseCommonAttack.dwObjID = this.ObjID;
            return true;
        }

        public bool TransProtocol(ref CSDT_GAMING_CSSYNCINFO msg)
        {
            return true;
        }

        public void OnReceive(IFrameCommand cmd)
        {
        }

        public void Preprocess(IFrameCommand cmd)
        {
        }

        public void ExecCommand(IFrameCommand cmd)
        {
            Player player = Singleton<GamePlayerCenter>.GetInstance().GetPlayer(cmd.playerID);
            if ((player != null) && (player.Captain != 0))
            {
                player.Captain.handle.ActorControl.CmdCommonAttackMode(cmd, this.Start, this.ObjID);
            }
        }

        public void AwakeCommand(IFrameCommand cmd)
        {
        }
    }
}

