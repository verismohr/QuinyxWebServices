using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace QuinyxWebServices;

public interface FlexForcePortTypeChannel : FlexForcePortType, IClientChannel, IContextChannel, IChannel, ICommunicationObject, IExtensibleObject<IContextChannel>, IDisposable
{
}