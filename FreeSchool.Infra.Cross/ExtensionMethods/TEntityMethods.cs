using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Infra.Cross
{
    public static class TEntityMethods
    {
        public static TDest MapTo<TDest>(this object src)
        {
            return (TDest)Mapper.Map(src, src.GetType(), typeof(TDest));
        }
    }
}
