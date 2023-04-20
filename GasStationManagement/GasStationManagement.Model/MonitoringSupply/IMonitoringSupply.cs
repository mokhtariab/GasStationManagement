using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.MonitoringSupply
{
    public interface IMonitoringSupply
    {
        bool InsertEntity(List<Model.MonitoringSupply.TBL_MonitoringSupply> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.MonitoringSupply.TBL_MonitoringSupply> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.MonitoringSupply.TBL_MonitoringSupply> ListObj, ref string msgRet);

        List<Model.MonitoringSupply.TBL_MonitoringSupply> GetList(ref string msgRet);
        List<Model.MonitoringSupply.TBL_MonitoringSupply> GetListByID(int Id, ref string msgRet);
        List<Model.MonitoringSupply.TBL_MonitoringSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.MonitoringSupply.TBL_MonitoringSupply> ListObj);
    }
}
