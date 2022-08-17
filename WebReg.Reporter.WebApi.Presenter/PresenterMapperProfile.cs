using AutoMapper;
using WebReg.Reporter.Domain.Common;
using WebReg.Reporter.Domain.Contracts.Interfaces;
using WebReg.Reporter.WebApi.Contracts.Dto;

namespace WebReg.Reporter.WebApi.Presenter;

public class PresenterMapperProfile : Profile
{
    public PresenterMapperProfile()
    {
        CreateMap<IReport, ReportViewDto>()
            .ForMember(dst => dst.ChannelName, opt => opt.MapFrom(src => src.Channel.GetEnumDisplayDescription()));
    }
}