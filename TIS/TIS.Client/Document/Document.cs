using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TIS.Framework.Common;
using DevExpress.Xpo;
using Microsoft.Win32;
using PROF_IT.Exceptionhandling;
using System.Reflection;

namespace TIS.Client.Document
{
    public partial class Document : General.BaseChildForm
    {
        #region Fields
        private Model.Internal.Document.DocNode _selectedNode = null;
        private TileItem _overviewTileItem = null;
        //private Enumeration.EnumViews.Document _docTree;
        #endregion

        #region Constructor
        public Document()
        {
            try
            {
                InitializeComponent();
                CreateOverviewTileItem();
                Find();
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }

        }

        private void CreateOverviewTileItem()
        {
            try
            {
                _overviewTileItem = new TileItem();
                _overviewTileItem.BackgroundImageAlignment = TileItemContentAlignment.MiddleCenter;
                _overviewTileItem.BackgroundImageScaleMode = TileItemImageScaleMode.ZoomInside;
                _overviewTileItem.IsLarge = true;
                _overviewTileItem.BackgroundImage = iclExtraLarge.Images[42];
                _overviewTileItem.Text = "Overzicht";
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Methods
        private void Find()
        {
            try
            {
                XPCollection<TIS.Model.Internal.Document.DocNode> dns = new XPCollection<TIS.Model.Internal.Document.DocNode>(Uow);
                //TODO : nog in BL ophalen van wortels (door te querien op ParentDocNode == null en op DocTree)!
                List<TIS.Model.Internal.Document.DocNode> toplvl = new List<TIS.Model.Internal.Document.DocNode>();
                foreach (TIS.Model.Internal.Document.DocNode node in dns)
                {
                    if(node.ParentDocNode == null)
                    toplvl.Add(node);
                }
                tileDocument.Groups.Clear();
                TileGroup tg = new TileGroup();
                //tg.Tag = "0";
                tileDocument.Groups.Add(tg);
                foreach (TIS.Model.Internal.Document.DocNode node in toplvl)
                {
                    tg.Items.Add(CreateTileItem(node));
                }
                tileControlOverview.Groups.Clear();
                tileControlOverview.Groups.Add(new TileGroup());
                tileControlOverview.Groups[0].Items.Add(_overviewTileItem);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private TileItem CreateTileItem(TIS.Model.Internal.Document.DocNode node)
        {
            try
            {
                TileItem ti = new TileItem();
                ti.BackgroundImageAlignment = TileItemContentAlignment.MiddleCenter;
                ti.BackgroundImageScaleMode = TileItemImageScaleMode.ZoomInside;
                if (node.Document == null)
                    ti.IsLarge = true;
                if (node.ImageIndex >= 0 && node.ImageIndex < iclExtraLarge.Images.Count)
                    ti.BackgroundImage = iclExtraLarge.Images[node.ImageIndex];
                else
                    if (node.Document != null)
                    {
                        RegistryKey oHKCR = null;
                        RegistryKey oProgID = null;
                        RegistryKey oOpenCmd = null;
                        string StrProgID = null;
                        string StrExe = null;
                        try
                        {
                            oHKCR = Registry.ClassesRoot;
                            oProgID = oHKCR.OpenSubKey(node.Document.Name.Substring(node.Document.Name.LastIndexOf('.')));
                            StrProgID = oProgID.GetValue(null).ToString();
                            oProgID.Close();
                            oOpenCmd = oHKCR.OpenSubKey(StrProgID + @"\shell\open\command");
                            StrExe = oOpenCmd.GetValue(null).ToString();
                            oOpenCmd.Close();
                            int TempPos = StrExe.IndexOf(" %1");
                            if (TempPos > 0)
                            {
                                StrExe = StrExe.Substring(0, TempPos);
                            }
                            TempPos = StrExe.IndexOf("\"");
                            if (TempPos >= 0)
                            {
                                StrExe = StrExe.Substring(TempPos + 1, StrExe.IndexOf("\"", TempPos + 1) - 1);
                            }
                            ti.BackgroundImage = Icon.ExtractAssociatedIcon(StrExe).ToBitmap();
                        }
                        catch (Exception e) { }
                    }
                ti.Text = node.Name;
                ti.Tag = node;
                return ti;
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void SelectNode(Model.Internal.Document.DocNode node)
        {
            try
            {
                _selectedNode = node;
                if (_selectedNode == null)
                {
                    Find();
                }
                else
                {
                    tileDocument.Groups.Clear();
                    TileGroup newGroup = new TileGroup();
                    foreach (Model.Internal.Document.DocNode n in node.childDocNode)
                    {
                        newGroup.Items.Add(CreateTileItem(n));
                    }
                    tileDocument.Groups.Add(newGroup);
                    Refresh_Overview();
                }
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        private void Refresh_Overview()
        {
            try
            {
                Model.Internal.Document.DocNode node = _selectedNode;
                List<Model.Internal.Document.DocNode> nodes = new List<Model.Internal.Document.DocNode>();
                while (node != null)
                {
                    nodes.Insert(0, node);
                    node = node.ParentDocNode;
                }
                // maybe : create top lvl item;

                TileGroup newGroup = new TileGroup();
                newGroup.Items.Add(_overviewTileItem);
                foreach (Model.Internal.Document.DocNode n in nodes)
                {
                    newGroup.Items.Add(CreateTileItem(n));
                }
                tileControlOverview.Groups.Clear();
                tileControlOverview.Groups.Add(newGroup);
            }
            catch (Exception exception1)
            {
                Exception innerException = exception1;
                throw new Exception(MethodBase.GetCurrentMethod().Name, innerException);
            }
        }
        #endregion

        #region Events
        private void tileDocument_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                Model.Internal.Document.Document document = new Model.Internal.Document.Document(Uow);
                foreach (string file in FileList)
                {
                    if (!System.IO.Directory.Exists(file))
                    {
                        document.ReadFile(file);
                        document.Name = file.Substring(file.LastIndexOf('\\') + 1);
                        document.DocTypeDisplay = Enumeration.Document.DocumentType.Document;
                        TIS.Model.Internal.Document.DocNode newNode = new TIS.Model.Internal.Document.DocNode(Uow);
                        newNode.Document = document;
                        newNode.ParentDocNode = _selectedNode;
                        newNode.Name = document.Name;
                        //newNode.DocTreeDisplay = _docTree;
                        newNode.ImageIndex = -1;
                        DocumentFile df = new DocumentFile(iclExtraLarge, document.Name);
                        df.ShowDialog(this);
                        if (df.DialogResult == DialogResult.OK)
                        {
                            newNode.ImageIndex = df.Index >= iclExtraLarge.Images.Count ? -1 : df.Index;
                            newNode.Name = df.DocName;
                            Uow.CommitChanges();
                        }
                        //this.Uow = new UnitOfWork();
                    }
                }
                SelectNode(_selectedNode);
            }
            catch (Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void tileDocument_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Copy;
                string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                foreach (string file in FileList)
                {
                    if (System.IO.Directory.Exists(file))
                    {
                        e.Effect = DragDropEffects.None;
                    }
                }
            }
            catch (Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void tileDocument_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                Model.Internal.Document.DocNode node = (TIS.Model.Internal.Document.DocNode)(e.Item.Tag);
                if (node.Document == null)
                {
                    SelectNode(node);
                    //int groupIndex = int.Parse(e.Item.Group.Tag.ToString());
                    //List<TileGroup> deleteGroups = new List<TileGroup>();
                    //foreach (TileGroup tg in tileDocument.Groups)
                    //{
                    //    if (int.Parse(tg.Tag.ToString()) > groupIndex)
                    //    {
                    //        deleteGroups.Add(tg);
                    //    }
                    //}
                    //foreach (TileGroup tg in deleteGroups)
                    //{
                    //    tileDocument.Groups.Remove(tg);
                    //}
                    //TileGroup newGroup = new TileGroup();
                    //newGroup.Tag = groupIndex + 1;
                    //if (_selectedNode != null)
                    //{
                    //    foreach (TIS.Model.Internal.Document.DocNode n in _selectedNode.childDocNode)
                    //    {
                    //        newGroup.Items.Add(CreateTileItem(n));
                    //    }
                    //    tileDocument.Groups.Clear();
                    //    tileDocument.Groups.Add(newGroup);
                    //}
                }
                else
                {
                    Model.Internal.Document.Document currentDocument = node.Document;
                    if (currentDocument != null)
                    {
                        if (currentDocument.DocTypeDisplay == Enumeration.Document.DocumentType.Document)
                        {
                            currentDocument.OpenFile();
                        }
                        else
                        {
                            System.Diagnostics.Process.Start(currentDocument.Name);
                        }
                    }
                }
            }
            catch (Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void tileDocument_RightItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                Model.Internal.Document.DocNode node = (TIS.Model.Internal.Document.DocNode)(e.Item.Tag);
                if (node.Document == null)
                {
                    DocumentFile df = new DocumentFile(iclExtraLarge, node.Name, node.ImageIndex, "Map");
                    df.ShowDialog(this);
                    if (df.DialogResult == DialogResult.OK)
                    {
                        if (df.isDeleted)
                        {
                            if (node.childDocNode.Count == 0)
                                Uow.Delete(node);
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Onmogelijk om te verwijderen terwijl de map niet leeg is", "Verwijderen mislukt", MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            node.ImageIndex = df.Index >= iclExtraLarge.Images.Count ? -1 : df.Index;
                            node.Name = df.DocName;
                        }
                        Uow.CommitChanges();
                        SelectNode(_selectedNode);
                    }
                    //this.Uow = new UnitOfWork();
                }
                else
                {
                    if (node.Document.DocTypeDisplay == Enumeration.Document.DocumentType.Link)
                    {
                        DocumentLink dl = new DocumentLink(iclExtraLarge, node.Name, node.ImageIndex, node.Document.Name);
                        dl.ShowDialog();
                        if (dl.DialogResult == DialogResult.OK)
                        {
                            if (dl.isDeleted)
                            {
                                Uow.Delete(node.Document);
                                Uow.Delete(node);
                            }
                            else
                            {
                                node.Name = dl.NodeName;
                                node.ImageIndex = dl.Index >= iclExtraLarge.Images.Count ? -1 : dl.Index;
                                node.Document.Name = dl.Url;
                            }
                            Uow.CommitChanges();
                            SelectNode(_selectedNode);
                        }
                    }
                    else
                    //if (node.Document.DocTypeDisplay == Enumeration.Document.DocumentType.Document)
                    {
                        DocumentFile df = new DocumentFile(iclExtraLarge, node.Name, node.ImageIndex,
                            node.Document.DocTypeDisplay == Enumeration.Document.DocumentType.Document ? "Document" :
                    node.Document.DocTypeDisplay == Enumeration.Document.DocumentType.Application ? "Programma" : "");
                        df.ShowDialog(this);
                        if (df.DialogResult == DialogResult.OK)
                        {
                            if (df.isDeleted)
                            {
                                if (node.childDocNode.Count == 0)
                                    Uow.Delete(node);
                                else
                                {
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Onmogelijk om te verwijderen terwijl de map niet leeg is", "Verwijderen mislukt", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                node.ImageIndex = df.Index >= iclExtraLarge.Images.Count ? -1 : df.Index;
                                node.Name = df.DocName;
                            }
                            Uow.CommitChanges();
                            SelectNode(_selectedNode);
                        }
                        //this.Uow = new UnitOfWork();
                    }
                }
            }
            catch (Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void tileDocument_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    DocumentNodeOrLink dnol = new DocumentNodeOrLink(iclExtraLarge);
                    dnol.ShowDialog(this);
                    if (dnol.DialogResult == DialogResult.OK)
                    {
                        TIS.Model.Internal.Document.DocNode newNode = new TIS.Model.Internal.Document.DocNode(Uow);
                        newNode.ParentDocNode = _selectedNode;
                        newNode.Name = dnol.NodeName;
                        //newNode.DocTreeDisplay = _docTree;
                        newNode.ImageIndex = dnol.Index;
                        if (dnol.isLink)
                        {
                            Model.Internal.Document.Document document = new Model.Internal.Document.Document(Uow);
                            document.Name = dnol.Url;
                            document.DocTypeDisplay = Enumeration.Document.DocumentType.Link;
                            document.DocNode = newNode;
                            newNode.Document = document;
                        }
                        Uow.CommitChanges();
                        SelectNode(_selectedNode);
                    }
                }
            }
            catch (Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        private void tileControlOverview_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                if (e.Item == _overviewTileItem)
                {
                    SelectNode(null);
                }
                else
                {
                    Model.Internal.Document.DocNode node = (Model.Internal.Document.DocNode)e.Item.Tag;
                    SelectNode(node);
                }
            }
            catch (Exception exception1)
            {
                System.Exception thisException = exception1;
                Management.ShowException(thisException);
            }
        }
        #endregion

    }
}