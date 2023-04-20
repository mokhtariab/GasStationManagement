using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.TemTransSupply
{
    public interface ITemTransSupply
    {
        bool InsertEntity(List<Model.TemTransSupply.TBL_TemTransSupply> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.TemTransSupply.TBL_TemTransSupply> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.TemTransSupply.TBL_TemTransSupply> ListObj, ref string msgRet);

        List<Model.TemTransSupply.VW_TemTransSupply> GetList(ref string msgRet);
        List<Model.TemTransSupply.VW_TemTransSupply> GetListByID(int Id, ref string msgRet);
        List<Model.TemTransSupply.VW_TemTransSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.TemTransSupply.VW_TemTransSupply> ListObj);
    }
}
