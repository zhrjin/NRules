﻿namespace NRules.Core.Rete
{
    internal interface IEventSink
    {
        void Activate(Activation activation);
    }
}