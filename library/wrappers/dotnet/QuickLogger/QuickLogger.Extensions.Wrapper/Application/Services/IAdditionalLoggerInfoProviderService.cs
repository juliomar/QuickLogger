﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickLogger.Extensions.Wrapper.Application.Services
{
    public interface IAdditionalLoggerInfoProviderService
    {
        object GetAdditionalInfo();
    }
}
