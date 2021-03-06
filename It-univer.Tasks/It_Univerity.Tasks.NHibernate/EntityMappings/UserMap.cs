﻿using It_Univer.Tasks.Entities;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace It_University.Tasks.NHibernate.EntityMappings
{
    public class UserMap : ClassMapping<User>
    {
        /// <summary>
        /// Инициализировать экземпляр <see cref="UserMap"/>
        /// </summary>
        public UserMap()
        {
            Id(x => x.Id, x =>
            {
                x.Generator(Generators.Increment);
                x.Type(NHibernateUtil.Int32);
                x.Column("Id");
            });

            Property(b => b.Login, x =>
            {
                x.Type(NHibernateUtil.String);
            });

            Property(b => b.Email, x =>
            {
                x.Type(NHibernateUtil.String);
            });

            Property(b => b.Password, x =>
            {
                x.Type(NHibernateUtil.String);
            });

            Property(b => b.IsBlocked, x =>
            {
                x.Type(NHibernateUtil.Boolean);
            });

            ManyToOne(property => property.Role, mapping =>
            {
                mapping.Column("RoleId");
                mapping.Cascade(Cascade.All);
            });

            Table(User.TableName);
        }
    }
}
