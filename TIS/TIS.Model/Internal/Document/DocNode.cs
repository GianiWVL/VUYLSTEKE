using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using TIS.Framework.Common;

namespace TIS.Model.Internal.Document
{
    public class DocNode : XPCustomObject
    {

        #region Constructor
        public DocNode(Session session) : base(session) { }
        public DocNode() : base(Session.DefaultSession) { }
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

        [Association("SubRelation", typeof(DocNode))]
        public XPCollection<DocNode> childDocNode
        {
            get { return GetCollection<DocNode>("childDocNode"); }
        }


        DocNode fParentDocNode;
        [Association("SubRelation", typeof(DocNode))]
        public DocNode ParentDocNode
        {
            get { return fParentDocNode; }
            set { SetPropertyValue<DocNode>("ParentDocNode", ref fParentDocNode, value); }
        }

        Document fDocument;
        public Document Document
        {
            get { return fDocument; }
            set
            {
                if (fDocument == value)
                    return;

                Document prevDocument = fDocument;
                fDocument = value;

                if (IsLoading) return;

                if (prevDocument != null && prevDocument.DocNode == this)
                    prevDocument.DocNode = null;

                if (fDocument != null)
                    fDocument.DocNode = this;
                OnChanged("Document");

            }
        }

        //int fDocTree;
        //public int DocTree
        //{
        //    get { return fDocTree; }
        //    set { SetPropertyValue<int>("DocTree", ref fDocTree, value); }
        //}
        //[NonPersistentAttribute]
        //public Enumeration.EnumViews.Document DocTreeDisplay
        //{
        //    get { return (Enumeration.EnumViews.Document)DocTree; }
        //    set { DocTree = (int)value; }
        //}

        string fName;
        [Size(255)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }

        int fImageIndex;
        public int ImageIndex
        {
            get { return fImageIndex; }
            set { SetPropertyValue<int>("ImageIndex", ref fImageIndex, value); }
        }

        #endregion

        #region Methods
        public override void AfterConstruction() { base.AfterConstruction(); }

        #endregion



    }
}