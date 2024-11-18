using DocumentFlowApp.Common.Entities;
using Laraue.EfCoreTriggers.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFlowApp.DataAccess
{
    public static class EntityTypeBuilderExtensions
    {
        public static void ConfigureBaseEntity<T>(this EntityTypeBuilder<T> builder)
            where T : class, IBaseEntity
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityByDefaultColumn();
        }
    }
}
