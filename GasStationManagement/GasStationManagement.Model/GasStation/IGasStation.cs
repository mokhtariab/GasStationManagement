using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.GasStation
{
    public interface IGasStation
    {
        bool InsertEntity(List<Model.GasStation.GasStation> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.GasStation.GasStation> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.GasStation.GasStation> ListObj, ref string msgRet);

        List<Model.GasStation.VW_GasStation> GetList(ref string msgRet);
        List<Model.GasStation.VW_GasStation> GetListByID(int Id, ref string msgRet);
        List<Model.GasStation.VW_GasStation> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.GasStation.VW_GasStation> ListObj);
    }
}
