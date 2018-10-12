﻿using DesignPattern.Command.Receiver;

namespace DesignPattern.Command.Command
{
    /// <summary>
    /// 具体命令类：最小化命令
    /// </summary>
    public class MinimizeCommand : Command
    {
        private WindowHandler handler;

        public MinimizeCommand()
        {
            handler = new WindowHandler();
        }

        // 命令执行方法，将调用请求接受者的业务方法
        public override void Execute()
        {
            if (handler != null)
            {
                handler.Minimize();
            }
        }
    }
}
