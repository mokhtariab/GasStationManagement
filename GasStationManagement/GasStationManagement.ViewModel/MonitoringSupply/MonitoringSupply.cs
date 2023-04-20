using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.MonitoringSupply;

namespace GasStationManagement.ViewModel.MonitoringSupply
{
    public class MonitoringSupply : IMonitoringSupply, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public MonitoringSupply()
        {
            
        }
        #endregion

        #region Properties

        DataClassesMonitoringSupplyDataContext DRN = new DataClassesMonitoringSupplyDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_MonitoringSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_MonitoringSupply gh1 in ListObj)
                {
                    DRN.SP_MonitoringSupplyInsert(gh1.Monitoring_Id,gh1.MonitoringSerialNo,gh1.InitialVc,gh1.SupplyDate,
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

        public bool UpdateEntity(List<TBL_MonitoringSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_MonitoringSupply gh1 in ListObj)
                {
                    DRN.SP_MonitoringSupplyUpdate(gh1.Monitoring_Id, gh1.MonitoringSerialNo, gh1.InitialVc, gh1.SupplyDate,
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

        public bool DeleteEntity(List<TBL_MonitoringSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_MonitoringSupply gh1 in ListObj)
                {
                    DRN.SP_MonitoringSupplyDelete(gh1.Monitoring_Id,ref msgRet);
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

        public List<TBL_MonitoringSupply> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_MonitoringSupplies select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_MonitoringSupply> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_MonitoringSupplies where d.Monitoring_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_MonitoringSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<TBL_MonitoringSupply>(filter).Compile();
                var filteredCollection = (from d in DRN.TBL_MonitoringSupplies select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<TBL_MonitoringSupply> ListObj)
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
