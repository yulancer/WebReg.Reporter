using Microsoft.Extensions.DependencyInjection;
using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;

namespace WebReg.Reporter.Domain.Implementations.Services;

public class SenderFactory : ISenderFactory
{
    private readonly IServiceProvider _serviceProvider;

    public SenderFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public Task<ISender?> Create(ChannelType channelType)
    {
        var sender = _serviceProvider.GetServices<ISender>().FirstOrDefault(s => s.ChannelType == channelType);

        return Task.FromResult(sender);
    }
}