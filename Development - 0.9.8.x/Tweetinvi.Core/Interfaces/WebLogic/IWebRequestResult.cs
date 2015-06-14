﻿using System.IO;

namespace Tweetinvi.Core.Interfaces.WebLogic
{
    public interface IWebRequestResult
    {
        string URL { get; set; }
        Stream ResultStream { get; set; }
        int StatusCode { get; set; }
        bool IsSuccessStatusCode { get; set; }
    }
}
