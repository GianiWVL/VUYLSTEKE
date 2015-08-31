using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using TIS.Framework.Common;
using System.IO;

namespace TIS.Model.Internal.Document
{
    public class Document : XPCustomObject
    {

        #region Constructor
        public Document(Session session) : base(session) { }
        public Document() : base(Session.DefaultSession) { }
        #endregion

        #region Properties
        #endregion

        #region XPOProperties
        int fId;
        [Key(true)]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>("Id", ref fId, value); }
        }
        string fName;
        [Size(255)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }

        [Delayed(true)]
        public Byte[] Doc
        {
            get { return GetDelayedPropertyValue<Byte[]>("Doc"); }
            set { SetDelayedPropertyValue<Byte[]>("Doc", value); }
        }

        DocNode fDocNode;
        public DocNode DocNode
        {
            get { return fDocNode; }
            set
            {
                if (fDocNode == value)
                    return;

                DocNode prevDocNode = fDocNode;
                fDocNode = value;

                if (IsLoading) return;

                if (prevDocNode != null && prevDocNode.Document == this)
                    prevDocNode.Document = null;

                if (fDocNode != null)
                    fDocNode.Document = this;

                OnChanged("DocNode");
            }
        }

        int fDocType;
        public int DocType
        {
            get { return fDocType; }
            set { SetPropertyValue<int>("DocType", ref fDocType, value); }
        }
        [NonPersistentAttribute]
        public Enumeration.Document.DocumentType DocTypeDisplay
        {
            get { return (Enumeration.Document.DocumentType)DocType; }
            set { DocType = (int)value; }
        }

        #endregion

        #region Methods
        public override void AfterConstruction() { base.AfterConstruction(); }

        public void ReadFile(string sPath)
        {

            using (FileStream file = new FileStream(sPath, FileMode.Open, FileAccess.Read))
            {
                byte[] data = new byte[file.Length];
                file.Read(data, 0, data.Length);
                this.Doc = data;
            }

        }


        public void OpenFile()
        {
            string path = Path.GetTempPath();
            using (FileStream fs = new FileStream(path + @"\" + Name, FileMode.Create))
            {
                if (Doc != null)
                    fs.Write(Doc, 0, Doc.Length);
                fs.Close();
            }

            System.Diagnostics.Process.Start(path + @"\" + Name);

        }

        #endregion




    }
}
