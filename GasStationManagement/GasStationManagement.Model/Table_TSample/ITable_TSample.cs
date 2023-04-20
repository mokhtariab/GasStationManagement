using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.Table_TSample
{
    public interface ITable_TSample
    {
        bool InsertEntity(List<Model.Table_TSample.Table_TSample> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.Table_TSample.Table_TSample> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.Table_TSample.Table_TSample> ListObj, ref string msgRet);

        List<Model.Table_TSample.Table_TSample> GetList(ref string msgRet);
        List<Model.Table_TSample.Table_TSample> GetListByID(int Id, ref string msgRet);
        List<Model.Table_TSample.Table_TSample> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.Table_TSample.Table_TSample> ListObj);
    }
}
