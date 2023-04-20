using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.EVCDSupply;

namespace GasStationManagement.ViewModel.EVCDSupply
{
    public class EVCDSupply : IEVCDSupply, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public EVCDSupply()
        {
            
        }
        #endregion

        #region Properties

        DataClassesEVCDSupplyDataContext DRN = new DataClassesEVCDSupplyDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_EVCDSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_EVCDSupply gh1 in ListObj)
                {
                    DRN.SP_EVCDSupplyInsert(gh1.EVCD_Id, gh1.EVCDSerialNo, gh1.SupplyDate, gh1.Price,
                        gh1.InitialVm, gh1.TEVCDSerialNo,
                        gh1.PEVCDSerialNo, gh1.Suppliers_Id, gh1.Description, gh1.IsActive, ref msgRet);
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

        public bool UpdateEntity(List<TBL_EVCDSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_EVCDSupply gh1 in ListObj)
                {
                    DRN.SP_EVCDSupplyUpdate(gh1.EVCD_Id, gh1.EVCDSerialNo, gh1.SupplyDate, gh1.Price,
                        gh1.InitialVm, gh1.TEVCDSerialNo,
                        gh1.PEVCDSerialNo, gh1.Suppliers_Id, gh1.Description, gh1.IsActive, ref msgRet);
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

        public bool DeleteEntity(List<TBL_EVCDSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_EVCDSupply gh1 in ListObj)
                {
                    DRN.SP_EVCDSupplyDelete(gh1.EVCD_Id, gh1.EVCDSerialNo, ref msgRet);
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

        public List<VW_EVCDSupply> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_EVCDSupplies select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_EVCDSupply> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_EVCDSupplies where d.EVCD_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_EVCDSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_EVCDSupply>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_EVCDSupplies select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_EVCDSupply> ListObj)
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
