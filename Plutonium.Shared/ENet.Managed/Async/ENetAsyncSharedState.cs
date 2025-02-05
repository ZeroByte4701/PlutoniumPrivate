﻿namespace ENet.Managed.Async;

internal sealed class ENetAsyncSharedState
{
    public readonly List<ENetAsyncPeer> AsyncPeers = new(16);
    public readonly ENetHost Host;
    public bool Started = false;
    public bool Stopped = false;

    public ENetAsyncSharedState(ENetHost host)
    {
        Host = host;
    }

    public void ThrowIfStopped()
    {
        if (Stopped)
            throw new InvalidOperationException("Async Host has stopped.");
    }
}