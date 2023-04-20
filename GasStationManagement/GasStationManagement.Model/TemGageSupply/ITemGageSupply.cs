using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.TemGageSupply
{
    public interface ITemGageSupply
    {
        bool InsertEntity(List<Model.TemGageSupply.TBL_TemGageSupply> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.TemGageSupply.TBL_TemGageSupply> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.TemGageSupply.TBL_TemGageSupply> ListObj, ref string msgRet);

        List<Model.TemGageSupply.VW_TemGageSupply> GetList(ref string msgRet);
        List<Model.TemGageSupply.VW_TemGageSupply> GetListByID(int Id, ref string msgRet);
        List<Model.TemGageSupply.VW_TemGageSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.TemGageSupply.VW_TemGageSupply> ListObj);
    }
}
