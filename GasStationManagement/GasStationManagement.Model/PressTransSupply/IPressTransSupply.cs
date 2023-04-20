using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GasStationManagement.Model.PressTransSupply
{
    public interface IPressTransSupply
    {
        bool InsertEntity(List<Model.PressTransSupply.TBL_PressTransSupply> ListObj, ref string msgRet);
        bool UpdateEntity(List<Model.PressTransSupply.TBL_PressTransSupply> ListObj, ref string msgRet);
        bool DeleteEntity(List<Model.PressTransSupply.TBL_PressTransSupply> ListObj, ref string msgRet);

        List<Model.PressTransSupply.VW_PressTransSupply> GetList(ref string msgRet);
        List<Model.PressTransSupply.VW_PressTransSupply> GetListByID(int Id, ref string msgRet);
        List<Model.PressTransSupply.VW_PressTransSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<Model.PressTransSupply.VW_PressTransSupply> ListObj);
    }
}
