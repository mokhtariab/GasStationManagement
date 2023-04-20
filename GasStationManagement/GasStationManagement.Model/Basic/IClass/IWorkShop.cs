using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.Basic.IClass
{
    public interface IWorkShop
    {
        bool InsertEntity(List<Model.Basic.DataAccess.TBL_WorkShop> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.Basic.DataAccess.TBL_WorkShop> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.Basic.DataAccess.TBL_WorkShop> ListObj, ref string msgRet);

        List<Model.Basic.DataAccess.TBL_WorkShop> GetList(ref string msgRet);
        List<Model.Basic.DataAccess.TBL_WorkShop> GetListByID(int Id, ref string msgRet);
        List<Model.Basic.DataAccess.TBL_WorkShop> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.Basic.DataAccess.TBL_WorkShop> ListObj);
    }
}
