using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GasStationManagement.Model.Basic.IClass;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.ViewModel.Basic
{
    public class Monitoring : IMonitoring, IDataErrorInfo, INotifyPropertyChanged
    {
        #region Constructor
       
        public Monitoring()
        {
            
        }
        #endregion

        #region Properties

        DataClassesBaseDataContext DRN = new DataClassesBaseDataContext(MSS.Library.Clasess.IniFilesSet.ReadFromXmlFiles("ConnectionDef"));
        public bool InsertEntity(List<TBL_Monitoring> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Monitoring gh1 in ListObj)
                {
                    DRN.SP_MonitoringInsert(gh1.ID, gh1.Brand, gh1.Size, gh1.Class, gh1.Grate, gh1.IsActive, gh1.Description,ref msgRet);
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

        public bool UpdateEntity(List<TBL_Monitoring> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Monitoring gh1 in ListObj)
                {
                    DRN.SP_MonitoringUpdate(gh1.ID, gh1.Brand, gh1.Size, gh1.Class, gh1.Grate, gh1.IsActive, gh1.Description, ref msgRet);
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

        public bool DeleteEntity(List<TBL_Monitoring> ListObj, ref string msgRet)
        {
            try
            {
                foreach (TBL_Monitoring gh1 in ListObj)
                {
                    DRN.SP_MonitoringDelete(gh1.ID,ref msgRet);
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

        public List<TBL_Monitoring> GetList(ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_Monitorings select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_Monitoring> GetListByID(int Id, ref string msgRet)
        {
            try
            {
                return (from d in DRN.TBL_Monitorings where d.ID == Id select d).ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public List<TBL_Monitoring> GetListByFilter(List<MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet)
        {
            try
            {
                var deleg = MSS.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.GetExpression<TBL_Monitoring>(filter).Compile();
                var filteredCollection = (from d in DRN.TBL_Monitorings select d).Where(deleg);
                return filteredCollection.ToList();
            }
            catch (Exception ex)
            {
                msgRet = ex.Message;
            }
            return null;
        }

        public int CountAll(List<TBL_Monitoring> ListObj)
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
