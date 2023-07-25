﻿using Prism.Events;
using System;
using System.Diagnostics;

namespace JamenetAvalonia.JamesnetWpf
{
    public interface IEventHub
    {
        Action<StackTrace> Publising { get; set; }

        void Publish<T1, T2>(T2 value) where T1 : PubSubEvent<T2>, new();

        void Subscribe<T1, T2>(Action<T2> action) where T1 : PubSubEvent<T2>, new();
    }
}
