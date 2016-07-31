﻿using Microsoft.AspNetCore.Hosting.Server.Features;
using RestBus.Common;

namespace RestBus.AspNet.Server
{
    interface IServerInformation : IServerAddressesFeature
    {
        IRestBusSubscriber Subscriber { get; }
    }
}
