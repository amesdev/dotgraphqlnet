using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotgraphql
{
    public interface IQuery : IObjectGraphType
    {
        void ConfigureFields();
    }
}