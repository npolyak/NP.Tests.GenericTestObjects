// (c) Nick Polyak 2013 - http://awebpros.com/
// License: Code Project Open License (CPOL) 1.92(http://www.codeproject.com/info/cpol10.aspx)
//
// short overview of copyright rules:
// 1. you can use this framework in any commercial or non-commercial 
//    product as long as you retain this copyright message
// 2. Do not blame the author(s) of this software if something goes wrong. 
// 
// Also as a courtesy, please, mention this software in any documentation for the 
// products that use it.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP.Tests.GenericTestObjects
{
    /// <summary>
    /// 
    /// </summary>
    public class TestTreeNode
    {
        public virtual TestTreeNode Parent { get; set; }

        public IList<TestTreeNode> Children { get; set; }

        public virtual string NodeInfo { get; set; }

        protected virtual IList<TestTreeNode> CreateChildrenCollection()
        {
            return new List<TestTreeNode>();
        }

        protected virtual TestTreeNode CreateChild()
        {
            return new TestTreeNode();
        }

        public TestTreeNode AddChild(string nodeInfo)
        {
            if (Children == null)
                Children = CreateChildrenCollection();

            TestTreeNode childNode = CreateChild();


            childNode.Parent = this;
            childNode.NodeInfo = nodeInfo;

            Children.Add(childNode);

            return childNode;
        }

        public void RemoveFromParent()
        {
            if (Parent == null)
                return;

            Parent.Children.Remove(this);

            this.Parent = null;
        }
    }
}
