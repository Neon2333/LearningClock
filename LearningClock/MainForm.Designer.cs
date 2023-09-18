
namespace LearningClock
{
    partial class LearningClock
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.tileViewColumn_taskDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_taskDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.digitalGauge_clock = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.digitalEffectLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalEffectLayerComponent();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panelControl_taskList = new DevExpress.XtraEditors.PanelControl();
            this.gridControl_taskList = new DevExpress.XtraGrid.GridControl();
            this.tileView_taskList = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.simpleButton_clearTask = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_modifyTask = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_delTask = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_addTask = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_inputTaskDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_currentTask = new DevExpress.XtraEditors.LabelControl();
            this.gaugeControl_clock = new DevExpress.XtraGauges.Win.GaugeControl();
            this.panelControl_setTime = new DevExpress.XtraEditors.PanelControl();
            this.timeEdit_setTime = new DevExpress.XtraEditors.TimeEdit();
            this.toggleSwitch_4h = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch_3h = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch_2h = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch_1h = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch_30m = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch_15m = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl_setTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_currentMode = new DevExpress.XtraEditors.LabelControl();
            this.dGauge1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge_clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalEffectLayerComponent1)).BeginInit();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_taskList)).BeginInit();
            this.panelControl_taskList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_taskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_taskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_inputTaskDescription.Properties)).BeginInit();
            this.gaugeControl_clock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_setTime)).BeginInit();
            this.panelControl_setTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_setTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_4h.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_3h.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_2h.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_1h.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_30m.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_15m.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).BeginInit();
            this.SuspendLayout();
            // 
            // tileViewColumn_taskDescription
            // 
            this.tileViewColumn_taskDescription.Caption = "学习qt";
            this.tileViewColumn_taskDescription.FieldName = "TaskDescription";
            this.tileViewColumn_taskDescription.MinWidth = 25;
            this.tileViewColumn_taskDescription.Name = "tileViewColumn_taskDescription";
            this.tileViewColumn_taskDescription.Visible = true;
            this.tileViewColumn_taskDescription.VisibleIndex = 0;
            this.tileViewColumn_taskDescription.Width = 94;
            // 
            // tileViewColumn_taskDate
            // 
            this.tileViewColumn_taskDate.Caption = "2023/10/16";
            this.tileViewColumn_taskDate.DisplayFormat.FormatString = "d";
            this.tileViewColumn_taskDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tileViewColumn_taskDate.FieldName = "CreateTime";
            this.tileViewColumn_taskDate.MinWidth = 25;
            this.tileViewColumn_taskDate.Name = "tileViewColumn_taskDate";
            this.tileViewColumn_taskDate.Visible = true;
            this.tileViewColumn_taskDate.VisibleIndex = 1;
            this.tileViewColumn_taskDate.Width = 94;
            // 
            // digitalGauge_clock
            // 
            this.digitalGauge_clock.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#34000000");
            this.digitalGauge_clock.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#7F93C6");
            this.digitalGauge_clock.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent1});
            this.digitalGauge_clock.Bounds = new System.Drawing.Rectangle(10, 10, 100, 100);
            this.digitalGauge_clock.DigitCount = 6;
            this.digitalGauge_clock.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.digitalGauge_clock.EffectLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalEffectLayerComponent[] {
            this.digitalEffectLayerComponent1});
            this.digitalGauge_clock.Name = "digitalGauge_clock";
            this.digitalGauge_clock.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.digitalGauge_clock.Text = "22:54:10";
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(303.65F, 106.075F);
            this.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style25;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // digitalEffectLayerComponent1
            // 
            this.digitalEffectLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(764F, 274F);
            this.digitalEffectLayerComponent1.Name = "digitalGauge_clock_EffectLayer1";
            this.digitalEffectLayerComponent1.ZOrder = -1000;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.panelControl_taskList);
            this.panel_main.Controls.Add(this.labelControl_currentTask);
            this.panel_main.Controls.Add(this.gaugeControl_clock);
            this.panel_main.Location = new System.Drawing.Point(2, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(794, 508);
            this.panel_main.TabIndex = 4;
            // 
            // panelControl_taskList
            // 
            this.panelControl_taskList.Controls.Add(this.gridControl_taskList);
            this.panelControl_taskList.Controls.Add(this.simpleButton_clearTask);
            this.panelControl_taskList.Controls.Add(this.simpleButton_modifyTask);
            this.panelControl_taskList.Controls.Add(this.simpleButton_delTask);
            this.panelControl_taskList.Controls.Add(this.simpleButton_addTask);
            this.panelControl_taskList.Controls.Add(this.textEdit_inputTaskDescription);
            this.panelControl_taskList.Location = new System.Drawing.Point(157, 53);
            this.panelControl_taskList.Name = "panelControl_taskList";
            this.panelControl_taskList.Size = new System.Drawing.Size(450, 420);
            this.panelControl_taskList.TabIndex = 6;
            // 
            // gridControl_taskList
            // 
            this.gridControl_taskList.Location = new System.Drawing.Point(5, 50);
            this.gridControl_taskList.MainView = this.tileView_taskList;
            this.gridControl_taskList.Name = "gridControl_taskList";
            this.gridControl_taskList.Size = new System.Drawing.Size(350, 365);
            this.gridControl_taskList.TabIndex = 5;
            this.gridControl_taskList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView_taskList});
            // 
            // tileView_taskList
            // 
            this.tileView_taskList.Appearance.ItemFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(88)))), ((int)(((byte)(39)))));
            this.tileView_taskList.Appearance.ItemFocused.BorderColor = System.Drawing.Color.White;
            this.tileView_taskList.Appearance.ItemFocused.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tileView_taskList.Appearance.ItemFocused.ForeColor = System.Drawing.Color.White;
            this.tileView_taskList.Appearance.ItemFocused.Options.UseBackColor = true;
            this.tileView_taskList.Appearance.ItemFocused.Options.UseBorderColor = true;
            this.tileView_taskList.Appearance.ItemFocused.Options.UseFont = true;
            this.tileView_taskList.Appearance.ItemFocused.Options.UseForeColor = true;
            this.tileView_taskList.Appearance.ItemNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(94)))));
            this.tileView_taskList.Appearance.ItemNormal.BorderColor = System.Drawing.Color.Black;
            this.tileView_taskList.Appearance.ItemNormal.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tileView_taskList.Appearance.ItemNormal.ForeColor = System.Drawing.Color.White;
            this.tileView_taskList.Appearance.ItemNormal.Options.UseBackColor = true;
            this.tileView_taskList.Appearance.ItemNormal.Options.UseBorderColor = true;
            this.tileView_taskList.Appearance.ItemNormal.Options.UseFont = true;
            this.tileView_taskList.Appearance.ItemNormal.Options.UseForeColor = true;
            this.tileView_taskList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tileView_taskList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn_taskDescription,
            this.tileViewColumn_taskDate});
            this.tileView_taskList.GridControl = this.gridControl_taskList;
            this.tileView_taskList.Name = "tileView_taskList";
            this.tileView_taskList.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView_taskList.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView_taskList.OptionsTiles.IndentBetweenItems = 0;
            this.tileView_taskList.OptionsTiles.ItemSize = new System.Drawing.Size(350, 40);
            this.tileView_taskList.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView_taskList.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView_taskList.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView_taskList.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 234D;
            tableColumnDefinition2.Length.Value = 86D;
            this.tileView_taskList.TileColumns.Add(tableColumnDefinition1);
            this.tileView_taskList.TileColumns.Add(tableColumnDefinition2);
            this.tileView_taskList.TileRows.Add(tableRowDefinition1);
            tileViewItemElement1.Column = this.tileViewColumn_taskDescription;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "tileViewColumn_taskDescription";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement2.Column = this.tileViewColumn_taskDate;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.Text = "tileViewColumn_taskDate";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView_taskList.TileTemplate.Add(tileViewItemElement1);
            this.tileView_taskList.TileTemplate.Add(tileViewItemElement2);
            this.tileView_taskList.ItemCustomize += new DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(this.tileView_taskList_ItemCustomize);
            this.tileView_taskList.DoubleClick += new System.EventHandler(this.tileView_taskList_DoubleClick);
            // 
            // simpleButton_clearTask
            // 
            this.simpleButton_clearTask.Location = new System.Drawing.Point(361, 143);
            this.simpleButton_clearTask.Name = "simpleButton_clearTask";
            this.simpleButton_clearTask.Size = new System.Drawing.Size(84, 39);
            this.simpleButton_clearTask.TabIndex = 10;
            this.simpleButton_clearTask.Text = "清空(&Q)";
            this.simpleButton_clearTask.Click += new System.EventHandler(this.simpleButton_clearTask_Click);
            // 
            // simpleButton_modifyTask
            // 
            this.simpleButton_modifyTask.Location = new System.Drawing.Point(361, 95);
            this.simpleButton_modifyTask.Name = "simpleButton_modifyTask";
            this.simpleButton_modifyTask.Size = new System.Drawing.Size(84, 39);
            this.simpleButton_modifyTask.TabIndex = 9;
            this.simpleButton_modifyTask.Text = "修改(&M)";
            this.simpleButton_modifyTask.Click += new System.EventHandler(this.simpleButton_modifyTask_Click);
            // 
            // simpleButton_delTask
            // 
            this.simpleButton_delTask.Location = new System.Drawing.Point(361, 50);
            this.simpleButton_delTask.Name = "simpleButton_delTask";
            this.simpleButton_delTask.Size = new System.Drawing.Size(84, 39);
            this.simpleButton_delTask.TabIndex = 8;
            this.simpleButton_delTask.Text = "删除(&D)";
            this.simpleButton_delTask.Click += new System.EventHandler(this.simpleButton_delTask_Click);
            // 
            // simpleButton_addTask
            // 
            this.simpleButton_addTask.Location = new System.Drawing.Point(361, 5);
            this.simpleButton_addTask.Name = "simpleButton_addTask";
            this.simpleButton_addTask.Size = new System.Drawing.Size(84, 39);
            this.simpleButton_addTask.TabIndex = 7;
            this.simpleButton_addTask.Text = "保存(&S)";
            this.simpleButton_addTask.Click += new System.EventHandler(this.simpleButton_addTask_Click);
            // 
            // textEdit_inputTaskDescription
            // 
            this.textEdit_inputTaskDescription.Location = new System.Drawing.Point(5, 5);
            this.textEdit_inputTaskDescription.Name = "textEdit_inputTaskDescription";
            this.textEdit_inputTaskDescription.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.textEdit_inputTaskDescription.Properties.Appearance.Options.UseFont = true;
            this.textEdit_inputTaskDescription.Properties.AutoHeight = false;
            this.textEdit_inputTaskDescription.Properties.NullText = "在这输入学习任务";
            this.textEdit_inputTaskDescription.Size = new System.Drawing.Size(350, 39);
            this.textEdit_inputTaskDescription.TabIndex = 0;
            // 
            // labelControl_currentTask
            // 
            this.labelControl_currentTask.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.labelControl_currentTask.Appearance.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_currentTask.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_currentTask.Appearance.Options.UseBackColor = true;
            this.labelControl_currentTask.Appearance.Options.UseFont = true;
            this.labelControl_currentTask.Appearance.Options.UseForeColor = true;
            this.labelControl_currentTask.Appearance.Options.UseTextOptions = true;
            this.labelControl_currentTask.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl_currentTask.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl_currentTask.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_currentTask.Location = new System.Drawing.Point(157, 3);
            this.labelControl_currentTask.Name = "labelControl_currentTask";
            this.labelControl_currentTask.Size = new System.Drawing.Size(450, 50);
            this.labelControl_currentTask.TabIndex = 3;
            this.labelControl_currentTask.Text = "当前无任务";
            this.labelControl_currentTask.Click += new System.EventHandler(this.labelControl_currentTask_Click);
            this.labelControl_currentTask.DoubleClick += new System.EventHandler(this.labelControl_currentTask_DoubleClick);
            // 
            // gaugeControl_clock
            // 
            this.gaugeControl_clock.AutoLayout = false;
            this.gaugeControl_clock.Controls.Add(this.panelControl_setTime);
            this.gaugeControl_clock.Controls.Add(this.labelControl_setTime);
            this.gaugeControl_clock.Controls.Add(this.labelControl_currentMode);
            this.gaugeControl_clock.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.dGauge1});
            this.gaugeControl_clock.Location = new System.Drawing.Point(3, 100);
            this.gaugeControl_clock.Name = "gaugeControl_clock";
            this.gaugeControl_clock.Size = new System.Drawing.Size(788, 405);
            this.gaugeControl_clock.TabIndex = 2;
            // 
            // panelControl_setTime
            // 
            this.panelControl_setTime.Controls.Add(this.timeEdit_setTime);
            this.panelControl_setTime.Controls.Add(this.toggleSwitch_4h);
            this.panelControl_setTime.Controls.Add(this.toggleSwitch_3h);
            this.panelControl_setTime.Controls.Add(this.toggleSwitch_2h);
            this.panelControl_setTime.Controls.Add(this.toggleSwitch_1h);
            this.panelControl_setTime.Controls.Add(this.toggleSwitch_30m);
            this.panelControl_setTime.Controls.Add(this.toggleSwitch_15m);
            this.panelControl_setTime.Location = new System.Drawing.Point(588, 135);
            this.panelControl_setTime.Name = "panelControl_setTime";
            this.panelControl_setTime.Size = new System.Drawing.Size(193, 256);
            this.panelControl_setTime.TabIndex = 7;
            this.panelControl_setTime.Visible = false;
            // 
            // timeEdit_setTime
            // 
            this.timeEdit_setTime.EditValue = new System.DateTime(2023, 9, 6, 0, 0, 0, 0);
            this.timeEdit_setTime.Location = new System.Drawing.Point(7, 141);
            this.timeEdit_setTime.Name = "timeEdit_setTime";
            this.timeEdit_setTime.Properties.AutoHeight = false;
            this.timeEdit_setTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_setTime.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.timeEdit_setTime.Size = new System.Drawing.Size(180, 58);
            this.timeEdit_setTime.TabIndex = 6;
            // 
            // toggleSwitch_4h
            // 
            this.toggleSwitch_4h.Location = new System.Drawing.Point(99, 99);
            this.toggleSwitch_4h.Name = "toggleSwitch_4h";
            this.toggleSwitch_4h.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.toggleSwitch_4h.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch_4h.Properties.OffText = "4h";
            this.toggleSwitch_4h.Properties.OnText = "4h";
            this.toggleSwitch_4h.Size = new System.Drawing.Size(98, 24);
            this.toggleSwitch_4h.TabIndex = 5;
            this.toggleSwitch_4h.Toggled += new System.EventHandler(this.toggleSwitchs_Toggled);
            // 
            // toggleSwitch_3h
            // 
            this.toggleSwitch_3h.Location = new System.Drawing.Point(5, 99);
            this.toggleSwitch_3h.Name = "toggleSwitch_3h";
            this.toggleSwitch_3h.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.toggleSwitch_3h.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch_3h.Properties.OffText = "3h";
            this.toggleSwitch_3h.Properties.OnText = "3h";
            this.toggleSwitch_3h.Size = new System.Drawing.Size(98, 24);
            this.toggleSwitch_3h.TabIndex = 4;
            this.toggleSwitch_3h.Toggled += new System.EventHandler(this.toggleSwitchs_Toggled);
            // 
            // toggleSwitch_2h
            // 
            this.toggleSwitch_2h.Location = new System.Drawing.Point(99, 58);
            this.toggleSwitch_2h.Name = "toggleSwitch_2h";
            this.toggleSwitch_2h.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.toggleSwitch_2h.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch_2h.Properties.OffText = "2h";
            this.toggleSwitch_2h.Properties.OnText = "2h";
            this.toggleSwitch_2h.Size = new System.Drawing.Size(98, 24);
            this.toggleSwitch_2h.TabIndex = 3;
            this.toggleSwitch_2h.Toggled += new System.EventHandler(this.toggleSwitchs_Toggled);
            // 
            // toggleSwitch_1h
            // 
            this.toggleSwitch_1h.Location = new System.Drawing.Point(5, 58);
            this.toggleSwitch_1h.Name = "toggleSwitch_1h";
            this.toggleSwitch_1h.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.toggleSwitch_1h.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch_1h.Properties.OffText = "1h";
            this.toggleSwitch_1h.Properties.OnText = "1h";
            this.toggleSwitch_1h.Size = new System.Drawing.Size(98, 24);
            this.toggleSwitch_1h.TabIndex = 2;
            this.toggleSwitch_1h.Toggled += new System.EventHandler(this.toggleSwitchs_Toggled);
            // 
            // toggleSwitch_30m
            // 
            this.toggleSwitch_30m.Location = new System.Drawing.Point(99, 18);
            this.toggleSwitch_30m.Name = "toggleSwitch_30m";
            this.toggleSwitch_30m.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.toggleSwitch_30m.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch_30m.Properties.OffText = "30m";
            this.toggleSwitch_30m.Properties.OnText = "30m";
            this.toggleSwitch_30m.Size = new System.Drawing.Size(98, 24);
            this.toggleSwitch_30m.TabIndex = 1;
            this.toggleSwitch_30m.Toggled += new System.EventHandler(this.toggleSwitchs_Toggled);
            // 
            // toggleSwitch_15m
            // 
            this.toggleSwitch_15m.Location = new System.Drawing.Point(5, 18);
            this.toggleSwitch_15m.Name = "toggleSwitch_15m";
            this.toggleSwitch_15m.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.toggleSwitch_15m.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch_15m.Properties.OffText = "15m";
            this.toggleSwitch_15m.Properties.OnText = "15m";
            this.toggleSwitch_15m.Size = new System.Drawing.Size(98, 24);
            this.toggleSwitch_15m.TabIndex = 0;
            this.toggleSwitch_15m.Toggled += new System.EventHandler(this.toggleSwitchs_Toggled);
            // 
            // labelControl_setTime
            // 
            this.labelControl_setTime.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.labelControl_setTime.Appearance.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_setTime.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_setTime.Appearance.Options.UseBackColor = true;
            this.labelControl_setTime.Appearance.Options.UseFont = true;
            this.labelControl_setTime.Appearance.Options.UseForeColor = true;
            this.labelControl_setTime.Appearance.Options.UseTextOptions = true;
            this.labelControl_setTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl_setTime.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl_setTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_setTime.Location = new System.Drawing.Point(588, 85);
            this.labelControl_setTime.Name = "labelControl_setTime";
            this.labelControl_setTime.Size = new System.Drawing.Size(193, 50);
            this.labelControl_setTime.TabIndex = 6;
            this.labelControl_setTime.Text = "计时：0";
            this.labelControl_setTime.Click += new System.EventHandler(this.labelControl_setTime_Click);
            this.labelControl_setTime.DoubleClick += new System.EventHandler(this.labelControl_setTime_DoubleClick);
            // 
            // labelControl_currentMode
            // 
            this.labelControl_currentMode.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(118)))), ((int)(((byte)(147)))));
            this.labelControl_currentMode.Appearance.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_currentMode.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_currentMode.Appearance.Options.UseBackColor = true;
            this.labelControl_currentMode.Appearance.Options.UseFont = true;
            this.labelControl_currentMode.Appearance.Options.UseForeColor = true;
            this.labelControl_currentMode.Appearance.Options.UseTextOptions = true;
            this.labelControl_currentMode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl_currentMode.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl_currentMode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl_currentMode.Location = new System.Drawing.Point(588, 16);
            this.labelControl_currentMode.Name = "labelControl_currentMode";
            this.labelControl_currentMode.Size = new System.Drawing.Size(193, 50);
            this.labelControl_currentMode.TabIndex = 5;
            this.labelControl_currentMode.Text = "模式：时钟";
            this.labelControl_currentMode.Click += new System.EventHandler(this.labelControl_currentMode_Click);
            // 
            // dGauge1
            // 
            this.dGauge1.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0FD4F2FF");
            this.dGauge1.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#D4F2FF");
            this.dGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent2});
            this.dGauge1.Bounds = new System.Drawing.Rectangle(7, 17, 573, 374);
            this.dGauge1.DigitCount = 6;
            this.dGauge1.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.dGauge1.Name = "dGauge1";
            this.dGauge1.Text = "";
            // 
            // digitalBackgroundLayerComponent2
            // 
            this.digitalBackgroundLayerComponent2.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(297.65F, 106.075F);
            this.digitalBackgroundLayerComponent2.Name = "b1";
            this.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style2;
            this.digitalBackgroundLayerComponent2.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // LearningClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 510);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "LearningClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LearningClock";
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge_clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalEffectLayerComponent1)).EndInit();
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_taskList)).EndInit();
            this.panelControl_taskList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_taskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_taskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_inputTaskDescription.Properties)).EndInit();
            this.gaugeControl_clock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_setTime)).EndInit();
            this.panelControl_setTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_setTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_4h.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_3h.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_2h.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_1h.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_30m.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_15m.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge_clock;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalEffectLayerComponent digitalEffectLayerComponent1;
        private System.Windows.Forms.Panel panel_main;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl_clock;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge dGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent2;
        private DevExpress.XtraEditors.LabelControl labelControl_currentTask;
        private DevExpress.XtraEditors.LabelControl labelControl_currentMode;
        private DevExpress.XtraEditors.LabelControl labelControl_setTime;
        private DevExpress.XtraEditors.PanelControl panelControl_setTime;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_30m;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_15m;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_2h;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_1h;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_4h;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_3h;
        private DevExpress.XtraEditors.TimeEdit timeEdit_setTime;
        private DevExpress.XtraGrid.GridControl gridControl_taskList;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView_taskList;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_taskDescription;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_taskDate;
        private DevExpress.XtraEditors.PanelControl panelControl_taskList;
        private DevExpress.XtraEditors.TextEdit textEdit_inputTaskDescription;
        private DevExpress.XtraEditors.SimpleButton simpleButton_addTask;
        private DevExpress.XtraEditors.SimpleButton simpleButton_clearTask;
        private DevExpress.XtraEditors.SimpleButton simpleButton_modifyTask;
        private DevExpress.XtraEditors.SimpleButton simpleButton_delTask;
    }
}