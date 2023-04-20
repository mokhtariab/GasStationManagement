using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.PressGageSupply;

namespace GasStationManagement.ViewModel.PressGageSupply
{
    public class PressGageSupply : IPressGageSupply, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public PressGageSupply()
        {
            
        }
        #endregion

        #region Properties

        DataClassesPressGageSupplyDataContext DRN = new DataClassesPressGageSupplyDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_PressGageSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressGageSupply gh1 in ListObj)
                {
                    DRN.SP_PressGageSupplyInsert(gh1.PressGage_Id,gh1.PressGageSerialNo,gh1.SupplyDate,
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

        public bool UpdateEntity(List<TBL_PressGageSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressGageSupply gh1 in ListObj)
                {
                    DRN.SP_PressGageSupplyUpdate(gh1.PressGage_Id, gh1.PressGageSerialNo, gh1.SupplyDate,
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

        public bool DeleteEntity(List<TBL_PressGageSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_PressGageSupply gh1 in ListObj)
                {
                    DRN.SP_PressGageSupplyDelete(gh1.PressGage_Id, gh1.PressGageSerialNo, ref msgRet);
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

        public List<VW_PressGageSupply> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PressGageSupplies select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PressGageSupply> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_PressGageSupplies where d.PressGage_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_PressGageSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_PressGageSupply>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_PressGageSupplies select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_PressGageSupply> ListObj)
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
