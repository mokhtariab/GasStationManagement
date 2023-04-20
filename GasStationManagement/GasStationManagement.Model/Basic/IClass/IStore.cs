using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.Basic.IClass
{
    public interface IStore
    {
        bool InsertEntity(List<Model.Basic.DataAccess.TBL_Store> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.Basic.DataAccess.TBL_Store> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.Basic.DataAccess.TBL_Store> ListObj, ref string msgRet);

        List<Model.Basic.DataAccess.TBL_Store> GetList(ref string msgRet);
        List<Model.Basic.DataAccess.TBL_Store> GetListByID(int Id, ref string msgRet);
        List<Model.Basic.DataAccess.TBL_Store> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.Basic.DataAccess.TBL_Store> ListObj);
    }
}
