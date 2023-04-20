using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.PressTransSupply;

namespace GasStationManagement.ViewModel.PressTransSupply
{
    public class PressTransSupply : IPressTransSupply, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public PressTransSupply()
        {
            
        }
        #endregion

        #region Properties

        DataClassesPressTransSupplyDataContext DRN = new DataClassesPressTransSupplyDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_PressTransSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressTransSupply gh1 in ListObj)
                {
                    DRN.SP_PressTransSupplyInsert(gh1.PressTrans_Id,gh1.PressTransSerialNo,gh1.SupplyDate,
                        gh1.Price,gh1.Suppliers_Id,gh1.Description,gh1.IsActive,ref msgRet);
                }
                DRN.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            
            return false;
        }

        public bool UpdateEntity(List<TBL_PressTransSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressTransSupply gh1 in ListObj)
                {
                    DRN.SP_PressTransSupplyUpdate(gh1.PressTrans_Id, gh1.PressTransSerialNo, gh1.SupplyDate,
                        gh1.Price, gh1.Suppliers_Id, gh1.Description, gh1.IsActive, ref msgRet);
                }
                DRN.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }

            return false;
        }

        public bool DeleteEntity(List<TBL_PressTransSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressTransSupply gh1 in ListObj)
                {
                    DRN.SP_PressTransSupplyDelete(gh1.PressTrans_Id, gh1.PressTransSerialNo, ref msgRet);
                }
                DRN.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return false;
        }

        public List<VW_PressTransSupply> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PressTransSupplies select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PressTransSupply> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PressTransSupplies where d.PressTrans_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PressTransSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_PressTransSupply>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_PressTransSupplies select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_PressTransSupply> ListObj)
        {
            return ListObj.Count();
        }
        #endregion

        #region IDataErrorInfo

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region INotifyPropertyChanged
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        
    }
}
