using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.Data
{
    public class CityGuideContext: DbContext
    {
        public CityGuideContext() : base("DefaultConnection")
        {
             
        }
    }
}
