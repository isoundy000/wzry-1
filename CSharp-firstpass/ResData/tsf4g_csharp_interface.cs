﻿namespace ResData
{
    using System;
    using tsf4g_tdr_csharp;

    public interface tsf4g_csharp_interface : IUnpackable
    {
        TdrError.ErrorType construct();
        TdrError.ErrorType load(ref TdrReadBuf srcBuf, uint cutVer);
        TdrError.ErrorType load(ref byte[] buffer, int size, ref int usedSize, uint cutVer);
        TdrError.ErrorType unpack(ref TdrReadBuf srcBuf, uint cutVer);
    }
}

