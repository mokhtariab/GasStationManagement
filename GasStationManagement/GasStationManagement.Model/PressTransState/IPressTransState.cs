using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.PressTransState
{
    public interface IPressTransState
    {
        bool InsertEntity(List<Model.PressTransState.TBL_PressTransState> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.PressTransState.TBL_PressTransState> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.PressTransState.TBL_PressTransState> ListObj, ref string msgRet);

        List<Model.PressTransState.VW_PressTransState> GetList(ref string msgRet);
        List<Model.PressTransState.VW_PressTransState> GetListByID(int Id, ref string msgRet);
        List<Model.PressTransState.VW_PressTransState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.PressTransState.VW_PressTransState> ListObj);
    }
}
