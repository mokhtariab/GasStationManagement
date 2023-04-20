using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.CounterSupply
{
    public interface ICounterSupply
    {
        bool InsertEntity(List<Model.CounterSupply.TBL_CounterSupply> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.CounterSupply.TBL_CounterSupply> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.CounterSupply.TBL_CounterSupply> ListObj, ref string msgRet);

        List<Model.CounterSupply.VW_CounterSupply> GetList(ref string msgRet);
        List<Model.CounterSupply.VW_CounterSupply> GetListByID(int Id, ref string msgRet);
        List<Model.CounterSupply.VW_CounterSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.CounterSupply.VW_CounterSupply> ListObj);
    }
}
