using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.EVCDSupply
{
    public interface IEVCDSupply
    {
        bool InsertEntity(List<Model.EVCDSupply.TBL_EVCDSupply> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.EVCDSupply.TBL_EVCDSupply> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.EVCDSupply.TBL_EVCDSupply> ListObj, ref string msgRet);

        List<Model.EVCDSupply.VW_EVCDSupply> GetList(ref string msgRet);
        List<Model.EVCDSupply.VW_EVCDSupply> GetListByID(int Id, ref string msgRet);
        List<Model.EVCDSupply.VW_EVCDSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.EVCDSupply.VW_EVCDSupply> ListObj);
    }
}
