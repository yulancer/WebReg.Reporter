﻿using WebReg.Reporter.Domain.Contracts.Enums;
using WebReg.Reporter.Domain.Contracts.Interfaces;
using WebReg.Reporter.Domain.Contracts.ValueObjects;

namespace ReportsDto;

public class Customer : ICustomer
{
    public CustomerName Name { get; set; }

    public string AddressStr { get; set; }

    public string Address(ChannelType channel) => AddressStr;
}