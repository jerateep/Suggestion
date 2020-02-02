using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGO.ViewModels;

namespace SGO.Web.Data
{
    public static class DBinitialize
    {
        public static void INIT(IServiceProvider serviceProvider)
        {
            var context = new MySQLContext(serviceProvider.GetRequiredService<DbContextOptions<MySQLContext>>());
            context.Database.EnsureCreated();
            if (context.SGO_Type.Any())
            {
                return;
            }
            context.SGO_Approver.AddRange(new DummyData().GetManagerApprover());
            context.SaveChanges();
            context.SGO_Department.AddRange(new DummyData().GetDepartment());
            context.SaveChanges();
            context.SGO_HEAD.AddRange(new DummyData().GetHead());
            context.SaveChanges();
            context.SGO_SHIFT.AddRange(new DummyData().GetShift());
            context.SaveChanges();
            context.SGO_Status.AddRange(new DummyData().GetStatus());
            context.SaveChanges();
            context.SGO_TEAM.AddRange(new DummyData().GetTeamApprover());
            context.SaveChanges();
            context.SGO_Type.AddRange(new DummyData().GetTypeSGO());
            context.SaveChanges();
        }
    }
}
