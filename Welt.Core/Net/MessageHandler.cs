﻿#region Copyright
// COPYRIGHT 2016 JUSTIN COX (CONJI)
#endregion

using System;
using System.Linq;
using System.Reflection;

namespace Welt.Core.Net
{
    public class MessageHandler
    {
        private static readonly IMessage[] _messageTypes = new IMessage[256];

        public static void Initialize()
        {
            foreach (var m in AppDomain.CurrentDomain.GetAssemblies()[0].GetTypes()
                .Where(t => typeof (IMessage).IsAssignableFrom(t))
                .Select(type => (IMessage) Activator.CreateInstance(type, BindingFlags.CreateInstance)))
            {
                _messageTypes[m.Id] = m;
            }
        }

        public static IMessage GetMessage(byte id)
        {
            return _messageTypes[id];
        }
    }
}