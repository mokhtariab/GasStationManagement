using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using MSS.Library.Clasess;
using MSS.Library.Clasess.Filing;

namespace MSS.Library.Forms
{
    public partial class MSSImageSelector_frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        int _persCode = 0;
        string _addressPhysicPic = "", _addressPhysicFilm = "";
        string _addressPhysic = MSS.Library.Clasess.PublicParam.AddressFile;

        public List<Clasess.Filing.FileTableList> FTList;
        public List<Clasess.Filing.PermissionButtonList> PBList;
        public MSSImageSelector_frm(List<Clasess.Filing.FileTableList> FileTableListValue)
        {
            InitializeComponent();
            FTList = FileTableListValue;
        }
        public MSSImageSelector_frm(List<Clasess.Filing.FileTableList> FileTableListValue, List<Clasess.Filing.PermissionButtonList> PermissionButtonListValue)
        {
            InitializeComponent();
            FTList = FileTableListValue;

            bubbleButton_FilmNew.Enabled = PermissionButtonListValue[0].PermissionFileNew;
            bubbleButton_FilmDel.Enabled = PermissionButtonListValue[0].PermissionFileDel;
            bubbleButton_PicNew.Enabled = PermissionButtonListValue[0].PermissionPicNew;
            bubbleButton_PicDel.Enabled = PermissionButtonListValue[0].PermissionPicDel;
        }

        private void MSSImageSelector_frm_Load(object sender, EventArgs e)
        {
            if (FTList != null)
                LoadPics_Films(FTList);
            else
                FTList = new List<FileTableList>();
        }










        #region OK Data
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (OkFunction())
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool OkFunction()
        {
            //try
            //{
            //    SavePics_Films();
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}


