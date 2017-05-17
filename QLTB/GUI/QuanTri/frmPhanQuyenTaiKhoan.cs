using QLTB.DAL.Data;
using QLTB.Handler;
using QLTB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB.GUI
{
    public partial class frmPhanQuyenTaiKhoan : DevComponents.DotNetBar.Office2007Form
    {
        private UserRole WorkingRole;
        private int WorkingType;
        private List<QHUserPermission> listQH = new List<QHUserPermission>();
        private UserHandler handler = new UserHandler();
        private List<UserPermission> listPermission = new List<UserPermission>();
        public frmPhanQuyenTaiKhoan()
        {
            InitializeComponent();

        }
        private void loadtvPermission()
        {
            var mainForm = this.MdiParent as frmMain;
            foreach (TreeNode originalNode in mainForm.tvMainMenu.Nodes)
            {
                TreeNode newNode = new TreeNode(originalNode.Text);
                newNode.Tag = originalNode.Tag;
                tvPermisions.Nodes.Add(newNode);
                IterateTreeNodes(originalNode, newNode);
            }
            tvPermisions.ExpandAll();

        }
        private void loadtvUser()
        {
            var listUser=handler.GetUsers();
            var groups=listUser.GroupBy(p => new { p.UserRoleId,p.UserRoleName});
            foreach (var group in groups)
            {
                TreeNode rootNode = new TreeNode();
                rootNode.Text = group.Key.UserRoleName;
                rootNode.Name = group.Key.UserRoleId.ToString();
                rootNode.Tag = group.Key.UserRoleId;
                foreach (var state in group)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Text = state.UserName;
                    childNode.Name = state.UserId.ToString();
                    childNode.Tag = state.UserRoleId;
                    rootNode.Nodes.Add(childNode);
                }
                tvUsers.Nodes.Add(rootNode);
            }
            btnStripSuaQuyen.Click += BtnStripSuaQuyen_Click;
            btnStripThemTK.Click += BtnStripThemTK_Click;
            btnStripXoaND.Click += BtnStripXoaND_Click;
        }

        private void BtnStripXoaND_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnStripThemTK_Click(object sender, EventArgs e)
        {
            WorkingRole = new UserRole();
            ThemQuyen();
        }

        private void BtnStripSuaQuyen_Click(object sender, EventArgs e)
        {
            int RoleId = (int)tvUsers.SelectedNode.Tag;
            WorkingRole= handler.GetRoleById(RoleId);
            SuaQuyen();
        }

        private void loadPermissionFromMenu()
        {
            #region Treview User
            int index = 1;
            var mainForm = this.MdiParent as frmMain;
            TreeNodeCollection nodes = mainForm.tvMainMenu.Nodes;
            foreach (TreeNode n in nodes)
            {
                n.Tag = new ObjectPermission
                {
                    Id=index,
                    parentId = null,
                    isView = true,
                    isAdd = true,
                    isDelete = true,
                    isUpdate = true
                };
                AddPermissions(n, index);
                
                TreeNodeRecursive(n, index++);
            }
            #endregion
        }
        private void TreeNodeRecursive(TreeNode treeNode,int index)
        {
            TreeNodeCollection nodes = treeNode.Nodes;
            int parentId = ((ObjectPermission)treeNode.Tag).Id;
            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.Tag = new ObjectPermission
                {
                    Id= index,
                    parentId = parentId,
                    isView = true,
                    isAdd=true,
                    isDelete=true,
                    isUpdate=true
                };
                AddPermissions(tn, index);
                TreeNodeRecursive(tn, index++);
               
            }
        }
        private void AddPermissions(TreeNode node, int indexStart)
        {
                UserPermission tmp = new UserPermission();
                tmp.PermissionId = indexStart++;
                tmp.PermissionKey = node.Name;
                tmp.Name = node.Text;
                ObjectPermission tagObject = (ObjectPermission)node.Tag;
                tmp.ParentId = tagObject.parentId;
                AddPermission(tmp);
            //
            PermissionNode tmpnode = new PermissionNode();
        }
        private void AddPermission(UserPermission pms)
        {
            listPermission.Add(pms);
        }

        private void btnAddPermissions_Click(object sender, EventArgs e)
        {
            loadPermissionFromMenu();
        }
        //Copy treeview
        private void IterateTreeNodes(TreeNode originalNode, TreeNode rootNode)
        {
            foreach (TreeNode childNode in originalNode.Nodes)
            {

                TreeNode newNode = new TreeNode(childNode.Text);
                newNode.Tag = childNode.Tag;
                tvPermisions.SelectedNode = rootNode;
                tvPermisions.SelectedNode.Nodes.Add(newNode);
                IterateTreeNodes(childNode, newNode);
            }
        }

        private void frmPhanQuyenTaiKhoan_Load(object sender, EventArgs e)
        {
            loadtvUser();
           // loadtvPermission();
        }

        private void tvPermisions_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        private void tvUsers_MouseClick(object sender, MouseEventArgs e)
        {
            var item = ((TreeView)sender).SelectedNode;
            if (e.Button == MouseButtons.Right)
            {
                if(item.Parent==null)
                    ContextMenuNQ.Show(tvUsers,e.Location);
                else
                {
                    ContextMenuND.Show(tvUsers, e.Location);
                }
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void SuaQuyen()
        {
            grpChiTietNhomQuyen.Enabled = true;
            var role=handler.GetRoleById(WorkingRole.UserRoleId);
            txtRoleName.Text = role.Name;
            txtDescription.Text = role.Description;
            WorkingType = 2;
        }
        private void ThemQuyen()
        {
            listQH.Clear();
            grpChiTietNhomQuyen.Enabled = true;
            txtRoleName.Text = "";
            txtDescription.Text = "";
            dpickDateCreated.Value = DateTime.Today;
            WorkingType = 1;
           
        }
        private void LuuQuyen()
        {
            if (WorkingType == 1)
            {
                //them moi
                WorkingRole.Description = txtDescription.Text;
                WorkingRole.Name = txtRoleName.Text;
            }
            else if(WorkingType==2)
            {

                MessageBox.Show("Các cập nhật đã được lưu lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
            
            grpChiTietNhomQuyen.Enabled = false;
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LuuQuyen();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
