using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.CounterState
{
    public interface ICounterState
    {
        bool InsertEntity(List<Model.CounterState.TBL_CounterState> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.CounterState.TBL_CounterState> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.CounterState.TBL_CounterState> ListObj, ref string msgRet);

        List<Model.CounterState.VW_CounterState> GetList(ref string msgRet);
        List<Model.CounterState.VW_CounterState> GetListByID(int Id, ref string msgRet);
        List<Model.CounterState.VW_CounterState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.CounterState.VW_CounterState> ListObj);
    }
}
