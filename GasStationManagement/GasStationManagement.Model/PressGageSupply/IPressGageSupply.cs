using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.PressGageSupply
{
    public interface IPressGageSupply
    {
        bool InsertEntity(List<Model.PressGageSupply.TBL_PressGageSupply> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.PressGageSupply.TBL_PressGageSupply> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.PressGageSupply.TBL_PressGageSupply> ListObj, ref string msgRet);

        List<Model.PressGageSupply.VW_PressGageSupply> GetList(ref string msgRet);
        List<Model.PressGageSupply.VW_PressGageSupply> GetListByID(int Id, ref string msgRet);
        List<Model.PressGageSupply.VW_PressGageSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.PressGageSupply.VW_PressGageSupply> ListObj);
    }
}
