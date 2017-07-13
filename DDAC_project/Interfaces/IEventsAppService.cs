using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DDAC_project.Models;

namespace DDAC_project.Interfaces
{
    public interface IEventsAppService
    {
        Task<IEnumerable<ActiveDirectoryUser>> ActiveDirectoryUsersAsync();
    }
}