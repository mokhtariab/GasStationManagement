using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.CounterSupply;

namespace GasStationManagement.ViewModel.CounterSupply
{
    public class CounterSupply : ICounterSupply, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public CounterSupply()
        {
            
        }
        #endregion

        #region Properties

        DataClassesCounterSupplyDataContext DRN = new DataClassesCounterSupplyDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_CounterSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_CounterSupply gh1 in ListObj)
                {
                    DRN.SP_CounterSupplyInsert(gh1.Counter_Id,gh1.CounterSerialNo,gh1.SupplyDate,
                        gh1.Price, gh1.InitialVc, gh1.Suppliers_Id, gh1.Description, gh1.IsActive, ref msgRet);
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

        public bool UpdateEntity(List<TBL_CounterSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_CounterSupply gh1 in ListObj)
                {
                    DRN.SP_CounterSupplyUpdate(gh1.Counter_Id, gh1.CounterSerialNo, gh1.SupplyDate,
                        gh1.Price, gh1.InitialVc, gh1.Suppliers_Id, gh1.Description, gh1.IsActive, ref msgRet);
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

        public bool DeleteEntity(List<TBL_CounterSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_CounterSupply gh1 in ListObj)
                {
                    DRN.SP_CounterSupplyDelete(gh1.Counter_Id,gh1.CounterSerialNo, ref msgRet);
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

        public List<VW_CounterSupply> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_CounterSupplies select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_CounterSupply> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_CounterSupplies where d.Counter_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_CounterSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_CounterSupply>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_CounterSupplies select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_CounterSupply> ListObj)
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
