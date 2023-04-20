using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.TemGageSupply;

namespace GasStationManagement.ViewModel.TemGageSupply
{
    public class TemGageSupply : ITemGageSupply, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public TemGageSupply()
        {
            
        }
        #endregion

        #region Properties

        DataClassesTemGageSupplyDataContext DRN = new DataClassesTemGageSupplyDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_TemGageSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_TemGageSupply gh1 in ListObj)
                {
                    DRN.SP_TemGageSupplyInsert(gh1.TemGage_Id,gh1.TemGageSerialNo,gh1.SupplyDate,
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

        public bool UpdateEntity(List<TBL_TemGageSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_TemGageSupply gh1 in ListObj)
                {
                    DRN.SP_TemGageSupplyUpdate(gh1.TemGage_Id, gh1.TemGageSerialNo, gh1.SupplyDate,
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

        public bool DeleteEntity(List<TBL_TemGageSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_TemGageSupply gh1 in ListObj)
                {
                    DRN.SP_TemGageSupplyDelete(gh1.TemGage_Id,gh1.TemGageSerialNo, ref msgRet);
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

        public List<VW_TemGageSupply> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_TemGageSupplies select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_TemGageSupply> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_TemGageSupplies where d.TemGage_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_TemGageSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_TemGageSupply>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_TemGageSupplies select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_TemGageSupply> ListObj)
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
