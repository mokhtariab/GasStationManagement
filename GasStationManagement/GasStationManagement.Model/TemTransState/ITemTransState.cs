using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.TemTransState
{
    public interface ITemTransState
    {
        bool InsertEntity(List<Model.TemTransState.TBL_TemTransState> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.TemTransState.TBL_TemTransState> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.TemTransState.TBL_TemTransState> ListObj, ref string msgRet);

        List<Model.TemTransState.VW_TemTransState> GetList(ref string msgRet);
        List<Model.TemTransState.VW_TemTransState> GetListByID(int Id, ref string msgRet);
        List<Model.TemTransState.VW_TemTransState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.TemTransState.VW_TemTransState> ListObj);
    }
}
