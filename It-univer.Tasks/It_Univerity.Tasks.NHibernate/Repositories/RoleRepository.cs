using It_Univer.Tasks.Entities;
using It_Univer.Tasks.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace It_University.Tasks.NHibernate.Repositories
{
    public class RoleRepository : NhRepositoryBase<Role, int>, IRoleRepository
    {
        public RoleRepository(ISession session) : base(session)
        { }
    }
}
