using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Server.Contract
{
    public interface ICrud<DO, DF>
    {
        DO Save(DO entity);
        List<DO> Save(List<DO> entities);
        void Delete(DO entity);
        void Delete(List<DO> entities);
        DO GetEntity(DF filter);
        List<DO> GetAll(DF filter);
    }
}
