using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.TemGageState
{
    public interface ITemGageState
    {
        bool InsertEntity(List<Model.TemGageState.TBL_TemGageState> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.TemGageState.TBL_TemGageState> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.TemGageState.TBL_TemGageState> ListObj, ref string msgRet);

        List<Model.TemGageState.VW_TemGageState> GetList(ref string msgRet);
        List<Model.TemGageState.VW_TemGageState> GetListByID(int Id, ref string msgRet);
        List<Model.TemGageState.VW_TemGageState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.TemGageState.VW_TemGageState> ListObj);
    }
}
