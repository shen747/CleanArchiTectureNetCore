using Template.Application.Common.Interfaces;
using System;

namespace Template.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
