﻿namespace Cinteros.Xrm.FetchXmlBuilder.Forms
{
    partial class Settings
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
            CSRichTextBoxSyntaxHighlighting.XMLViewerSettings xmlViewerSettings1 = new CSRichTextBoxSyntaxHighlighting.XMLViewerSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.gbEntities = new System.Windows.Forms.GroupBox();
            this.chkEntOnlyAF = new System.Windows.Forms.CheckBox();
            this.chkEntIntersect = new System.Windows.Forms.CheckBox();
            this.chkEntStandard = new System.Windows.Forms.CheckBox();
            this.chkEntCustom = new System.Windows.Forms.CheckBox();
            this.chkEntUncustomizable = new System.Windows.Forms.CheckBox();
            this.chkEntCustomizable = new System.Windows.Forms.CheckBox();
            this.chkEntUnmanaged = new System.Windows.Forms.CheckBox();
            this.chkEntManaged = new System.Windows.Forms.CheckBox();
            this.chkEntAll = new System.Windows.Forms.CheckBox();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.chkAttOnlyRead = new System.Windows.Forms.CheckBox();
            this.chkAttOnlyAF = new System.Windows.Forms.CheckBox();
            this.chkAttStandard = new System.Windows.Forms.CheckBox();
            this.chkAttCustom = new System.Windows.Forms.CheckBox();
            this.chkAttUncustomizable = new System.Windows.Forms.CheckBox();
            this.chkAttCustomizable = new System.Windows.Forms.CheckBox();
            this.chkAttUnmanaged = new System.Windows.Forms.CheckBox();
            this.chkAttManaged = new System.Windows.Forms.CheckBox();
            this.chkAttAll = new System.Windows.Forms.CheckBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.chkResAllPages = new System.Windows.Forms.CheckBox();
            this.cmbSeralizationStyle = new System.Windows.Forms.ComboBox();
            this.rbResRaw = new System.Windows.Forms.RadioButton();
            this.rbResSerialized = new System.Windows.Forms.RadioButton();
            this.rbResGrid = new System.Windows.Forms.RadioButton();
            this.gbAppearance = new System.Windows.Forms.GroupBox();
            this.chkAppAllowUncustViews = new System.Windows.Forms.CheckBox();
            this.chkAppResultsNewWindow = new System.Windows.Forms.CheckBox();
            this.chkAppNoSavePrompt = new System.Windows.Forms.CheckBox();
            this.chkAppSingle = new System.Windows.Forms.CheckBox();
            this.chkAppFriendly = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llShowWelcome = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbDefaultQuery = new System.Windows.Forms.GroupBox();
            this.txtFetch = new CSRichTextBoxSyntaxHighlighting.XMLViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDefaultQuery = new System.Windows.Forms.Button();
            this.btnFormatQuery = new System.Windows.Forms.Button();
            this.gbEntities.SuspendLayout();
            this.gbAttributes.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbAppearance.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDefaultQuery.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEntities
            // 
            this.gbEntities.Controls.Add(this.chkEntOnlyAF);
            this.gbEntities.Controls.Add(this.chkEntIntersect);
            this.gbEntities.Controls.Add(this.chkEntStandard);
            this.gbEntities.Controls.Add(this.chkEntCustom);
            this.gbEntities.Controls.Add(this.chkEntUncustomizable);
            this.gbEntities.Controls.Add(this.chkEntCustomizable);
            this.gbEntities.Controls.Add(this.chkEntUnmanaged);
            this.gbEntities.Controls.Add(this.chkEntManaged);
            this.gbEntities.Controls.Add(this.chkEntAll);
            this.gbEntities.Location = new System.Drawing.Point(240, 12);
            this.gbEntities.Name = "gbEntities";
            this.gbEntities.Size = new System.Drawing.Size(168, 226);
            this.gbEntities.TabIndex = 2;
            this.gbEntities.TabStop = false;
            this.gbEntities.Text = "Show Entities";
            // 
            // chkEntOnlyAF
            // 
            this.chkEntOnlyAF.AutoSize = true;
            this.chkEntOnlyAF.Enabled = false;
            this.chkEntOnlyAF.Location = new System.Drawing.Point(22, 180);
            this.chkEntOnlyAF.Name = "chkEntOnlyAF";
            this.chkEntOnlyAF.Size = new System.Drawing.Size(132, 17);
            this.chkEntOnlyAF.TabIndex = 8;
            this.chkEntOnlyAF.Text = "Only valid for Adv.Find";
            this.chkEntOnlyAF.UseVisualStyleBackColor = true;
            // 
            // chkEntIntersect
            // 
            this.chkEntIntersect.AutoSize = true;
            this.chkEntIntersect.Checked = true;
            this.chkEntIntersect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntIntersect.Enabled = false;
            this.chkEntIntersect.Location = new System.Drawing.Point(22, 160);
            this.chkEntIntersect.Name = "chkEntIntersect";
            this.chkEntIntersect.Size = new System.Drawing.Size(67, 17);
            this.chkEntIntersect.TabIndex = 7;
            this.chkEntIntersect.Text = "Intersect";
            this.chkEntIntersect.UseVisualStyleBackColor = true;
            // 
            // chkEntStandard
            // 
            this.chkEntStandard.AutoSize = true;
            this.chkEntStandard.Checked = true;
            this.chkEntStandard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntStandard.Enabled = false;
            this.chkEntStandard.Location = new System.Drawing.Point(22, 140);
            this.chkEntStandard.Name = "chkEntStandard";
            this.chkEntStandard.Size = new System.Drawing.Size(69, 17);
            this.chkEntStandard.TabIndex = 6;
            this.chkEntStandard.Text = "Standard";
            this.chkEntStandard.UseVisualStyleBackColor = true;
            this.chkEntStandard.CheckedChanged += new System.EventHandler(this.chkEntCustom_CheckedChanged);
            // 
            // chkEntCustom
            // 
            this.chkEntCustom.AutoSize = true;
            this.chkEntCustom.Checked = true;
            this.chkEntCustom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntCustom.Enabled = false;
            this.chkEntCustom.Location = new System.Drawing.Point(22, 120);
            this.chkEntCustom.Name = "chkEntCustom";
            this.chkEntCustom.Size = new System.Drawing.Size(61, 17);
            this.chkEntCustom.TabIndex = 5;
            this.chkEntCustom.Text = "Custom";
            this.chkEntCustom.UseVisualStyleBackColor = true;
            this.chkEntCustom.CheckedChanged += new System.EventHandler(this.chkEntCustom_CheckedChanged);
            // 
            // chkEntUncustomizable
            // 
            this.chkEntUncustomizable.AutoSize = true;
            this.chkEntUncustomizable.Checked = true;
            this.chkEntUncustomizable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntUncustomizable.Enabled = false;
            this.chkEntUncustomizable.Location = new System.Drawing.Point(22, 100);
            this.chkEntUncustomizable.Name = "chkEntUncustomizable";
            this.chkEntUncustomizable.Size = new System.Drawing.Size(101, 17);
            this.chkEntUncustomizable.TabIndex = 4;
            this.chkEntUncustomizable.Text = "Uncustomizable";
            this.chkEntUncustomizable.UseVisualStyleBackColor = true;
            this.chkEntUncustomizable.CheckedChanged += new System.EventHandler(this.chkEntCust_CheckedChanged);
            // 
            // chkEntCustomizable
            // 
            this.chkEntCustomizable.AutoSize = true;
            this.chkEntCustomizable.Checked = true;
            this.chkEntCustomizable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntCustomizable.Enabled = false;
            this.chkEntCustomizable.Location = new System.Drawing.Point(22, 80);
            this.chkEntCustomizable.Name = "chkEntCustomizable";
            this.chkEntCustomizable.Size = new System.Drawing.Size(88, 17);
            this.chkEntCustomizable.TabIndex = 3;
            this.chkEntCustomizable.Text = "Customizable";
            this.chkEntCustomizable.UseVisualStyleBackColor = true;
            this.chkEntCustomizable.CheckedChanged += new System.EventHandler(this.chkEntCust_CheckedChanged);
            // 
            // chkEntUnmanaged
            // 
            this.chkEntUnmanaged.AutoSize = true;
            this.chkEntUnmanaged.Checked = true;
            this.chkEntUnmanaged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntUnmanaged.Enabled = false;
            this.chkEntUnmanaged.Location = new System.Drawing.Point(22, 60);
            this.chkEntUnmanaged.Name = "chkEntUnmanaged";
            this.chkEntUnmanaged.Size = new System.Drawing.Size(84, 17);
            this.chkEntUnmanaged.TabIndex = 2;
            this.chkEntUnmanaged.Text = "Unmanaged";
            this.chkEntUnmanaged.UseVisualStyleBackColor = true;
            this.chkEntUnmanaged.CheckedChanged += new System.EventHandler(this.chkEntMgd_CheckedChanged);
            // 
            // chkEntManaged
            // 
            this.chkEntManaged.AutoSize = true;
            this.chkEntManaged.Checked = true;
            this.chkEntManaged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntManaged.Enabled = false;
            this.chkEntManaged.Location = new System.Drawing.Point(22, 40);
            this.chkEntManaged.Name = "chkEntManaged";
            this.chkEntManaged.Size = new System.Drawing.Size(71, 17);
            this.chkEntManaged.TabIndex = 1;
            this.chkEntManaged.Text = "Managed";
            this.chkEntManaged.UseVisualStyleBackColor = true;
            this.chkEntManaged.CheckedChanged += new System.EventHandler(this.chkEntMgd_CheckedChanged);
            // 
            // chkEntAll
            // 
            this.chkEntAll.AutoSize = true;
            this.chkEntAll.Checked = true;
            this.chkEntAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEntAll.Location = new System.Drawing.Point(16, 20);
            this.chkEntAll.Name = "chkEntAll";
            this.chkEntAll.Size = new System.Drawing.Size(37, 17);
            this.chkEntAll.TabIndex = 0;
            this.chkEntAll.Text = "All";
            this.chkEntAll.UseVisualStyleBackColor = true;
            this.chkEntAll.CheckedChanged += new System.EventHandler(this.chkEntAll_CheckedChanged);
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.chkAttOnlyRead);
            this.gbAttributes.Controls.Add(this.chkAttOnlyAF);
            this.gbAttributes.Controls.Add(this.chkAttStandard);
            this.gbAttributes.Controls.Add(this.chkAttCustom);
            this.gbAttributes.Controls.Add(this.chkAttUncustomizable);
            this.gbAttributes.Controls.Add(this.chkAttCustomizable);
            this.gbAttributes.Controls.Add(this.chkAttUnmanaged);
            this.gbAttributes.Controls.Add(this.chkAttManaged);
            this.gbAttributes.Controls.Add(this.chkAttAll);
            this.gbAttributes.Location = new System.Drawing.Point(414, 12);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(168, 226);
            this.gbAttributes.TabIndex = 3;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Show Attributes";
            // 
            // chkAttOnlyRead
            // 
            this.chkAttOnlyRead.AutoSize = true;
            this.chkAttOnlyRead.Enabled = false;
            this.chkAttOnlyRead.Location = new System.Drawing.Point(22, 180);
            this.chkAttOnlyRead.Name = "chkAttOnlyRead";
            this.chkAttOnlyRead.Size = new System.Drawing.Size(116, 17);
            this.chkAttOnlyRead.TabIndex = 9;
            this.chkAttOnlyRead.Text = "Only valid for Read";
            this.chkAttOnlyRead.UseVisualStyleBackColor = true;
            // 
            // chkAttOnlyAF
            // 
            this.chkAttOnlyAF.AutoSize = true;
            this.chkAttOnlyAF.Enabled = false;
            this.chkAttOnlyAF.Location = new System.Drawing.Point(22, 160);
            this.chkAttOnlyAF.Name = "chkAttOnlyAF";
            this.chkAttOnlyAF.Size = new System.Drawing.Size(132, 17);
            this.chkAttOnlyAF.TabIndex = 8;
            this.chkAttOnlyAF.Text = "Only valid for Adv.Find";
            this.chkAttOnlyAF.UseVisualStyleBackColor = true;
            // 
            // chkAttStandard
            // 
            this.chkAttStandard.AutoSize = true;
            this.chkAttStandard.Checked = true;
            this.chkAttStandard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAttStandard.Enabled = false;
            this.chkAttStandard.Location = new System.Drawing.Point(22, 140);
            this.chkAttStandard.Name = "chkAttStandard";
            this.chkAttStandard.Size = new System.Drawing.Size(69, 17);
            this.chkAttStandard.TabIndex = 6;
            this.chkAttStandard.Text = "Standard";
            this.chkAttStandard.UseVisualStyleBackColor = true;
            this.chkAttStandard.CheckedChanged += new System.EventHandler(this.chkAttCustom_CheckedChanged);
            // 
            // chkAttCustom
            // 
            this.chkAttCustom.AutoSize = true;
            this.chkAttCustom.Checked = true;
            this.chkAttCustom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAttCustom.Enabled = false;
            this.chkAttCustom.Location = new System.Drawing.Point(22, 120);
            this.chkAttCustom.Name = "chkAttCustom";
            this.chkAttCustom.Size = new System.Drawing.Size(61, 17);
            this.chkAttCustom.TabIndex = 5;
            this.chkAttCustom.Text = "Custom";
            this.chkAttCustom.UseVisualStyleBackColor = true;
            this.chkAttCustom.CheckedChanged += new System.EventHandler(this.chkAttCustom_CheckedChanged);
            // 
            // chkAttUncustomizable
            // 
            this.chkAttUncustomizable.AutoSize = true;
            this.chkAttUncustomizable.Checked = true;
            this.chkAttUncustomizable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAttUncustomizable.Enabled = false;
            this.chkAttUncustomizable.Location = new System.Drawing.Point(22, 100);
            this.chkAttUncustomizable.Name = "chkAttUncustomizable";
            this.chkAttUncustomizable.Size = new System.Drawing.Size(101, 17);
            this.chkAttUncustomizable.TabIndex = 4;
            this.chkAttUncustomizable.Text = "Uncustomizable";
            this.chkAttUncustomizable.UseVisualStyleBackColor = true;
            this.chkAttUncustomizable.CheckedChanged += new System.EventHandler(this.chkAttCust_CheckedChanged);
            // 
            // chkAttCustomizable
            // 
            this.chkAttCustomizable.AutoSize = true;
            this.chkAttCustomizable.Checked = true;
            this.chkAttCustomizable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAttCustomizable.Enabled = false;
            this.chkAttCustomizable.Location = new System.Drawing.Point(22, 80);
            this.chkAttCustomizable.Name = "chkAttCustomizable";
            this.chkAttCustomizable.Size = new System.Drawing.Size(88, 17);
            this.chkAttCustomizable.TabIndex = 3;
            this.chkAttCustomizable.Text = "Customizable";
            this.chkAttCustomizable.UseVisualStyleBackColor = true;
            this.chkAttCustomizable.CheckedChanged += new System.EventHandler(this.chkAttCust_CheckedChanged);
            // 
            // chkAttUnmanaged
            // 
            this.chkAttUnmanaged.AutoSize = true;
            this.chkAttUnmanaged.Checked = true;
            this.chkAttUnmanaged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAttUnmanaged.Enabled = false;
            this.chkAttUnmanaged.Location = new System.Drawing.Point(22, 60);
            this.chkAttUnmanaged.Name = "chkAttUnmanaged";
            this.chkAttUnmanaged.Size = new System.Drawing.Size(84, 17);
            this.chkAttUnmanaged.TabIndex = 2;
            this.chkAttUnmanaged.Text = "Unmanaged";
            this.chkAttUnmanaged.UseVisualStyleBackColor = true;
            this.chkAttUnmanaged.CheckedChanged += new System.EventHandler(this.chkAttMgd_CheckedChanged);
            // 
            // chkAttManaged
            // 
            this.chkAttManaged.AutoSize = true;
            this.chkAttManaged.Checked = true;
            this.chkAttManaged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAttManaged.Enabled = false;
            this.chkAttManaged.Location = new System.Drawing.Point(22, 40);
            this.chkAttManaged.Name = "chkAttManaged";
            this.chkAttManaged.Size = new System.Drawing.Size(71, 17);
            this.chkAttManaged.TabIndex = 1;
            this.chkAttManaged.Text = "Managed";
            this.chkAttManaged.UseVisualStyleBackColor = true;
            this.chkAttManaged.CheckedChanged += new System.EventHandler(this.chkAttMgd_CheckedChanged);
            // 
            // chkAttAll
            // 
            this.chkAttAll.AutoSize = true;
            this.chkAttAll.Checked = true;
            this.chkAttAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAttAll.Location = new System.Drawing.Point(12, 20);
            this.chkAttAll.Name = "chkAttAll";
            this.chkAttAll.Size = new System.Drawing.Size(37, 17);
            this.chkAttAll.TabIndex = 0;
            this.chkAttAll.Text = "All";
            this.chkAttAll.UseVisualStyleBackColor = true;
            this.chkAttAll.CheckedChanged += new System.EventHandler(this.chkAttAll_CheckedChanged);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.chkResAllPages);
            this.gbResult.Controls.Add(this.cmbSeralizationStyle);
            this.gbResult.Controls.Add(this.rbResRaw);
            this.gbResult.Controls.Add(this.rbResSerialized);
            this.gbResult.Controls.Add(this.rbResGrid);
            this.gbResult.Location = new System.Drawing.Point(12, 135);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(222, 103);
            this.gbResult.TabIndex = 1;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result view";
            // 
            // chkResAllPages
            // 
            this.chkResAllPages.AutoSize = true;
            this.chkResAllPages.Location = new System.Drawing.Point(16, 80);
            this.chkResAllPages.Name = "chkResAllPages";
            this.chkResAllPages.Size = new System.Drawing.Size(111, 17);
            this.chkResAllPages.TabIndex = 4;
            this.chkResAllPages.Text = "Retrieve all pages";
            this.chkResAllPages.UseVisualStyleBackColor = true;
            // 
            // cmbSeralizationStyle
            // 
            this.cmbSeralizationStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeralizationStyle.Enabled = false;
            this.cmbSeralizationStyle.FormattingEnabled = true;
            this.cmbSeralizationStyle.Items.AddRange(new object[] {
            "Explicit XML",
            "Basic XML",
            "JSON",
            "EntityCollection"});
            this.cmbSeralizationStyle.Location = new System.Drawing.Point(92, 38);
            this.cmbSeralizationStyle.Name = "cmbSeralizationStyle";
            this.cmbSeralizationStyle.Size = new System.Drawing.Size(122, 21);
            this.cmbSeralizationStyle.TabIndex = 2;
            // 
            // rbResRaw
            // 
            this.rbResRaw.AutoSize = true;
            this.rbResRaw.Location = new System.Drawing.Point(16, 60);
            this.rbResRaw.Name = "rbResRaw";
            this.rbResRaw.Size = new System.Drawing.Size(102, 17);
            this.rbResRaw.TabIndex = 3;
            this.rbResRaw.Text = "Raw fetch result";
            this.rbResRaw.UseVisualStyleBackColor = true;
            // 
            // rbResSerialized
            // 
            this.rbResSerialized.AutoSize = true;
            this.rbResSerialized.Location = new System.Drawing.Point(16, 40);
            this.rbResSerialized.Name = "rbResSerialized";
            this.rbResSerialized.Size = new System.Drawing.Size(70, 17);
            this.rbResSerialized.TabIndex = 1;
            this.rbResSerialized.Text = "Serialized";
            this.rbResSerialized.UseVisualStyleBackColor = true;
            this.rbResSerialized.CheckedChanged += new System.EventHandler(this.rbResSerialized_CheckedChanged);
            // 
            // rbResGrid
            // 
            this.rbResGrid.AutoSize = true;
            this.rbResGrid.Checked = true;
            this.rbResGrid.Location = new System.Drawing.Point(16, 20);
            this.rbResGrid.Name = "rbResGrid";
            this.rbResGrid.Size = new System.Drawing.Size(48, 17);
            this.rbResGrid.TabIndex = 0;
            this.rbResGrid.TabStop = true;
            this.rbResGrid.Text = "View";
            this.rbResGrid.UseVisualStyleBackColor = true;
            // 
            // gbAppearance
            // 
            this.gbAppearance.Controls.Add(this.chkAppAllowUncustViews);
            this.gbAppearance.Controls.Add(this.chkAppResultsNewWindow);
            this.gbAppearance.Controls.Add(this.chkAppNoSavePrompt);
            this.gbAppearance.Controls.Add(this.chkAppSingle);
            this.gbAppearance.Controls.Add(this.chkAppFriendly);
            this.gbAppearance.Location = new System.Drawing.Point(12, 12);
            this.gbAppearance.Name = "gbAppearance";
            this.gbAppearance.Size = new System.Drawing.Size(222, 121);
            this.gbAppearance.TabIndex = 0;
            this.gbAppearance.TabStop = false;
            this.gbAppearance.Text = "Appearance";
            // 
            // chkAppAllowUncustViews
            // 
            this.chkAppAllowUncustViews.AutoSize = true;
            this.chkAppAllowUncustViews.Location = new System.Drawing.Point(16, 100);
            this.chkAppAllowUncustViews.Name = "chkAppAllowUncustViews";
            this.chkAppAllowUncustViews.Size = new System.Drawing.Size(198, 17);
            this.chkAppAllowUncustViews.TabIndex = 6;
            this.chkAppAllowUncustViews.Text = "Allow opening uncustomizable views";
            this.chkAppAllowUncustViews.UseVisualStyleBackColor = true;
            // 
            // chkAppResultsNewWindow
            // 
            this.chkAppResultsNewWindow.AutoSize = true;
            this.chkAppResultsNewWindow.Location = new System.Drawing.Point(16, 80);
            this.chkAppResultsNewWindow.Name = "chkAppResultsNewWindow";
            this.chkAppResultsNewWindow.Size = new System.Drawing.Size(192, 17);
            this.chkAppResultsNewWindow.TabIndex = 5;
            this.chkAppResultsNewWindow.Text = "Always open results in new window";
            this.chkAppResultsNewWindow.UseVisualStyleBackColor = true;
            // 
            // chkAppNoSavePrompt
            // 
            this.chkAppNoSavePrompt.AutoSize = true;
            this.chkAppNoSavePrompt.Location = new System.Drawing.Point(16, 60);
            this.chkAppNoSavePrompt.Name = "chkAppNoSavePrompt";
            this.chkAppNoSavePrompt.Size = new System.Drawing.Size(159, 17);
            this.chkAppNoSavePrompt.TabIndex = 4;
            this.chkAppNoSavePrompt.Text = "Do not prompt to save to file";
            this.chkAppNoSavePrompt.UseVisualStyleBackColor = true;
            // 
            // chkAppSingle
            // 
            this.chkAppSingle.AutoSize = true;
            this.chkAppSingle.Location = new System.Drawing.Point(16, 40);
            this.chkAppSingle.Name = "chkAppSingle";
            this.chkAppSingle.Size = new System.Drawing.Size(203, 17);
            this.chkAppSingle.TabIndex = 3;
            this.chkAppSingle.Text = "Use single quotation in rendered XML";
            this.chkAppSingle.UseVisualStyleBackColor = true;
            // 
            // chkAppFriendly
            // 
            this.chkAppFriendly.AutoSize = true;
            this.chkAppFriendly.Location = new System.Drawing.Point(16, 20);
            this.chkAppFriendly.Name = "chkAppFriendly";
            this.chkAppFriendly.Size = new System.Drawing.Size(145, 17);
            this.chkAppFriendly.TabIndex = 1;
            this.chkAppFriendly.Text = "Friendly names (CTRL+F)";
            this.chkAppFriendly.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.llShowWelcome);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(12, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 53);
            this.panel1.TabIndex = 5;
            // 
            // llShowWelcome
            // 
            this.llShowWelcome.AutoSize = true;
            this.llShowWelcome.Location = new System.Drawing.Point(7, 24);
            this.llShowWelcome.Name = "llShowWelcome";
            this.llShowWelcome.Size = new System.Drawing.Size(114, 13);
            this.llShowWelcome.TabIndex = 2;
            this.llShowWelcome.TabStop = true;
            this.llShowWelcome.Text = "Show welcome screen";
            this.llShowWelcome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowWelcome_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(486, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(403, 19);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbDefaultQuery
            // 
            this.gbDefaultQuery.Controls.Add(this.txtFetch);
            this.gbDefaultQuery.Controls.Add(this.panel2);
            this.gbDefaultQuery.Location = new System.Drawing.Point(12, 244);
            this.gbDefaultQuery.Name = "gbDefaultQuery";
            this.gbDefaultQuery.Size = new System.Drawing.Size(570, 145);
            this.gbDefaultQuery.TabIndex = 6;
            this.gbDefaultQuery.TabStop = false;
            this.gbDefaultQuery.Text = "Default New Query";
            // 
            // txtFetch
            // 
            this.txtFetch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFetch.Location = new System.Drawing.Point(3, 16);
            this.txtFetch.Name = "txtFetch";
            xmlViewerSettings1.AttributeKey = System.Drawing.Color.Red;
            xmlViewerSettings1.AttributeValue = System.Drawing.Color.Blue;
            xmlViewerSettings1.Comment = System.Drawing.Color.Empty;
            xmlViewerSettings1.Element = System.Drawing.Color.DarkRed;
            xmlViewerSettings1.FontName = "Consolas";
            xmlViewerSettings1.FontSize = 9F;
            xmlViewerSettings1.QuoteCharacter = '\"';
            xmlViewerSettings1.Tag = System.Drawing.Color.Blue;
            xmlViewerSettings1.Value = System.Drawing.Color.Black;
            this.txtFetch.Settings = xmlViewerSettings1;
            this.txtFetch.Size = new System.Drawing.Size(483, 126);
            this.txtFetch.TabIndex = 4;
            this.txtFetch.Text = "";
            this.txtFetch.Leave += new System.EventHandler(this.txtFetch_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDefaultQuery);
            this.panel2.Controls.Add(this.btnFormatQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(486, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 126);
            this.panel2.TabIndex = 5;
            // 
            // btnDefaultQuery
            // 
            this.btnDefaultQuery.Location = new System.Drawing.Point(3, 3);
            this.btnDefaultQuery.Name = "btnDefaultQuery";
            this.btnDefaultQuery.Size = new System.Drawing.Size(75, 23);
            this.btnDefaultQuery.TabIndex = 1;
            this.btnDefaultQuery.Text = "Default";
            this.btnDefaultQuery.UseVisualStyleBackColor = true;
            this.btnDefaultQuery.Click += new System.EventHandler(this.btnDefaultQuery_Click);
            // 
            // btnFormatQuery
            // 
            this.btnFormatQuery.Location = new System.Drawing.Point(3, 100);
            this.btnFormatQuery.Name = "btnFormatQuery";
            this.btnFormatQuery.Size = new System.Drawing.Size(75, 23);
            this.btnFormatQuery.TabIndex = 0;
            this.btnFormatQuery.Text = "Format";
            this.btnFormatQuery.UseVisualStyleBackColor = true;
            this.btnFormatQuery.Click += new System.EventHandler(this.btnFormatQuery_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(593, 456);
            this.Controls.Add(this.gbDefaultQuery);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbAppearance);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbAttributes);
            this.Controls.Add(this.gbEntities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.gbEntities.ResumeLayout(false);
            this.gbEntities.PerformLayout();
            this.gbAttributes.ResumeLayout(false);
            this.gbAttributes.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbAppearance.ResumeLayout(false);
            this.gbAppearance.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDefaultQuery.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEntities;
        private System.Windows.Forms.CheckBox chkEntAll;
        private System.Windows.Forms.CheckBox chkEntOnlyAF;
        private System.Windows.Forms.CheckBox chkEntIntersect;
        private System.Windows.Forms.CheckBox chkEntStandard;
        private System.Windows.Forms.CheckBox chkEntCustom;
        private System.Windows.Forms.CheckBox chkEntUncustomizable;
        private System.Windows.Forms.CheckBox chkEntCustomizable;
        private System.Windows.Forms.CheckBox chkEntUnmanaged;
        private System.Windows.Forms.CheckBox chkEntManaged;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.CheckBox chkAttOnlyRead;
        private System.Windows.Forms.CheckBox chkAttOnlyAF;
        private System.Windows.Forms.CheckBox chkAttStandard;
        private System.Windows.Forms.CheckBox chkAttCustom;
        private System.Windows.Forms.CheckBox chkAttUncustomizable;
        private System.Windows.Forms.CheckBox chkAttCustomizable;
        private System.Windows.Forms.CheckBox chkAttUnmanaged;
        private System.Windows.Forms.CheckBox chkAttManaged;
        private System.Windows.Forms.CheckBox chkAttAll;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.GroupBox gbAppearance;
        private System.Windows.Forms.CheckBox chkAppSingle;
        private System.Windows.Forms.CheckBox chkAppFriendly;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rbResGrid;
        private System.Windows.Forms.RadioButton rbResRaw;
        private System.Windows.Forms.RadioButton rbResSerialized;
        private System.Windows.Forms.ComboBox cmbSeralizationStyle;
        private System.Windows.Forms.CheckBox chkResAllPages;
        private System.Windows.Forms.CheckBox chkAppNoSavePrompt;
        private System.Windows.Forms.CheckBox chkAppResultsNewWindow;
        private System.Windows.Forms.LinkLabel llShowWelcome;
        private System.Windows.Forms.CheckBox chkAppAllowUncustViews;
        private System.Windows.Forms.GroupBox gbDefaultQuery;
        internal CSRichTextBoxSyntaxHighlighting.XMLViewer txtFetch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFormatQuery;
        private System.Windows.Forms.Button btnDefaultQuery;
    }
}