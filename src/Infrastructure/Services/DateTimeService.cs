using SeaDent.Application.Common.Interfaces;

namespace SeaDent.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
