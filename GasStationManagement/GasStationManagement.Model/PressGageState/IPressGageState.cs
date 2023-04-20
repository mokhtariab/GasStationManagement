using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.PressGageState
{
    public interface IPressGageState
    {
        bool InsertEntity(List<Model.PressGageState.TBL_PressGageState> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.PressGageState.TBL_PressGageState> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.PressGageState.TBL_PressGageState> ListObj, ref string msgRet);

        List<Model.PressGageState.VW_PressGageState> GetList(ref string msgRet);
        List<Model.PressGageState.VW_PressGageState> GetListByID(int Id, ref string msgRet);
        List<Model.PressGageState.VW_PressGageState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.PressGageState.VW_PressGageState> ListObj);
    }
}
