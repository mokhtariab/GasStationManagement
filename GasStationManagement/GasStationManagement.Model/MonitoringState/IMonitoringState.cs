using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.MonitoringState
{
    public interface IMonitoringState
    {
        bool InsertEntity(List<Model.MonitoringState.TBL_MonitoringState> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.MonitoringState.TBL_MonitoringState> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.MonitoringState.TBL_MonitoringState> ListObj, ref string msgRet);

        List<Model.MonitoringState.TBL_MonitoringState> GetList(ref string msgRet);
        List<Model.MonitoringState.TBL_MonitoringState> GetListByID(int Id, ref string msgRet);
        List<Model.MonitoringState.TBL_MonitoringState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.MonitoringState.TBL_MonitoringState> ListObj);
    }
}
