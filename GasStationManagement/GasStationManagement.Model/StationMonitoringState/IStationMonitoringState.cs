using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.StationMonitoringState
{
    public interface IStationMonitoringState
    {
        bool InsertEntity(List<Model.StationMonitoringState.TBL_StationMonitoringState> ListObj, ref string msgRet, ref int? id);
        bool UpdateEntity(List<Model.StationMonitoringState.TBL_StationMonitoringState> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.StationMonitoringState.TBL_StationMonitoringState> ListObj, ref string msgRet);

        List<Model.StationMonitoringState.VW_StationMonitoringState> GetList(ref string msgRet);
        List<Model.StationMonitoringState.VW_StationMonitoringState> GetListByID(int Id, ref string msgRet);
        List<Model.StationMonitoringState.VW_StationMonitoringState> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.StationMonitoringState.VW_StationMonitoringState> ListObj);
    }
}
