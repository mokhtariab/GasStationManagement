using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.EVCDState
{
    public interface IEVCDState
    {
        bool InsertEntity(List<Model.EVCDState.TBL_EVCDState> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.EVCDState.TBL_EVCDState> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.EVCDState.TBL_EVCDState> ListObj, ref string msgRet);

        List<Model.EVCDState.VW_EVCDState> GetList(ref string msgRet);
        List<Model.EVCDState.VW_EVCDState> GetListByID(int Id, ref string msgRet);
        List<Model.EVCDState.VW_EVCDState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.EVCDState.VW_EVCDState> ListObj);
    }
}
