using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt_050216b.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