            return true;
        }

        #endregion



        #region Pics & Films New

        private int PicCounter = 0;
        private int FilmCounter = 0;
        private PictureBox ImgPic = null;

        private void LoadPics_Films(List<Clasess.Filing.FileTableList> FileTableList)
        {
            foreach (var PicFilm in FileTableList)
            {
                //pics
                if (PicFilm.file_type == FileTypeForImageSelector.PicFile)
                {
                    AddToListViewPic(PicFilm.FileName, PicFilm.file_stream, PicCounter);
                    PicCounter++;
                }

                //films
                if (PicFilm.file_type == FileTypeForImageSelector.FilmFile)
                {
                    AddToListViewFilm(PicFilm.FileName, PicFilm.file_stream, FilmCounter);
                    FilmCounter++;
                }
            }
        }


        private List<Clasess.Filing.FileTableList> SavePics_Films()
        {
            //List<Clasess.Filing.FileTableList> ANDC = new List<Clasess.Filing.FileTableList>();
            //Clasess.Filing.FileTableList ACCC;

            //for (int i = 0; i < imageList_LargePic.Images.Count; i++)
            //{
            //    ACCC = new Clasess.Filing.FileTableList();


            //    imageList_LargePic.Images[i].Save(listView_Pic.Items[i].Name);
            //    ACCC.file_stream = new FileStream(listView_Pic.Items[i].Name, FileMode.Open);

            //    ACCC.file_type = "Jpg";
            //    ACCC.name = listView_Pic.Items[i].Name;
            //    ACCC.file_stream = new System.IO.FileStream(listView_Pic.Items[i].Name, System.IO.FileMode.Open);

            //    ANDC.Add(ACCC);
            //}

            return FTList;
        }

        //pics

        private void AddToListViewPic(string PicFileName, System.IO.FileStream ItemName, int PicCnt)
        {
            ImgPic = new PictureBox();
            ImgPic.Image = Image.FromStream(ItemName);
            //ImgPic.Image = PublicClass.resizeImage(ImgPic.Image);
            imageList_LargePic.Images.Add(ImgPic.Image);
            imageList_SmallPic.Images.Add(ImgPic.Image);
            listView_Pic.Items.Add(PicFileName, PicFileName, PicCnt);
        }

        private void AddToListViewPic(string PicFileName, string ItemName, int PicCnt)
        {
            ImgPic = new PictureBox();
            ImgPic.Load(ItemName);
            //ImgPic.Image = PublicClass.resizeImage(ItemName);
            imageList_LargePic.Images.Add(ImgPic.Image);
            imageList_SmallPic.Images.Add(ImgPic.Image);
            listView_Pic.Items.Add(ItemName, PicFileName, PicCnt);
        }


        private void AddToListViewFilm(string FilmFileName, System.IO.FileStream ItemName, int FilmCnt)
        {
            ImgPic = new PictureBox();
            //ImgPic.Image = Properties.Resources.Templete;
            ImgPic.Image = Properties.Resources.File;
            imageList_LargeFilm.Images.Add(ImgPic.Image);
            imageList_SmallFilm.Images.Add(ImgPic.Image);
            listView_Film.Items.Add(FilmFileName, FilmFileName, FilmCnt);
        }


        private static FileTableList AddClassList(string PicFileName, System.IO.FileStream ItemName, FileTypeForImageSelector FTImage, FileViewForImageSelector FVImage)
        {
            Clasess.Filing.FileTableList f = new Clasess.Filing.FileTableList();
            f.file_stream = ItemName;
            f.FileName = PicFileName;
            f.file_type = FTImage;
            f.File_View = FVImage;

            return f;
        }

        #region Pic Button
        private void bubbleButton_PicNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All image file|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.ico";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = ofd.SafeFileNames;
                string[] filePaths = ofd.FileNames;
                for (int i = 0; i < ofd.FileNames.Count(); i++)
                {
                    try
                    {
                        if (listView_Pic.FindItemWithText(selectedFiles[i]).Index != null)
                        {
                            Clasess.MSSMessage.MSSMessage_View("فایل " + selectedFiles[i] + " تکراری است", MSS.Library.Clasess.MSSMessage.MessageType.SWarning);
                            continue;
                        }
                    }
                    catch { }
                    
                    try
                    {
                        FileStream fs = new System.IO.FileStream(filePaths[i], System.IO.FileMode.Open, FileAccess.Read);
                       // fs = PublicClass.resizeImageStream(fs);
                        FileTableList f = AddClassList(selectedFiles[i], fs, FileTypeForImageSelector.PicFile, FileViewForImageSelector.InsertFile);
                        FTList.Add(f);
                        AddToListViewPic(selectedFiles[i], filePaths[i], PicCounter);
                        PicCounter++;
                    }
                    catch { }
                }
            }
        }


        private void bubbleButton_PicDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0)
                if (Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "فایل مورد نظر حذف شود؟"))
                {
                    foreach (Clasess.Filing.FileTableList mc in FTList)
                    {
                        if (mc.FileName == listView_Pic.SelectedItems[0].Name)
                            mc.File_View = FileViewForImageSelector.DeleteFile;
                    }
                    listView_Pic.SelectedItems[0].Remove();
                }
        }

        private void bubbleButton_PicView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0) Process.Start(listView_Pic.SelectedItems[0].Name);
        }

        private void bubbleButton_IconPic_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.View == View.LargeIcon)
                listView_Pic.View = View.Tile;
            else if (listView_Pic.View == View.Tile)
                listView_Pic.View = View.SmallIcon;
            else if (listView_Pic.View == View.SmallIcon)
                listView_Pic.View = View.List;
            else listView_Pic.View = View.LargeIcon;
        }

        private void listView_Pic_DoubleClick(object sender, EventArgs e)
        {
            bubbleButton_PicView_Click(this, null);
        }

        #endregion



        #region Film Button
        private void bubbleButton_FilmNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Video file|*.wmv;*.avi;*.mpeg;*.3gp;*.mp4;*.mp3;*.dat;*.mov;*.divx;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = ofd.SafeFileNames;
                string[] filePaths = ofd.FileNames;

                for (int i = 0; i < ofd.FileNames.Count(); i++)
                {
                    try
                    {
                        if (listView_Film.FindItemWithText(selectedFiles[i]).Index != null)
                        {
                            Clasess.MSSMessage.MSSMessage_View("فایل " + selectedFiles[i] + " تکراری است", MSS.Library.Clasess.MSSMessage.MessageType.SWarning);
                            continue;
                        }
                    }
                    catch { }
                    try
                    {
                        FileStream fs = new System.IO.FileStream(filePaths[i], System.IO.FileMode.Open, FileAccess.Read);
                        FileTableList f = AddClassList(selectedFiles[i], fs, FileTypeForImageSelector.FilmFile, FileViewForImageSelector.InsertFile);
                        FTList.Add(f);
                        AddToListViewFilm(selectedFiles[i], fs, FilmCounter);
                        FilmCounter++;
                    }
                    catch
                    { 
                    }
                }

            }

        }

        private void bubbleButton_FilmDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Film.SelectedItems.Count != 0)
                if (Clasess.MSSMessage.MSSMessage_View(0, Clasess.MSSMessage.MessageType.SConfirmation, true, "فایل مورد نظر حذف شود؟"))
                {
                    listView_Film.SelectedItems[0].Remove();
                    foreach (Clasess.Filing.FileTableList mc in FTList)
                    {
                        if (mc.FileName == listView_Film.SelectedItems[0].Name)
                            mc.File_View = FileViewForImageSelector.DeleteFile;
                    }
                }
        }

        private void bubbleButton_FilmView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            try
            {
                if (listView_Film.SelectedItems.Count != 0) Process.Start(listView_Film.SelectedItems[0].Name);
            }
            catch { }
        }

        private void bubbleButton_FilmIcon_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Film.View == View.LargeIcon)
                listView_Film.View = View.Tile;
            else if (listView_Film.View == View.Tile)
                listView_Film.View = View.SmallIcon;
            else if (listView_Film.View == View.SmallIcon)
                listView_Film.View = View.List;
            else listView_Film.View = View.LargeIcon;
        }

        private void listView_Film_DoubleClick(object sender, EventArgs e)
        {
            bubbleButton_FilmView_Click(this, null);
        }

        #endregion

        #endregion



       


        #region Old


        #region Load Data Old
        //public MSSImageSelector_frm(int PersCode, string AddressPhysic = "")
        //{
        //    InitializeComponent();
        //    _persCode = PersCode;
        //    _addressPhysic = AddressPhysic == "" ? (_addressPhysic + _persCode + @"\") : (AddressPhysic + _persCode + @"\");
        //    if (!File.Exists(_addressPhysic))
        //        Directory.CreateDirectory(_addressPhysic);

        //    _addressPhysicPic = _addressPhysic + @"PIC\";
        //    if (!File.Exists(_addressPhysicPic))
        //        Directory.CreateDirectory(_addressPhysicPic);

        //    _addressPhysicFilm = _addressPhysic + @"Film\";
        //    if (!File.Exists(_addressPhysicFilm))
        //        Directory.CreateDirectory(_addressPhysicFilm);
        //}




        #endregion

        #region OK Data
        //private void buttonItem_OK_Click(object sender, EventArgs e)
        //{
        //    if (OkFunction())
        //    {
        //        this.DialogResult = DialogResult.OK;
        //        Close();
        //    }
        //}

        //private bool OkFunction()
        //{
        //    try
        //    {
        //        //pics & films
        //        //SavePics_Films(_persCode);
        //    }
        //    catch (Exception ex)
        //    {
        //        MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SError, false, "ثبت نشد!", ex.Message);
        //        return false;
        //    }
        //    return true;
        //}        

        #endregion

        #region Pics & Films

        //private int PicCounter = 0;
        //private int FilmCounter = 0;
        //private PictureBox ImgPic = null;

        //private void LoadPics_Films(int CarFaceID)
        //{
        //    ReadOnlyCollection<string> ROCPIC = new ReadOnlyCollection<string>(FileSystem.GetFiles(_addressPhysicPic));
        //    foreach (string PicFilmRoot in ROCPIC)
        //    {
        //        string FileNameExist = Path.GetFileName(PicFilmRoot);
        //        if (new FileInfo(FileNameExist).Extension == ".db") continue;
        //        try
        //        {
        //            AddToListViewPic(FileNameExist, PicFilmRoot, PicCounter);
        //            PicCounter++;
        //        }
        //        catch { }
        //    }

        //    //films
        //    ReadOnlyCollection<string> ROC = new ReadOnlyCollection<string>(FileSystem.GetFiles(_addressPhysicFilm));
        //    foreach (string PicFilmRoot in ROC)
        //    {
        //        string FileNameExist = Path.GetFileName(PicFilmRoot);
        //        if (new FileInfo(FileNameExist).Extension == ".db") continue;
        //        AddToListViewFilm(FileNameExist, PicFilmRoot, FilmCounter);
        //        FilmCounter++;
        //    }
        //}


        //private void SavePics_Films(int CarFaceID)
        //{
        //    int i;

        //    for (i = 0; i < listView_Pic.Items.Count; i++)
        //    {
        //        if (FileSystem.FileExists(_addressPhysicPic + listView_Pic.Items[i].Text)) continue;
        //        else
        //            FileSystem.CopyFile(listView_Pic.Items[i].Name, _addressPhysicPic + listView_Pic.Items[i].Text);
        //    }
        //    for (i = 0; i < FileDel.Count; i++)
        //    {
        //        FileSystem.RenameFile(FileDel[i], "-1delF000.jpg");
        //        FileSystem.DeleteFile(_addressPhysicPic + "-1delF000.jpg");
        //    }



        //    for (i = 0; i < listView_Film.Items.Count; i++)
        //    {
        //        if (FileSystem.FileExists(_addressPhysicFilm + listView_Film.Items[i].Text)) continue;
        //        else
        //            FileSystem.CopyFile(listView_Film.Items[i].Name, _addressPhysicFilm + listView_Film.Items[i].Text);
        //    }

        //    for (i = 0; i < FileDelFilm.Count; i++)
        //    {
        //        FileSystem.RenameFile(FileDelFilm[i], "-1delF000.jpg");
        //        FileSystem.DeleteFile(_addressPhysicFilm + "-1delF000.jpg");
        //    }






        //int i;

        //ReadOnlyCollection<string> ROC = new ReadOnlyCollection<string>(FileSystem.GetFiles(_addressPhysic));

        //foreach (string PicFilmRoot in ROC)
        //{
        //    //pics
        //    if (PicFilmRoot.Contains("PIC") && PicFilmRoot.Contains("ID" + CarFaceID.ToString()))
        //    {
        //        for (i = 0; i < listView_Pic.Items.Count; i++)
        //        {
        //            if (PicFilmRoot == listView_Pic.Items[i].Name) break;
        //            else continue;
        //        }
        //        if (i == listView_Pic.Items.Count)
        //            FileSystem.DeleteFile(PicFilmRoot);
        //    }

        //    //films
        //    if (PicFilmRoot.Contains("FILM") && PicFilmRoot.Contains("ID" + CarFaceID.ToString()))
        //    {
        //        for (i = 0; i < listView_Film.Items.Count; i++)
        //        {
        //            if (PicFilmRoot == listView_Film.Items[i].Name) break;
        //            else continue;
        //        }
        //        if (i == listView_Film.Items.Count)
        //            FileSystem.DeleteFile(PicFilmRoot);
        //    }
        //}


        ////pics
        //for (i = 0; i < listView_Pic.Items.Count; i++)
        //{
        //    if (FileSystem.FileExists(_addressPhysic + listView_Pic.Items[i].Text)) continue;
        //    else
        //    {
        //        MaxPicIDExist++;
        //        string FileNameAdd = "PIC" + MaxPicIDExist.ToString() + "ID" + CarFaceID.ToString() + listView_Pic.Items[i].Text.Substring(listView_Pic.Items[i].Text.IndexOf("."));
        //        FileSystem.CopyFile(listView_Pic.Items[i].Name, _addressPhysic + FileNameAdd);
        //    }
        //}


        ////films
        //for (i = 0; i < listView_Film.Items.Count; i++)
        //{
        //    if (FileSystem.FileExists(_addressPhysic + listView_Film.Items[i].Text)) continue;
        //    else
        //    {
        //        MaxFilmIDExist++;
        //        string FileNameAdd = "FILM" + MaxFilmIDExist.ToString() + "ID" + CarFaceID.ToString() + listView_Film.Items[i].Text.Substring(listView_Film.Items[i].Text.IndexOf("."));
        //        FileSystem.CopyFile(listView_Film.Items[i].Name, _addressPhysic + FileNameAdd);
        //    }
        //}

        ////}

        //pics

        #endregion

        #region Other

        //List<string> FileDel= new List<string>();
        //private void bubbleButton_PicDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        //{
        //    if (listView_Pic.SelectedItems.Count != 0)
        //        if (MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SConfirmation, true, "آیا مایلید فایل مورد نظر حذف شود؟"))
        //        {
        //            string _addressPhysicPicDel = _addressPhysicPic + @"Del\";
        //            if (!Directory.Exists(_addressPhysicPicDel))
        //                Directory.CreateDirectory(_addressPhysicPicDel);

        //            string str = _addressPhysicPic + listView_Pic.SelectedItems[0].Text;

        //            if (File.Exists(str))
        //            {
        //                FileDel.Add(str);
        //                bool tkrr = true; int M = 0;
        //                while (tkrr)
        //                {
        //                    try
        //                    {
        //                        FileSystem.CopyFile(listView_Pic.SelectedItems[0].Name, _addressPhysicPicDel + listView_Pic.SelectedItems[0].Text);
        //                        tkrr = false;
        //                    }
        //                    catch
        //                    {
        //                        try
        //                        {
        //                            FileSystem.CopyFile(listView_Pic.SelectedItems[0].Name, _addressPhysicPicDel + listView_Pic.SelectedItems[0].Text+M++.ToString());
        //                            tkrr = false;
        //                        }
        //                        catch { }
        //                    }
        //                }
        //            }

        //            listView_Pic.SelectedItems[0].Remove();

        //        }
        //}

        //private void AddToListViewPic(string PicFileName, string ItemName, int PicCnt)
        //{
        //    ImgPic = new PictureBox();
        //    //ImgPic.Load(ItemName);
        //    ImgPic.Image = PublicClass.resizeImage(ItemName);
        //    imageList_LargePic.Images.Add(ImgPic.Image);
        //    imageList_SmallPic.Images.Add(ImgPic.Image);
        //    listView_Pic.Items.Add(ItemName, PicFileName, PicCnt);
        //}

        //private void bubbleButton_PicView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        //{
        //    if (listView_Pic.SelectedItems.Count != 0) Process.Start(listView_Pic.SelectedItems[0].Name);
        //}

        //private void bubbleButton_IconPic_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        //{
        //    if (listView_Pic.View == View.LargeIcon)
        //        listView_Pic.View = View.Tile;
        //    else if (listView_Pic.View == View.Tile)
        //        listView_Pic.View = View.SmallIcon;
        //    else if (listView_Pic.View == View.SmallIcon)
        //        listView_Pic.View = View.List;
        //    else listView_Pic.View = View.LargeIcon;
        //}

        //private void listView_Pic_DoubleClick(object sender, EventArgs e)
        //{
        //    bubbleButton_PicView_Click(this, null);
        //}


        //films

        //private void AddToListViewFilm(string FilmFileName, string ItemName, int FilmCnt)
        //{
        //    ImgPic = new PictureBox();
        //    ImgPic.Image = Properties.Resources.Templete;
        //    imageList_LargeFilm.Images.Add(ImgPic.Image);
        //    imageList_SmallFilm.Images.Add(ImgPic.Image);
        //    listView_Film.Items.Add(ItemName, FilmFileName, FilmCnt);
        //}


        //private void bubbleButton_FilmNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.Filter = "All Video file|*.wmv;*.avi;*.mpeg;*.3gp;*.mp4;*.mp3;*.dat;*.mov;*.divx";

        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        AddToListViewFilm(ofd.SafeFileName, ofd.FileName, FilmCounter);

        //        FilmCounter++;
        //    }

        //}

        //List<string> FileDelFilm = new List<string>();
        //private void bubbleButton_FilmDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        //{
        //    if (listView_Film.SelectedItems.Count != 0)
        //        if (MSSMessage.MSSMessage_View(0, MSSMessage.MessageType.SConfirmation, true, "آیا مایلید فیلم مورد نظر حذف شود؟"))
        //        {
        //            string _addressPhysicFilmDel = _addressPhysicFilm + @"Del\";
        //            if (!Directory.Exists(_addressPhysicFilmDel))
        //                Directory.CreateDirectory(_addressPhysicFilmDel);

        //            string str = _addressPhysicFilm + listView_Film.SelectedItems[0].Text;

        //            if (File.Exists(str))
        //            {
        //                FileDelFilm.Add(str);
        //                bool tkrr = true; int M = 0;
        //                while (tkrr)
        //                {
        //                    try
        //                    {
        //                        FileSystem.CopyFile(listView_Film.SelectedItems[0].Name, _addressPhysicFilmDel + listView_Film.SelectedItems[0].Text);
        //                        tkrr = false;
        //                    }
        //                    catch
        //                    {
        //                        try
        //                        {
        //                            FileSystem.CopyFile(listView_Film.SelectedItems[0].Name, _addressPhysicFilmDel + listView_Film.SelectedItems[0].Text + M++.ToString());
        //                            tkrr = false;
        //                        }
        //                        catch { }
        //                    }
        //                }
        //            }

        //            listView_Film.SelectedItems[0].Remove();

        //        }
        //}

        //private void bubbleButton_FilmView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        //{
        //    try
        //    {
        //        if (listView_Film.SelectedItems.Count != 0) Process.Start(listView_Film.SelectedItems[0].Name);
        //    }
        //    catch { }
        //}

        //private void bubbleButton_FilmIcon_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        //{
        //    if (listView_Film.View == View.LargeIcon)
        //        listView_Film.View = View.Tile;
        //    else if (listView_Film.View == View.Tile)
        //        listView_Film.View = View.SmallIcon;
        //    else if (listView_Film.View == View.SmallIcon)
        //        listView_Film.View = View.List;
        //    else listView_Film.View = View.LargeIcon;
        //}

        //private void listView_Film_DoubleClick(object sender, EventArgs e)
        //{
        //    bubbleButton_FilmView_Click(this, null);
        //}

        #endregion


        #endregion


    }

}
