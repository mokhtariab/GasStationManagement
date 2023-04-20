using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.StationMonitoringStateParameters
{
    public interface IStationMonitoringStateParameters
    {
        bool InsertEntity(List<Model.StationMonitoringStateParameters.TBL_StationMonitoringStateParameter> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.StationMonitoringStateParameters.TBL_StationMonitoringStateParameter> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.StationMonitoringStateParameters.TBL_StationMonitoringStateParameter> ListObj, ref string msgRet);

        List<Model.StationMonitoringStateParameters.VW_StationMonitoringStateParameter> GetList(ref string msgRet);
        List<Model.StationMonitoringStateParameters.VW_StationMonitoringStateParameter> GetListByID(int Id, ref string msgRet);
        List<Model.StationMonitoringStateParameters.VW_StationMonitoringStateParameter> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.StationMonitoringStateParameters.VW_StationMonitoringStateParameter> ListObj);
    }
}
