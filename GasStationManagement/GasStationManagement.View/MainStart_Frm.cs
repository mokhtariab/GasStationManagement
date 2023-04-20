using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GasStationManagement.View.BaseForms;
using GasStationManagement.View.MainForms;

namespace GasStationManagement.View
{
    public partial class MainStart_Frm : MSS.Library.Forms.MSSMainForm
    {
        public MainStart_Frm()
        {
            InitializeComponent();
            MSS.Library.Clasess.PublicParam.MainForm = this;
        }

        #region Basic Form
        private void buttonItemGasStationType_Click(object sender, EventArgs e)
        {
            GasStationType_Frm SS = new GasStationType_Frm();
            SS.ShowDialog();
        }

        private void buttonItemWorkingPressure_Click(object sender, EventArgs e)
        {
            WorkingPressure_Frm SS = new WorkingPressure_Frm();
            SS.ShowDialog();
        }

        private void buttonItemUseType_Click(object sender, EventArgs e)
        {
            UseType_Frm SS = new UseType_Frm();
            SS.ShowDialog();
        }

        private void buttonItemZoneOperation_Click(object sender, EventArgs e)
        {
            ZoneOperation_Frm SS = new ZoneOperation_Frm();
            SS.ShowDialog();
        }

        private void buttonItemLine_Click(object sender, EventArgs e)
        {
            Line_Frm SS = new Line_Frm();
            SS.ShowDialog();
        }

        private void buttonItemCounterInsLoc_Click(object sender, EventArgs e)
        {
            CounterInsLoc_Frm SS = new CounterInsLoc_Frm();
            SS.ShowDialog();
        }

        private void buttonItemStationLinkType_Click(object sender, EventArgs e)
        {
            StationLinkType_Frm SS = new StationLinkType_Frm();
            SS.ShowDialog();
        }

        private void buttonItemMonitoringSysState_Click(object sender, EventArgs e)
        {
            MonitoringSysState_Frm SS = new MonitoringSysState_Frm();
            SS.ShowDialog();
        }

        private void buttonItemEquipmentState_Click(object sender, EventArgs e)
        {
            EquipmentState_Frm SS = new EquipmentState_Frm();
            SS.ShowDialog();
        }

        private void buttonItemLocationState_Click(object sender, EventArgs e)
        {
            LocationState_Frm SS = new LocationState_Frm();
            SS.ShowDialog();
        }

        private void buttonItemSupplier_Click(object sender, EventArgs e)
        {
            Suppliers_Frm SS = new Suppliers_Frm();
            SS.ShowDialog();
        }

        private void buttonItemStore_Click(object sender, EventArgs e)
        {
            Store_Frm SS = new Store_Frm();
            SS.ShowDialog();
        }

        private void buttonItemWorkShop_Click(object sender, EventArgs e)
        {
            WorkShop_Frm SS = new WorkShop_Frm();
            SS.ShowDialog();
        }

        private void buttonItemCalibration_Click(object sender, EventArgs e)
        {
            Calibration_Frm SS = new Calibration_Frm();
            SS.ShowDialog();
        }

        private void buttonItemParameters_Click(object sender, EventArgs e)
        {
            Parameters_Frm SS = new Parameters_Frm();
            SS.ShowDialog();
        }
        
        #endregion


        #region Main UserControl
        private void buttonItemGasStation_Click(object sender, EventArgs e)
        {
            MainForms.GasStation.GasStation_UC SPU = new MainForms.GasStation.GasStation_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemCounter_Click(object sender, EventArgs e)
        {
            MainForms.Counter.AllCounter_UC SPU = new MainForms.Counter.AllCounter_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemEVCD_Click(object sender, EventArgs e)
        {
            MainForms.EVCD.AllEVCD_UC SPU = new MainForms.EVCD.AllEVCD_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemPressureGage_Click(object sender, EventArgs e)
        {
            MainForms.PressGage.AllPressGage_UC SPU = new MainForms.PressGage.AllPressGage_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemTemperatureGage_Click(object sender, EventArgs e)
        {
            MainForms.TemGage.AllTemGage_UC SPU = new MainForms.TemGage.AllTemGage_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemPressureTransmitter_Click(object sender, EventArgs e)
        {
            MainForms.PressTrans.AllPressTrans_UC SPU = new MainForms.PressTrans.AllPressTrans_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemTemperatureTransmitter_Click(object sender, EventArgs e)
        {
            MainForms.TemTrans.AllTemTrans_UC SPU = new MainForms.TemTrans.AllTemTrans_UC();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        #endregion

        private void buttonItemEVCDLog_Click(object sender, EventArgs e)
        {
            SystemImport.GasStationImport_Uc SPU = new SystemImport.GasStationImport_Uc();
            TabControlMain.AddTabToTabControl(SPU.Name, SPU.Tag.ToString(), SPU);
        }

        private void buttonItemDateSave_Click(object sender, EventArgs e)
        {
            GasStationManagement.View.SystemImport.PerformanceInfoDate_Frm p = new GasStationManagement.View.SystemImport.PerformanceInfoDate_Frm();
            p.ShowDialog();
        }

        private void buttonItemStationSave_Click(object sender, EventArgs e)
        {
            GasStationManagement.View.SystemImport.PerformanceInfoStation_Frm p = new GasStationManagement.View.SystemImport.PerformanceInfoStation_Frm();
            p.ShowDialog();
        }

        private void buttonItemSelectParameter_Click(object sender, EventArgs e)
        {
            GasStationManagement.View.SystemImport.SelectParameter_Frm p = new GasStationManagement.View.SystemImport.SelectParameter_Frm();
            p.ShowDialog();
        }

        private void buttonItemSelectStation_Click(object sender, EventArgs e)
        {
            GasStationManagement.View.SystemImport.SelectStation_Frm p = new GasStationManagement.View.SystemImport.SelectStation_Frm();
            p.ShowDialog();
        }



    }
}
