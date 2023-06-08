using System;
using HotelDotNet.Models;

namespace HotelDotNet.Contracts
{
    public interface IEmailSender
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
