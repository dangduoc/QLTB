namespace QLTB.GUI
{
    partial class frmPhanQuyenTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyenTaiKhoan));
            this.MenuPhanQuyen = new DevComponents.DotNetBar.RibbonBar();
            this.btnThem = new DevComponents.DotNetBar.ButtonItem();
            this.btnThemNhom = new DevComponents.DotNetBar.ButtonItem();
            this.btnThemNguoiDung = new DevComponents.DotNetBar.ButtonItem();
            this.btnSua = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnKhoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnLuu = new DevComponents.DotNetBar.ButtonItem();
            this.btnLuuPhanQuyen = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.grpChiTietNhomQuyen = new DevComponents.DotNetBar.ExpandablePanel();
            this.lbMatKhau = new DevComponents.DotNetBar.LabelX();
            this.lbTenDangNhap = new DevComponents.DotNetBar.LabelX();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.tvUsers = new System.Windows.Forms.TreeView();
            this.grpQuyenHan = new DevComponents.DotNetBar.ExpandablePanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnAddPermissions = new DevComponents.DotNetBar.ButtonItem();
            this.btnDongHet = new DevComponents.DotNetBar.ButtonItem();
            this.btnMoHet = new DevComponents.DotNetBar.ButtonItem();
            this.lbThongBaoQuyen = new DevComponents.DotNetBar.LabelItem();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.chbIsView = new DevComponents.DotNetBar.CheckBoxItem();
            this.chbChiThem = new DevComponents.DotNetBar.CheckBoxItem();
            this.chbIsUpdate = new DevComponents.DotNetBar.CheckBoxItem();
            this.chbChiXoa = new DevComponents.DotNetBar.CheckBoxItem();
            this.tvPermisions = new System.Windows.Forms.TreeView();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.ContextMenuNQ = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnStripSuaQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStripXoaQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStripThemTK = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDescription = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dpickDateCreated = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.ContextMenuND = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnStripXemTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStripXoaND = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStripChuyenQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanel1.SuspendLayout();
            this.grpChiTietNhomQuyen.SuspendLayout();
            this.grpQuyenHan.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.ContextMenuNQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpickDateCreated)).BeginInit();
            this.ContextMenuND.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPhanQuyen
            // 
            this.MenuPhanQuyen.AutoOverflowEnabled = true;
            this.MenuPhanQuyen.BackgroundHoverEnabled = false;
            // 
            // 
            // 
            this.MenuPhanQuyen.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.MenuPhanQuyen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MenuPhanQuyen.ContainerControlProcessDialogKey = true;
            this.MenuPhanQuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPhanQuyen.DragDropSupport = true;
            this.MenuPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MenuPhanQuyen.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnKhoa,
            this.btnLuu,
            this.btnLuuPhanQuyen,
            this.btnThoat});
            this.MenuPhanQuyen.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.MenuPhanQuyen.Location = new System.Drawing.Point(0, 0);
            this.MenuPhanQuyen.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MenuPhanQuyen.Name = "MenuPhanQuyen";
            this.MenuPhanQuyen.ShowShortcutKeysInToolTips = true;
            this.MenuPhanQuyen.Size = new System.Drawing.Size(1112, 79);
            this.MenuPhanQuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.MenuPhanQuyen.TabIndex = 33;
            this.MenuPhanQuyen.Text = "Phân quyền";
            // 
            // 
            // 
            this.MenuPhanQuyen.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.MenuPhanQuyen.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MenuPhanQuyen.TitleVisible = false;
            // 
            // btnThem
            // 
            this.btnThem.BeginGroup = true;
            this.btnThem.Image = global::QLTB.Properties.Resources.add1;
            this.btnThem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThem.Name = "btnThem";
            this.btnThem.RibbonWordWrap = false;
            this.btnThem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnThem.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThemNhom,
            this.btnThemNguoiDung});
            this.btnThem.Text = "Thêm";
            this.btnThem.Tooltip = "Thêm người dùng - Nhóm người dùng";
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Text = "Thêm nhóm mới";
            // 
            // btnThemNguoiDung
            // 
            this.btnThemNguoiDung.Name = "btnThemNguoiDung";
            this.btnThemNguoiDung.Text = "Thêm người dùng mới";
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSua.Name = "btnSua";
            this.btnSua.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.btnSua.Text = "Sửa";
            this.btnSua.Tooltip = "Sửa thông tin";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Tooltip = "Xóa người dùng - Nhóm người dùng";
            // 
            // btnKhoa
            // 
            this.btnKhoa.BeginGroup = true;
            this.btnKhoa.Image = global::QLTB.Properties.Resources.security_f2;
            this.btnKhoa.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.RibbonWordWrap = false;
            this.btnKhoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlK);
            this.btnKhoa.Text = "Khóa/Kích hoạt ";
            this.btnKhoa.Tooltip = "Khóa nhóm hoặc người dùng";
            // 
            // btnLuu
            // 
            this.btnLuu.BeginGroup = true;
            this.btnLuu.Image = global::QLTB.Properties.Resources.save;
            this.btnLuu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Tooltip = "Lưu thông tin";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLuuPhanQuyen
            // 
            this.btnLuuPhanQuyen.BeginGroup = true;
            this.btnLuuPhanQuyen.Image = global::QLTB.Properties.Resources.DuyetGiaoDich;
            this.btnLuuPhanQuyen.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLuuPhanQuyen.Name = "btnLuuPhanQuyen";
            this.btnLuuPhanQuyen.RibbonWordWrap = false;
            this.btnLuuPhanQuyen.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftS);
            this.btnLuuPhanQuyen.Text = "Lưu phân quyền";
            this.btnLuuPhanQuyen.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BeginGroup = true;
            this.btnThoat.Image = global::QLTB.Properties.Resources.Exit;
            this.btnThoat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F10);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Tooltip = "Thoát";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.grpChiTietNhomQuyen);
            this.groupPanel1.Controls.Add(this.tvUsers);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel1.Location = new System.Drawing.Point(0, 79);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(389, 509);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 34;
            this.groupPanel1.Text = "Nhóm quyền người dùng";
            // 
            // grpChiTietNhomQuyen
            // 
            this.grpChiTietNhomQuyen.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpChiTietNhomQuyen.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.TopToBottom;
            this.grpChiTietNhomQuyen.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpChiTietNhomQuyen.Controls.Add(this.dpickDateCreated);
            this.grpChiTietNhomQuyen.Controls.Add(this.labelX1);
            this.grpChiTietNhomQuyen.Controls.Add(this.txtDescription);
            this.grpChiTietNhomQuyen.Controls.Add(this.lbMatKhau);
            this.grpChiTietNhomQuyen.Controls.Add(this.lbTenDangNhap);
            this.grpChiTietNhomQuyen.Controls.Add(this.txtRoleName);
            this.grpChiTietNhomQuyen.DisabledBackColor = System.Drawing.Color.Empty;
            this.grpChiTietNhomQuyen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpChiTietNhomQuyen.Enabled = false;
            this.grpChiTietNhomQuyen.Location = new System.Drawing.Point(0, 278);
            this.grpChiTietNhomQuyen.Name = "grpChiTietNhomQuyen";
            this.grpChiTietNhomQuyen.Size = new System.Drawing.Size(383, 209);
            this.grpChiTietNhomQuyen.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.grpChiTietNhomQuyen.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpChiTietNhomQuyen.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpChiTietNhomQuyen.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.grpChiTietNhomQuyen.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.grpChiTietNhomQuyen.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.grpChiTietNhomQuyen.Style.GradientAngle = 90;
            this.grpChiTietNhomQuyen.TabIndex = 64;
            this.grpChiTietNhomQuyen.TitleHeight = 30;
            this.grpChiTietNhomQuyen.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.grpChiTietNhomQuyen.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpChiTietNhomQuyen.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpChiTietNhomQuyen.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.grpChiTietNhomQuyen.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpChiTietNhomQuyen.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpChiTietNhomQuyen.TitleStyle.GradientAngle = 90;
            this.grpChiTietNhomQuyen.TitleText = "Thông tin chi tiết";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbMatKhau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMatKhau.Location = new System.Drawing.Point(11, 74);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(42, 16);
            this.lbMatKhau.TabIndex = 67;
            this.lbMatKhau.Text = "Miêu tả";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbTenDangNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTenDangNhap.Location = new System.Drawing.Point(11, 38);
            this.lbTenDangNhap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(93, 16);
            this.lbTenDangNhap.TabIndex = 65;
            this.lbTenDangNhap.Text = "Tên nhóm quyền";
            // 
            // txtRoleName
            // 
            this.txtRoleName.BackColor = System.Drawing.SystemColors.Window;
            this.txtRoleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRoleName.Location = new System.Drawing.Point(114, 38);
            this.txtRoleName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(121, 21);
            this.txtRoleName.TabIndex = 0;
            // 
            // tvUsers
            // 
            this.tvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUsers.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvUsers.FullRowSelect = true;
            this.tvUsers.HotTracking = true;
            this.tvUsers.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tvUsers.Location = new System.Drawing.Point(0, 0);
            this.tvUsers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tvUsers.Name = "tvUsers";
            this.tvUsers.Size = new System.Drawing.Size(383, 487);
            this.tvUsers.TabIndex = 33;
            this.tvUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvUsers_MouseClick);
            // 
            // grpQuyenHan
            // 
            this.grpQuyenHan.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpQuyenHan.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpQuyenHan.Controls.Add(this.ribbonBar1);
            this.grpQuyenHan.DisabledBackColor = System.Drawing.Color.Empty;
            this.grpQuyenHan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpQuyenHan.Location = new System.Drawing.Point(0, 410);
            this.grpQuyenHan.Name = "grpQuyenHan";
            this.grpQuyenHan.Size = new System.Drawing.Size(723, 99);
            this.grpQuyenHan.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.grpQuyenHan.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpQuyenHan.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpQuyenHan.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.grpQuyenHan.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.grpQuyenHan.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.grpQuyenHan.Style.GradientAngle = 90;
            this.grpQuyenHan.TabIndex = 38;
            this.grpQuyenHan.TitleHeight = 30;
            this.grpQuyenHan.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.grpQuyenHan.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpQuyenHan.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpQuyenHan.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.grpQuyenHan.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpQuyenHan.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpQuyenHan.TitleStyle.GradientAngle = 90;
            this.grpQuyenHan.TitleText = "Quản lý quyền";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.BackgroundHoverEnabled = false;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddPermissions,
            this.btnDongHet,
            this.btnMoHet,
            this.lbThongBaoQuyen});
            this.ribbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar1.Location = new System.Drawing.Point(0, 30);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.ShowShortcutKeysInToolTips = true;
            this.ribbonBar1.Size = new System.Drawing.Size(723, 72);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 33;
            this.ribbonBar1.Text = "Phân quyền";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.TitleVisible = false;
            // 
            // btnAddPermissions
            // 
            this.btnAddPermissions.BeginGroup = true;
            this.btnAddPermissions.Image = global::QLTB.Properties.Resources.reload_f2;
            this.btnAddPermissions.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAddPermissions.Name = "btnAddPermissions";
            this.btnAddPermissions.RibbonWordWrap = false;
            this.btnAddPermissions.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.btnAddPermissions.Text = "Tạo quyền từ menu chính";
            this.btnAddPermissions.Tooltip = "Tạo quyền từ menu chính";
            this.btnAddPermissions.Click += new System.EventHandler(this.btnAddPermissions_Click);
            // 
            // btnDongHet
            // 
            this.btnDongHet.BeginGroup = true;
            this.btnDongHet.Image = global::QLTB.Properties.Resources.stop_f2;
            this.btnDongHet.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDongHet.Name = "btnDongHet";
            this.btnDongHet.RibbonWordWrap = false;
            this.btnDongHet.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.btnDongHet.Text = "Đóng tất cả";
            this.btnDongHet.Tooltip = "Đóng tất cả cây phân quyền";
            // 
            // btnMoHet
            // 
            this.btnMoHet.BeginGroup = true;
            this.btnMoHet.Image = global::QLTB.Properties.Resources.cancel;
            this.btnMoHet.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMoHet.Name = "btnMoHet";
            this.btnMoHet.RibbonWordWrap = false;
            this.btnMoHet.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftS);
            this.btnMoHet.Text = "Mở tất cả";
            this.btnMoHet.Tooltip = "Mở tất cả cây phân quyền";
            // 
            // lbThongBaoQuyen
            // 
            this.lbThongBaoQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbThongBaoQuyen.ForeColor = System.Drawing.Color.Red;
            this.lbThongBaoQuyen.Name = "lbThongBaoQuyen";
            this.lbThongBaoQuyen.Text = "     ";
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.ribbonBar2);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 307);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(723, 103);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 42;
            this.expandablePanel1.TitleHeight = 30;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Phân quyền chi tiết";
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.BackgroundHoverEnabled = false;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ribbonBar2.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            this.ribbonBar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar2.Location = new System.Drawing.Point(0, 30);
            this.ribbonBar2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.ShowShortcutKeysInToolTips = true;
            this.ribbonBar2.Size = new System.Drawing.Size(723, 72);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar2.TabIndex = 33;
            this.ribbonBar2.Text = "Phân quyền";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.TitleVisible = false;
            this.ribbonBar2.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.chbIsView,
            this.chbChiThem,
            this.chbIsUpdate,
            this.chbChiXoa});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // chbIsView
            // 
            this.chbIsView.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Top;
            this.chbIsView.Checked = true;
            this.chbIsView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsView.Enabled = false;
            this.chbIsView.Name = "chbIsView";
            this.chbIsView.Text = "Chỉ xem";
            // 
            // chbChiThem
            // 
            this.chbChiThem.BeginGroup = true;
            this.chbChiThem.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Top;
            this.chbChiThem.Checked = true;
            this.chbChiThem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbChiThem.Name = "chbChiThem";
            this.chbChiThem.Text = "Chỉ thêm";
            // 
            // chbIsUpdate
            // 
            this.chbIsUpdate.BeginGroup = true;
            this.chbIsUpdate.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Top;
            this.chbIsUpdate.Checked = true;
            this.chbIsUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsUpdate.Enabled = false;
            this.chbIsUpdate.Name = "chbIsUpdate";
            this.chbIsUpdate.Text = "Chỉ sửa";
            // 
            // chbChiXoa
            // 
            this.chbChiXoa.BeginGroup = true;
            this.chbChiXoa.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Top;
            this.chbChiXoa.Checked = true;
            this.chbChiXoa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbChiXoa.Name = "chbChiXoa";
            this.chbChiXoa.Text = "Chỉ xóa";
            // 
            // tvPermisions
            // 
            this.tvPermisions.CheckBoxes = true;
            this.tvPermisions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvPermisions.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvPermisions.FullRowSelect = true;
            this.tvPermisions.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tvPermisions.Location = new System.Drawing.Point(0, 0);
            this.tvPermisions.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tvPermisions.Name = "tvPermisions";
            this.tvPermisions.Size = new System.Drawing.Size(723, 307);
            this.tvPermisions.TabIndex = 43;
            this.tvPermisions.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvPermisions_AfterCheck);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Controls.Add(this.expandablePanel1);
            this.panelEx1.Controls.Add(this.grpQuyenHan);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(389, 79);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(723, 509);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 50;
            this.panelEx1.Text = "panelEx1";
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(389, 79);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(6, 509);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 54;
            this.expandableSplitter1.TabStop = false;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.tvPermisions);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(723, 307);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 50;
            this.panelEx2.Text = "panelEx2";
            // 
            // ContextMenuNQ
            // 
            this.ContextMenuNQ.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStripThemTK,
            this.btnStripSuaQuyen,
            this.btnStripXoaQuyen});
            this.ContextMenuNQ.Name = "ContextMenuNQ";
            this.ContextMenuNQ.Size = new System.Drawing.Size(158, 70);
            // 
            // btnStripSuaQuyen
            // 
            this.btnStripSuaQuyen.Image = global::QLTB.Properties.Resources.save_icon;
            this.btnStripSuaQuyen.Name = "btnStripSuaQuyen";
            this.btnStripSuaQuyen.Size = new System.Drawing.Size(157, 22);
            this.btnStripSuaQuyen.Text = "Sửa quyền";
            // 
            // btnStripXoaQuyen
            // 
            this.btnStripXoaQuyen.Image = global::QLTB.Properties.Resources.b_drop;
            this.btnStripXoaQuyen.Name = "btnStripXoaQuyen";
            this.btnStripXoaQuyen.Size = new System.Drawing.Size(157, 22);
            this.btnStripXoaQuyen.Text = "Xóa";
            this.btnStripXoaQuyen.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // btnStripThemTK
            // 
            this.btnStripThemTK.Image = global::QLTB.Properties.Resources.add;
            this.btnStripThemTK.Name = "btnStripThemTK";
            this.btnStripThemTK.Size = new System.Drawing.Size(157, 22);
            this.btnStripThemTK.Text = "Thêm tài khoản";
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.BackgroundStyle.Class = "RichTextBoxBorder";
            this.txtDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescription.Location = new System.Drawing.Point(114, 74);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n\\" +
    "viewkind4\\uc1\\pard\\fs18\\par\r\n}\r\n";
            this.txtDescription.Size = new System.Drawing.Size(253, 78);
            this.txtDescription.TabIndex = 68;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 165);
            this.labelX1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(51, 16);
            this.labelX1.TabIndex = 69;
            this.labelX1.Text = "Ngày tạo";
            // 
            // dpickDateCreated
            // 
            // 
            // 
            // 
            this.dpickDateCreated.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dpickDateCreated.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickDateCreated.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dpickDateCreated.ButtonDropDown.Visible = true;
            this.dpickDateCreated.IsPopupCalendarOpen = false;
            this.dpickDateCreated.Location = new System.Drawing.Point(114, 165);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dpickDateCreated.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickDateCreated.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dpickDateCreated.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dpickDateCreated.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dpickDateCreated.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dpickDateCreated.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dpickDateCreated.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dpickDateCreated.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dpickDateCreated.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dpickDateCreated.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickDateCreated.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dpickDateCreated.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dpickDateCreated.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dpickDateCreated.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dpickDateCreated.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dpickDateCreated.MonthCalendar.TodayButtonVisible = true;
            this.dpickDateCreated.Name = "dpickDateCreated";
            this.dpickDateCreated.Size = new System.Drawing.Size(121, 21);
            this.dpickDateCreated.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dpickDateCreated.TabIndex = 70;
            // 
            // ContextMenuND
            // 
            this.ContextMenuND.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStripXemTaiKhoan,
            this.btnStripXoaND,
            this.btnStripChuyenQuyen});
            this.ContextMenuND.Name = "ContextMenuND";
            this.ContextMenuND.Size = new System.Drawing.Size(187, 70);
            // 
            // btnStripXemTaiKhoan
            // 
            this.btnStripXemTaiKhoan.Name = "btnStripXemTaiKhoan";
            this.btnStripXemTaiKhoan.Size = new System.Drawing.Size(186, 22);
            this.btnStripXemTaiKhoan.Text = "Xem chi tiết";
            // 
            // btnStripXoaND
            // 
            this.btnStripXoaND.Name = "btnStripXoaND";
            this.btnStripXoaND.Size = new System.Drawing.Size(186, 22);
            this.btnStripXoaND.Text = "Xóa người dùng";
            // 
            // btnStripChuyenQuyen
            // 
            this.btnStripChuyenQuyen.Name = "btnStripChuyenQuyen";
            this.btnStripChuyenQuyen.Size = new System.Drawing.Size(186, 22);
            this.btnStripChuyenQuyen.Text = "Chuyển nhóm quyền";
            // 
            // frmPhanQuyenTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 588);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.MenuPhanQuyen);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhanQuyenTaiKhoan";
            this.Text = "frmPhanQuyenTaiKhoan";
            this.Load += new System.EventHandler(this.frmPhanQuyenTaiKhoan_Load);
            this.groupPanel1.ResumeLayout(false);
            this.grpChiTietNhomQuyen.ResumeLayout(false);
            this.grpChiTietNhomQuyen.PerformLayout();
            this.grpQuyenHan.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.ContextMenuNQ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dpickDateCreated)).EndInit();
            this.ContextMenuND.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar MenuPhanQuyen;
        private DevComponents.DotNetBar.ButtonItem btnThem;
        private DevComponents.DotNetBar.ButtonItem btnThemNhom;
        private DevComponents.DotNetBar.ButtonItem btnThemNguoiDung;
        private DevComponents.DotNetBar.ButtonItem btnSua;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnKhoa;
        private DevComponents.DotNetBar.ButtonItem btnLuu;
        private DevComponents.DotNetBar.ButtonItem btnLuuPhanQuyen;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ExpandablePanel grpChiTietNhomQuyen;
        private DevComponents.DotNetBar.LabelX lbMatKhau;
        private DevComponents.DotNetBar.LabelX lbTenDangNhap;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TreeView tvUsers;
        private DevComponents.DotNetBar.ExpandablePanel grpQuyenHan;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnAddPermissions;
        private DevComponents.DotNetBar.ButtonItem btnDongHet;
        private DevComponents.DotNetBar.ButtonItem btnMoHet;
        private DevComponents.DotNetBar.LabelItem lbThongBaoQuyen;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.CheckBoxItem chbIsView;
        private DevComponents.DotNetBar.CheckBoxItem chbChiThem;
        private DevComponents.DotNetBar.CheckBoxItem chbIsUpdate;
        private DevComponents.DotNetBar.CheckBoxItem chbChiXoa;
        private System.Windows.Forms.TreeView tvPermisions;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuNQ;
        private System.Windows.Forms.ToolStripMenuItem btnStripSuaQuyen;
        private System.Windows.Forms.ToolStripMenuItem btnStripXoaQuyen;
        private System.Windows.Forms.ToolStripMenuItem btnStripThemTK;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dpickDateCreated;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx txtDescription;
        private System.Windows.Forms.ContextMenuStrip ContextMenuND;
        private System.Windows.Forms.ToolStripMenuItem btnStripXemTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem btnStripXoaND;
        private System.Windows.Forms.ToolStripMenuItem btnStripChuyenQuyen;
    }
}