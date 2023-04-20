using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.TemTransSupply;

namespace GasStationManagement.ViewModel.TemTransSupply
{
    public class TemTransSupply : ITemTransSupply, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public TemTransSupply()
        {
            
        }
        #endregion

        #region Properties

        DataClassesTemTransSupplyDataContext DRN = new DataClassesTemTransSupplyDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_TemTransSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_TemTransSupply gh1 in ListObj)
                {
                    DRN.SP_TemTransSupplyInsert(gh1.TemTrans_Id,gh1.TemTransSerialNo,gh1.SupplyDate,
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

        public bool UpdateEntity(List<TBL_TemTransSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_TemTransSupply gh1 in ListObj)
                {
                    DRN.SP_TemTransSupplyUpdate(gh1.TemTrans_Id, gh1.TemTransSerialNo, gh1.SupplyDate,
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

        public bool DeleteEntity(List<TBL_TemTransSupply> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_TemTransSupply gh1 in ListObj)
                {
                    DRN.SP_TemTransSupplyDelete(gh1.TemTrans_Id, gh1.TemTransSerialNo, ref msgRet);
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

        public List<VW_TemTransSupply> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_TemTransSupplies select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_TemTransSupply> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.VW_TemTransSupplies where d.TemTrans_Id == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<VW_TemTransSupply> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<VW_TemTransSupply>(filter).Compile();
                var filteredCollection = (from d in DRN.VW_TemTransSupplies select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<VW_TemTransSupply> ListObj)
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
