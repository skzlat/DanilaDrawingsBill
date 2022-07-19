using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Linq;
using Tekla.Structures;
using Tekla.Structures.Catalogs;
using Tekla.Structures.Dialog;
using Tekla.Structures.Drawing;
using Tekla.Structures.DrawingInternal;
using Tekla.Structures.Model;

using Tekla.Technology.Akit.UserScript;
using Tekla.Technology.Scripting;

#pragma warning disable 1633 // Unrecognized #pragma directive
#pragma reference @"%XSBIN%\plugins\Tekla.Structures.Catalogs.dll"
#pragma reference @"%XSBIN%\dialogs\Tekla.Structures.Dialog.dll"
#pragma warning restore 1633 // Unrecognized #pragma directive

namespace Tekla.Technology.Akit.UserScript
{
    partial class MainFormVedChert : ApplicationFormBase
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.AListT = new System.Windows.Forms.ComboBox();
            this.AListTUDA = new System.Windows.Forms.ComboBox();
            this.AListGr = new System.Windows.Forms.GroupBox();
            this.ANaimT = new System.Windows.Forms.TextBox();
            this.ANaimB = new System.Windows.Forms.Button();
            this.ANaimG = new System.Windows.Forms.GroupBox();
            this.APrimMRC = new System.Windows.Forms.CheckBox();
            this.APrimUDAC = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Agr = new System.Windows.Forms.GroupBox();
            this.AEnableC = new System.Windows.Forms.CheckBox();
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.MEnableC = new System.Windows.Forms.CheckBox();
            this.Mgr = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MPrimMRC = new System.Windows.Forms.CheckBox();
            this.MPrimUDAC = new System.Windows.Forms.ComboBox();
            this.MNaimG = new System.Windows.Forms.GroupBox();
            this.MNaimB = new System.Windows.Forms.Button();
            this.MNaimT = new System.Windows.Forms.TextBox();
            this.MListGr = new System.Windows.Forms.GroupBox();
            this.MListTUDA = new System.Windows.Forms.ComboBox();
            this.MListT = new System.Windows.Forms.ComboBox();
            this.CEnableC = new System.Windows.Forms.CheckBox();
            this.Cgr = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CPrimMRC = new System.Windows.Forms.CheckBox();
            this.CPrimUDAC = new System.Windows.Forms.ComboBox();
            this.CNaimG = new System.Windows.Forms.GroupBox();
            this.CNaimB = new System.Windows.Forms.Button();
            this.CNaimT = new System.Windows.Forms.TextBox();
            this.CListGr = new System.Windows.Forms.GroupBox();
            this.CListTUDA = new System.Windows.Forms.ComboBox();
            this.CListT = new System.Windows.Forms.ComboBox();
            this.GEnableC = new System.Windows.Forms.CheckBox();
            this.Ggr = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.GPrimMRC = new System.Windows.Forms.CheckBox();
            this.GPrimUDAC = new System.Windows.Forms.ComboBox();
            this.GNaimG = new System.Windows.Forms.GroupBox();
            this.GNaimB = new System.Windows.Forms.Button();
            this.GNaimT = new System.Windows.Forms.TextBox();
            this.GListGr = new System.Windows.Forms.GroupBox();
            this.GListTUDA = new System.Windows.Forms.ComboBox();
            this.GListT = new System.Windows.Forms.ComboBox();
            this.DrawOnSheetB = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.MakeDrawingsB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChFormatCB = new System.Windows.Forms.ComboBox();
            this.DrHightT = new System.Windows.Forms.TextBox();
            this.ChOrient = new System.Windows.Forms.Button();
            this.DrWidthT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBorberColorB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBorberColor = new System.Windows.Forms.ComboBox();
            this.ASortIndCmb = new System.Windows.Forms.ComboBox();
            this.MSortIndCmb = new System.Windows.Forms.ComboBox();
            this.GSortIndCmb = new System.Windows.Forms.ComboBox();
            this.CSortIndCmb = new System.Windows.Forms.ComboBox();
            this.AListGr.SuspendLayout();
            this.ANaimG.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Agr.SuspendLayout();
            this.Mgr.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.MNaimG.SuspendLayout();
            this.MListGr.SuspendLayout();
            this.Cgr.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.CNaimG.SuspendLayout();
            this.CListGr.SuspendLayout();
            this.Ggr.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.GNaimG.SuspendLayout();
            this.GListGr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AListT
            // 
            this.structuresExtender.SetAttributeName(this.AListT, "AList");
            this.structuresExtender.SetAttributeTypeName(this.AListT, "String");
            this.structuresExtender.SetBindPropertyName(this.AListT, "Text");
            this.AListT.FormattingEnabled = true;
            this.AListT.Items.AddRange(new object[] {
            "Имя",
            "Метка",
            "Заголовок 1",
            "Заголовок 2",
            "Заголовок 3",
            "UDA"});
            this.AListT.Location = new System.Drawing.Point(5, 14);
            this.AListT.Name = "AListT";
            this.AListT.Size = new System.Drawing.Size(103, 21);
            this.AListT.TabIndex = 26;
            this.AListT.Text = "Имя";
            this.AListT.SelectedIndexChanged += new System.EventHandler(this.ListT_SelectedIndexChanged);
            // 
            // AListTUDA
            // 
            this.structuresExtender.SetAttributeName(this.AListTUDA, "AListUDA");
            this.structuresExtender.SetAttributeTypeName(this.AListTUDA, "String");
            this.structuresExtender.SetBindPropertyName(this.AListTUDA, "Text");
            this.AListTUDA.Enabled = false;
            this.AListTUDA.FormattingEnabled = true;
            this.AListTUDA.Location = new System.Drawing.Point(114, 14);
            this.AListTUDA.Name = "AListTUDA";
            this.AListTUDA.Size = new System.Drawing.Size(159, 21);
            this.AListTUDA.TabIndex = 27;
            // 
            // AListGr
            // 
            this.structuresExtender.SetAttributeName(this.AListGr, null);
            this.structuresExtender.SetAttributeTypeName(this.AListGr, null);
            this.structuresExtender.SetBindPropertyName(this.AListGr, null);
            this.AListGr.Controls.Add(this.AListTUDA);
            this.AListGr.Controls.Add(this.AListT);
            this.AListGr.Location = new System.Drawing.Point(49, 15);
            this.AListGr.Name = "AListGr";
            this.AListGr.Size = new System.Drawing.Size(281, 39);
            this.AListGr.TabIndex = 28;
            this.AListGr.TabStop = false;
            this.AListGr.Text = "Лист";
            // 
            // ANaimT
            // 
            this.structuresExtender.SetAttributeName(this.ANaimT, "ANaim");
            this.structuresExtender.SetAttributeTypeName(this.ANaimT, "String");
            this.structuresExtender.SetBindPropertyName(this.ANaimT, "Text");
            this.ANaimT.Location = new System.Drawing.Point(7, 14);
            this.ANaimT.Name = "ANaimT";
            this.ANaimT.Size = new System.Drawing.Size(308, 20);
            this.ANaimT.TabIndex = 29;
            // 
            // ANaimB
            // 
            this.structuresExtender.SetAttributeName(this.ANaimB, null);
            this.structuresExtender.SetAttributeTypeName(this.ANaimB, null);
            this.structuresExtender.SetBindPropertyName(this.ANaimB, null);
            this.ANaimB.Location = new System.Drawing.Point(321, 14);
            this.ANaimB.Name = "ANaimB";
            this.ANaimB.Size = new System.Drawing.Size(27, 19);
            this.ANaimB.TabIndex = 30;
            this.ANaimB.Text = "..";
            this.ANaimB.UseVisualStyleBackColor = true;
            this.ANaimB.Click += new System.EventHandler(this.NaimB_Click);
            // 
            // ANaimG
            // 
            this.structuresExtender.SetAttributeName(this.ANaimG, null);
            this.structuresExtender.SetAttributeTypeName(this.ANaimG, null);
            this.structuresExtender.SetBindPropertyName(this.ANaimG, null);
            this.ANaimG.Controls.Add(this.ANaimB);
            this.ANaimG.Controls.Add(this.ANaimT);
            this.ANaimG.Location = new System.Drawing.Point(336, 15);
            this.ANaimG.Name = "ANaimG";
            this.ANaimG.Size = new System.Drawing.Size(355, 39);
            this.ANaimG.TabIndex = 31;
            this.ANaimG.TabStop = false;
            this.ANaimG.Text = "Наименование";
            // 
            // APrimMRC
            // 
            this.structuresExtender.SetAttributeName(this.APrimMRC, "APrimMR");
            this.structuresExtender.SetAttributeTypeName(this.APrimMRC, "Boolean");
            this.APrimMRC.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.APrimMRC, "Checked");
            this.APrimMRC.Location = new System.Drawing.Point(10, 17);
            this.APrimMRC.Margin = new System.Windows.Forms.Padding(2);
            this.APrimMRC.Name = "APrimMRC";
            this.APrimMRC.Size = new System.Drawing.Size(109, 17);
            this.APrimMRC.TabIndex = 33;
            this.APrimMRC.Text = "Метка редакции";
            this.APrimMRC.UseVisualStyleBackColor = true;
            // 
            // APrimUDAC
            // 
            this.structuresExtender.SetAttributeName(this.APrimUDAC, "APrimUDA");
            this.structuresExtender.SetAttributeTypeName(this.APrimUDAC, "String");
            this.structuresExtender.SetBindPropertyName(this.APrimUDAC, "Text");
            this.APrimUDAC.FormattingEnabled = true;
            this.APrimUDAC.Location = new System.Drawing.Point(123, 13);
            this.APrimUDAC.Margin = new System.Windows.Forms.Padding(2);
            this.APrimUDAC.Name = "APrimUDAC";
            this.APrimUDAC.Size = new System.Drawing.Size(162, 21);
            this.APrimUDAC.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.structuresExtender.SetAttributeName(this.groupBox3, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox3, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox3, null);
            this.groupBox3.Controls.Add(this.APrimMRC);
            this.groupBox3.Controls.Add(this.APrimUDAC);
            this.groupBox3.Location = new System.Drawing.Point(697, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 39);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Примечание";
            // 
            // Agr
            // 
            this.structuresExtender.SetAttributeName(this.Agr, null);
            this.structuresExtender.SetAttributeTypeName(this.Agr, null);
            this.structuresExtender.SetBindPropertyName(this.Agr, null);
            this.Agr.Controls.Add(this.ASortIndCmb);
            this.Agr.Controls.Add(this.groupBox3);
            this.Agr.Controls.Add(this.ANaimG);
            this.Agr.Controls.Add(this.AListGr);
            this.Agr.Enabled = false;
            this.Agr.Location = new System.Drawing.Point(30, 48);
            this.Agr.Name = "Agr";
            this.Agr.Size = new System.Drawing.Size(991, 57);
            this.Agr.TabIndex = 36;
            this.Agr.TabStop = false;
            this.Agr.Text = "Чертежи сборки (A)";
            // 
            // AEnableC
            // 
            this.structuresExtender.SetAttributeName(this.AEnableC, "AEnable");
            this.structuresExtender.SetAttributeTypeName(this.AEnableC, "Boolean");
            this.AEnableC.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.AEnableC, "Checked");
            this.AEnableC.Location = new System.Drawing.Point(11, 80);
            this.AEnableC.Name = "AEnableC";
            this.AEnableC.Size = new System.Drawing.Size(15, 14);
            this.AEnableC.TabIndex = 37;
            this.AEnableC.UseVisualStyleBackColor = true;
            this.AEnableC.CheckedChanged += new System.EventHandler(this.EnableC_CheckedChanged);
            // 
            // saveLoad1
            // 
            this.structuresExtender.SetAttributeName(this.saveLoad1, null);
            this.structuresExtender.SetAttributeTypeName(this.saveLoad1, null);
            this.saveLoad1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.saveLoad1, null);
            this.saveLoad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad1.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad1.HelpKeyword = "";
            this.saveLoad1.HelpUrl = "";
            this.saveLoad1.Location = new System.Drawing.Point(0, 0);
            this.saveLoad1.Name = "saveLoad1";
            this.saveLoad1.SaveAsText = "";
            this.saveLoad1.Size = new System.Drawing.Size(1031, 43);
            this.saveLoad1.TabIndex = 38;
            this.saveLoad1.UserDefinedHelpFilePath = null;
            // 
            // MEnableC
            // 
            this.structuresExtender.SetAttributeName(this.MEnableC, "MEnable");
            this.structuresExtender.SetAttributeTypeName(this.MEnableC, "Boolean");
            this.MEnableC.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.MEnableC, "Checked");
            this.MEnableC.Location = new System.Drawing.Point(11, 147);
            this.MEnableC.Name = "MEnableC";
            this.MEnableC.Size = new System.Drawing.Size(15, 14);
            this.MEnableC.TabIndex = 40;
            this.MEnableC.UseVisualStyleBackColor = true;
            this.MEnableC.CheckedChanged += new System.EventHandler(this.EnableC_CheckedChanged);
            // 
            // Mgr
            // 
            this.structuresExtender.SetAttributeName(this.Mgr, null);
            this.structuresExtender.SetAttributeTypeName(this.Mgr, null);
            this.structuresExtender.SetBindPropertyName(this.Mgr, null);
            this.Mgr.Controls.Add(this.MSortIndCmb);
            this.Mgr.Controls.Add(this.groupBox4);
            this.Mgr.Controls.Add(this.MNaimG);
            this.Mgr.Controls.Add(this.MListGr);
            this.Mgr.Enabled = false;
            this.Mgr.Location = new System.Drawing.Point(30, 112);
            this.Mgr.Name = "Mgr";
            this.Mgr.Size = new System.Drawing.Size(991, 57);
            this.Mgr.TabIndex = 39;
            this.Mgr.TabStop = false;
            this.Mgr.Text = "Несколько чертежей (M)";
            // 
            // groupBox4
            // 
            this.structuresExtender.SetAttributeName(this.groupBox4, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox4, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox4, null);
            this.groupBox4.Controls.Add(this.MPrimMRC);
            this.groupBox4.Controls.Add(this.MPrimUDAC);
            this.groupBox4.Location = new System.Drawing.Point(697, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 39);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Примечание";
            // 
            // MPrimMRC
            // 
            this.structuresExtender.SetAttributeName(this.MPrimMRC, "MPrimMR");
            this.structuresExtender.SetAttributeTypeName(this.MPrimMRC, "Boolean");
            this.MPrimMRC.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.MPrimMRC, "Checked");
            this.MPrimMRC.Location = new System.Drawing.Point(10, 17);
            this.MPrimMRC.Margin = new System.Windows.Forms.Padding(2);
            this.MPrimMRC.Name = "MPrimMRC";
            this.MPrimMRC.Size = new System.Drawing.Size(109, 17);
            this.MPrimMRC.TabIndex = 33;
            this.MPrimMRC.Text = "Метка редакции";
            this.MPrimMRC.UseVisualStyleBackColor = true;
            // 
            // MPrimUDAC
            // 
            this.structuresExtender.SetAttributeName(this.MPrimUDAC, "MPrimUDA");
            this.structuresExtender.SetAttributeTypeName(this.MPrimUDAC, "String");
            this.structuresExtender.SetBindPropertyName(this.MPrimUDAC, "Text");
            this.MPrimUDAC.FormattingEnabled = true;
            this.MPrimUDAC.Location = new System.Drawing.Point(123, 13);
            this.MPrimUDAC.Margin = new System.Windows.Forms.Padding(2);
            this.MPrimUDAC.Name = "MPrimUDAC";
            this.MPrimUDAC.Size = new System.Drawing.Size(162, 21);
            this.MPrimUDAC.TabIndex = 32;
            // 
            // MNaimG
            // 
            this.structuresExtender.SetAttributeName(this.MNaimG, null);
            this.structuresExtender.SetAttributeTypeName(this.MNaimG, null);
            this.structuresExtender.SetBindPropertyName(this.MNaimG, null);
            this.MNaimG.Controls.Add(this.MNaimB);
            this.MNaimG.Controls.Add(this.MNaimT);
            this.MNaimG.Location = new System.Drawing.Point(336, 15);
            this.MNaimG.Name = "MNaimG";
            this.MNaimG.Size = new System.Drawing.Size(355, 39);
            this.MNaimG.TabIndex = 31;
            this.MNaimG.TabStop = false;
            this.MNaimG.Text = "Наименование";
            // 
            // MNaimB
            // 
            this.structuresExtender.SetAttributeName(this.MNaimB, null);
            this.structuresExtender.SetAttributeTypeName(this.MNaimB, null);
            this.structuresExtender.SetBindPropertyName(this.MNaimB, null);
            this.MNaimB.Location = new System.Drawing.Point(321, 14);
            this.MNaimB.Name = "MNaimB";
            this.MNaimB.Size = new System.Drawing.Size(27, 19);
            this.MNaimB.TabIndex = 30;
            this.MNaimB.Text = "..";
            this.MNaimB.UseVisualStyleBackColor = true;
            this.MNaimB.Click += new System.EventHandler(this.NaimB_Click);
            // 
            // MNaimT
            // 
            this.structuresExtender.SetAttributeName(this.MNaimT, "MNaim");
            this.structuresExtender.SetAttributeTypeName(this.MNaimT, "String");
            this.structuresExtender.SetBindPropertyName(this.MNaimT, "Text");
            this.MNaimT.Location = new System.Drawing.Point(7, 14);
            this.MNaimT.Name = "MNaimT";
            this.MNaimT.Size = new System.Drawing.Size(308, 20);
            this.MNaimT.TabIndex = 29;
            // 
            // MListGr
            // 
            this.structuresExtender.SetAttributeName(this.MListGr, null);
            this.structuresExtender.SetAttributeTypeName(this.MListGr, null);
            this.structuresExtender.SetBindPropertyName(this.MListGr, null);
            this.MListGr.Controls.Add(this.MListTUDA);
            this.MListGr.Controls.Add(this.MListT);
            this.MListGr.Location = new System.Drawing.Point(49, 15);
            this.MListGr.Name = "MListGr";
            this.MListGr.Size = new System.Drawing.Size(281, 39);
            this.MListGr.TabIndex = 28;
            this.MListGr.TabStop = false;
            this.MListGr.Text = "Лист";
            // 
            // MListTUDA
            // 
            this.structuresExtender.SetAttributeName(this.MListTUDA, "MListUDA");
            this.structuresExtender.SetAttributeTypeName(this.MListTUDA, "String");
            this.structuresExtender.SetBindPropertyName(this.MListTUDA, "Text");
            this.MListTUDA.Enabled = false;
            this.MListTUDA.FormattingEnabled = true;
            this.MListTUDA.Location = new System.Drawing.Point(114, 14);
            this.MListTUDA.Name = "MListTUDA";
            this.MListTUDA.Size = new System.Drawing.Size(159, 21);
            this.MListTUDA.TabIndex = 27;
            // 
            // MListT
            // 
            this.structuresExtender.SetAttributeName(this.MListT, "MList");
            this.structuresExtender.SetAttributeTypeName(this.MListT, "String");
            this.structuresExtender.SetBindPropertyName(this.MListT, "Text");
            this.MListT.FormattingEnabled = true;
            this.MListT.Items.AddRange(new object[] {
            "Имя",
            "Имя или метка",
            "Метка",
            "Заголовок 1",
            "Заголовок 2",
            "Заголовок 3",
            "UDA"});
            this.MListT.Location = new System.Drawing.Point(5, 14);
            this.MListT.Name = "MListT";
            this.MListT.Size = new System.Drawing.Size(103, 21);
            this.MListT.TabIndex = 26;
            this.MListT.Text = "Имя";
            this.MListT.SelectedIndexChanged += new System.EventHandler(this.ListT_SelectedIndexChanged);
            // 
            // CEnableC
            // 
            this.structuresExtender.SetAttributeName(this.CEnableC, "CEnable");
            this.structuresExtender.SetAttributeTypeName(this.CEnableC, "Boolean");
            this.CEnableC.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.CEnableC, "Checked");
            this.CEnableC.Location = new System.Drawing.Point(9, 273);
            this.CEnableC.Name = "CEnableC";
            this.CEnableC.Size = new System.Drawing.Size(15, 14);
            this.CEnableC.TabIndex = 42;
            this.CEnableC.UseVisualStyleBackColor = true;
            this.CEnableC.CheckedChanged += new System.EventHandler(this.EnableC_CheckedChanged);
            // 
            // Cgr
            // 
            this.structuresExtender.SetAttributeName(this.Cgr, null);
            this.structuresExtender.SetAttributeTypeName(this.Cgr, null);
            this.structuresExtender.SetBindPropertyName(this.Cgr, null);
            this.Cgr.Controls.Add(this.CSortIndCmb);
            this.Cgr.Controls.Add(this.groupBox6);
            this.Cgr.Controls.Add(this.CNaimG);
            this.Cgr.Controls.Add(this.CListGr);
            this.Cgr.Enabled = false;
            this.Cgr.Location = new System.Drawing.Point(30, 240);
            this.Cgr.Name = "Cgr";
            this.Cgr.Size = new System.Drawing.Size(991, 57);
            this.Cgr.TabIndex = 41;
            this.Cgr.TabStop = false;
            this.Cgr.Text = "Чертежи отлитых элементов (C)";
            // 
            // groupBox6
            // 
            this.structuresExtender.SetAttributeName(this.groupBox6, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox6, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox6, null);
            this.groupBox6.Controls.Add(this.CPrimMRC);
            this.groupBox6.Controls.Add(this.CPrimUDAC);
            this.groupBox6.Location = new System.Drawing.Point(697, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(292, 39);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Примечание";
            // 
            // CPrimMRC
            // 
            this.structuresExtender.SetAttributeName(this.CPrimMRC, "CPrimMR");
            this.structuresExtender.SetAttributeTypeName(this.CPrimMRC, "Boolean");
            this.CPrimMRC.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.CPrimMRC, "Checked");
            this.CPrimMRC.Location = new System.Drawing.Point(10, 17);
            this.CPrimMRC.Margin = new System.Windows.Forms.Padding(2);
            this.CPrimMRC.Name = "CPrimMRC";
            this.CPrimMRC.Size = new System.Drawing.Size(109, 17);
            this.CPrimMRC.TabIndex = 33;
            this.CPrimMRC.Text = "Метка редакции";
            this.CPrimMRC.UseVisualStyleBackColor = true;
            // 
            // CPrimUDAC
            // 
            this.structuresExtender.SetAttributeName(this.CPrimUDAC, "CPrimUDA");
            this.structuresExtender.SetAttributeTypeName(this.CPrimUDAC, "String");
            this.structuresExtender.SetBindPropertyName(this.CPrimUDAC, "Text");
            this.CPrimUDAC.FormattingEnabled = true;
            this.CPrimUDAC.Location = new System.Drawing.Point(123, 13);
            this.CPrimUDAC.Margin = new System.Windows.Forms.Padding(2);
            this.CPrimUDAC.Name = "CPrimUDAC";
            this.CPrimUDAC.Size = new System.Drawing.Size(162, 21);
            this.CPrimUDAC.TabIndex = 32;
            // 
            // CNaimG
            // 
            this.structuresExtender.SetAttributeName(this.CNaimG, null);
            this.structuresExtender.SetAttributeTypeName(this.CNaimG, null);
            this.structuresExtender.SetBindPropertyName(this.CNaimG, null);
            this.CNaimG.Controls.Add(this.CNaimB);
            this.CNaimG.Controls.Add(this.CNaimT);
            this.CNaimG.Location = new System.Drawing.Point(336, 15);
            this.CNaimG.Name = "CNaimG";
            this.CNaimG.Size = new System.Drawing.Size(355, 39);
            this.CNaimG.TabIndex = 31;
            this.CNaimG.TabStop = false;
            this.CNaimG.Text = "Наименование";
            // 
            // CNaimB
            // 
            this.structuresExtender.SetAttributeName(this.CNaimB, null);
            this.structuresExtender.SetAttributeTypeName(this.CNaimB, null);
            this.structuresExtender.SetBindPropertyName(this.CNaimB, null);
            this.CNaimB.Location = new System.Drawing.Point(321, 14);
            this.CNaimB.Name = "CNaimB";
            this.CNaimB.Size = new System.Drawing.Size(27, 19);
            this.CNaimB.TabIndex = 30;
            this.CNaimB.Text = "..";
            this.CNaimB.UseVisualStyleBackColor = true;
            this.CNaimB.Click += new System.EventHandler(this.NaimB_Click);
            // 
            // CNaimT
            // 
            this.structuresExtender.SetAttributeName(this.CNaimT, "CNaim");
            this.structuresExtender.SetAttributeTypeName(this.CNaimT, "String");
            this.structuresExtender.SetBindPropertyName(this.CNaimT, "Text");
            this.CNaimT.Location = new System.Drawing.Point(7, 14);
            this.CNaimT.Name = "CNaimT";
            this.CNaimT.Size = new System.Drawing.Size(308, 20);
            this.CNaimT.TabIndex = 29;
            // 
            // CListGr
            // 
            this.structuresExtender.SetAttributeName(this.CListGr, null);
            this.structuresExtender.SetAttributeTypeName(this.CListGr, null);
            this.structuresExtender.SetBindPropertyName(this.CListGr, null);
            this.CListGr.Controls.Add(this.CListTUDA);
            this.CListGr.Controls.Add(this.CListT);
            this.CListGr.Location = new System.Drawing.Point(49, 15);
            this.CListGr.Name = "CListGr";
            this.CListGr.Size = new System.Drawing.Size(281, 39);
            this.CListGr.TabIndex = 28;
            this.CListGr.TabStop = false;
            this.CListGr.Text = "Лист";
            // 
            // CListTUDA
            // 
            this.structuresExtender.SetAttributeName(this.CListTUDA, "CListUDA");
            this.structuresExtender.SetAttributeTypeName(this.CListTUDA, "String");
            this.structuresExtender.SetBindPropertyName(this.CListTUDA, "Text");
            this.CListTUDA.Enabled = false;
            this.CListTUDA.FormattingEnabled = true;
            this.CListTUDA.Location = new System.Drawing.Point(114, 14);
            this.CListTUDA.Name = "CListTUDA";
            this.CListTUDA.Size = new System.Drawing.Size(159, 21);
            this.CListTUDA.TabIndex = 27;
            // 
            // CListT
            // 
            this.structuresExtender.SetAttributeName(this.CListT, "CList");
            this.structuresExtender.SetAttributeTypeName(this.CListT, "String");
            this.structuresExtender.SetBindPropertyName(this.CListT, "Text");
            this.CListT.FormattingEnabled = true;
            this.CListT.Items.AddRange(new object[] {
            "Имя",
            "Метка",
            "Заголовок 1",
            "Заголовок 2",
            "Заголовок 3",
            "UDA"});
            this.CListT.Location = new System.Drawing.Point(5, 14);
            this.CListT.Name = "CListT";
            this.CListT.Size = new System.Drawing.Size(103, 21);
            this.CListT.TabIndex = 26;
            this.CListT.Text = "Имя";
            this.CListT.SelectedIndexChanged += new System.EventHandler(this.ListT_SelectedIndexChanged);
            // 
            // GEnableC
            // 
            this.structuresExtender.SetAttributeName(this.GEnableC, "GEnable");
            this.structuresExtender.SetAttributeTypeName(this.GEnableC, "Boolean");
            this.GEnableC.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.GEnableC, "Checked");
            this.GEnableC.Location = new System.Drawing.Point(9, 213);
            this.GEnableC.Name = "GEnableC";
            this.GEnableC.Size = new System.Drawing.Size(15, 14);
            this.GEnableC.TabIndex = 44;
            this.GEnableC.UseVisualStyleBackColor = true;
            this.GEnableC.CheckedChanged += new System.EventHandler(this.EnableC_CheckedChanged);
            // 
            // Ggr
            // 
            this.structuresExtender.SetAttributeName(this.Ggr, null);
            this.structuresExtender.SetAttributeTypeName(this.Ggr, null);
            this.structuresExtender.SetBindPropertyName(this.Ggr, null);
            this.Ggr.Controls.Add(this.GSortIndCmb);
            this.Ggr.Controls.Add(this.groupBox8);
            this.Ggr.Controls.Add(this.GNaimG);
            this.Ggr.Controls.Add(this.GListGr);
            this.Ggr.Enabled = false;
            this.Ggr.Location = new System.Drawing.Point(30, 176);
            this.Ggr.Name = "Ggr";
            this.Ggr.Size = new System.Drawing.Size(991, 57);
            this.Ggr.TabIndex = 43;
            this.Ggr.TabStop = false;
            this.Ggr.Text = "Чертежи общего вида (G)";
            // 
            // groupBox8
            // 
            this.structuresExtender.SetAttributeName(this.groupBox8, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox8, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox8, null);
            this.groupBox8.Controls.Add(this.GPrimMRC);
            this.groupBox8.Controls.Add(this.GPrimUDAC);
            this.groupBox8.Location = new System.Drawing.Point(696, 15);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(292, 39);
            this.groupBox8.TabIndex = 34;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Примечание";
            // 
            // GPrimMRC
            // 
            this.structuresExtender.SetAttributeName(this.GPrimMRC, "GPrimMR");
            this.structuresExtender.SetAttributeTypeName(this.GPrimMRC, "Boolean");
            this.GPrimMRC.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.GPrimMRC, "Checked");
            this.GPrimMRC.Location = new System.Drawing.Point(10, 17);
            this.GPrimMRC.Margin = new System.Windows.Forms.Padding(2);
            this.GPrimMRC.Name = "GPrimMRC";
            this.GPrimMRC.Size = new System.Drawing.Size(109, 17);
            this.GPrimMRC.TabIndex = 33;
            this.GPrimMRC.Text = "Метка редакции";
            this.GPrimMRC.UseVisualStyleBackColor = true;
            // 
            // GPrimUDAC
            // 
            this.structuresExtender.SetAttributeName(this.GPrimUDAC, "GPrimUDA");
            this.structuresExtender.SetAttributeTypeName(this.GPrimUDAC, "String");
            this.structuresExtender.SetBindPropertyName(this.GPrimUDAC, "Text");
            this.GPrimUDAC.FormattingEnabled = true;
            this.GPrimUDAC.Location = new System.Drawing.Point(123, 13);
            this.GPrimUDAC.Margin = new System.Windows.Forms.Padding(2);
            this.GPrimUDAC.Name = "GPrimUDAC";
            this.GPrimUDAC.Size = new System.Drawing.Size(162, 21);
            this.GPrimUDAC.TabIndex = 32;
            // 
            // GNaimG
            // 
            this.structuresExtender.SetAttributeName(this.GNaimG, null);
            this.structuresExtender.SetAttributeTypeName(this.GNaimG, null);
            this.structuresExtender.SetBindPropertyName(this.GNaimG, null);
            this.GNaimG.Controls.Add(this.GNaimB);
            this.GNaimG.Controls.Add(this.GNaimT);
            this.GNaimG.Location = new System.Drawing.Point(335, 15);
            this.GNaimG.Name = "GNaimG";
            this.GNaimG.Size = new System.Drawing.Size(355, 39);
            this.GNaimG.TabIndex = 31;
            this.GNaimG.TabStop = false;
            this.GNaimG.Text = "Наименование";
            // 
            // GNaimB
            // 
            this.structuresExtender.SetAttributeName(this.GNaimB, null);
            this.structuresExtender.SetAttributeTypeName(this.GNaimB, null);
            this.structuresExtender.SetBindPropertyName(this.GNaimB, null);
            this.GNaimB.Location = new System.Drawing.Point(321, 14);
            this.GNaimB.Name = "GNaimB";
            this.GNaimB.Size = new System.Drawing.Size(27, 19);
            this.GNaimB.TabIndex = 30;
            this.GNaimB.Text = "..";
            this.GNaimB.UseVisualStyleBackColor = true;
            this.GNaimB.Click += new System.EventHandler(this.NaimB_Click);
            // 
            // GNaimT
            // 
            this.structuresExtender.SetAttributeName(this.GNaimT, "GNaim");
            this.structuresExtender.SetAttributeTypeName(this.GNaimT, "String");
            this.structuresExtender.SetBindPropertyName(this.GNaimT, "Text");
            this.GNaimT.Location = new System.Drawing.Point(7, 14);
            this.GNaimT.Name = "GNaimT";
            this.GNaimT.Size = new System.Drawing.Size(308, 20);
            this.GNaimT.TabIndex = 29;
            // 
            // GListGr
            // 
            this.structuresExtender.SetAttributeName(this.GListGr, null);
            this.structuresExtender.SetAttributeTypeName(this.GListGr, null);
            this.structuresExtender.SetBindPropertyName(this.GListGr, null);
            this.GListGr.Controls.Add(this.GListTUDA);
            this.GListGr.Controls.Add(this.GListT);
            this.GListGr.Location = new System.Drawing.Point(48, 15);
            this.GListGr.Name = "GListGr";
            this.GListGr.Size = new System.Drawing.Size(281, 39);
            this.GListGr.TabIndex = 28;
            this.GListGr.TabStop = false;
            this.GListGr.Text = "Лист";
            // 
            // GListTUDA
            // 
            this.structuresExtender.SetAttributeName(this.GListTUDA, "GListUDA");
            this.structuresExtender.SetAttributeTypeName(this.GListTUDA, "String");
            this.structuresExtender.SetBindPropertyName(this.GListTUDA, "Text");
            this.GListTUDA.Enabled = false;
            this.GListTUDA.FormattingEnabled = true;
            this.GListTUDA.Location = new System.Drawing.Point(114, 14);
            this.GListTUDA.Name = "GListTUDA";
            this.GListTUDA.Size = new System.Drawing.Size(159, 21);
            this.GListTUDA.TabIndex = 27;
            // 
            // GListT
            // 
            this.structuresExtender.SetAttributeName(this.GListT, "GList");
            this.structuresExtender.SetAttributeTypeName(this.GListT, "String");
            this.structuresExtender.SetBindPropertyName(this.GListT, "Text");
            this.GListT.FormattingEnabled = true;
            this.GListT.Items.AddRange(new object[] {
            "Имя",
            "Метка",
            "Заголовок 1",
            "Заголовок 2",
            "Заголовок 3",
            "UDA"});
            this.GListT.Location = new System.Drawing.Point(5, 14);
            this.GListT.Name = "GListT";
            this.GListT.Size = new System.Drawing.Size(103, 21);
            this.GListT.TabIndex = 26;
            this.GListT.Text = "Имя";
            this.GListT.SelectedIndexChanged += new System.EventHandler(this.ListT_SelectedIndexChanged);
            // 
            // DrawOnSheetB
            // 
            this.structuresExtender.SetAttributeName(this.DrawOnSheetB, null);
            this.structuresExtender.SetAttributeTypeName(this.DrawOnSheetB, null);
            this.structuresExtender.SetBindPropertyName(this.DrawOnSheetB, null);
            this.DrawOnSheetB.Location = new System.Drawing.Point(798, 305);
            this.DrawOnSheetB.Name = "DrawOnSheetB";
            this.DrawOnSheetB.Size = new System.Drawing.Size(193, 93);
            this.DrawOnSheetB.TabIndex = 45;
            this.DrawOnSheetB.Text = "Нарисовать ведомость на открытом чертеже";
            this.DrawOnSheetB.UseVisualStyleBackColor = true;
            this.DrawOnSheetB.Click += new System.EventHandler(this.DrawOnChert_Click);
            // 
            // progressBar1
            // 
            this.structuresExtender.SetAttributeName(this.progressBar1, null);
            this.structuresExtender.SetAttributeTypeName(this.progressBar1, null);
            this.structuresExtender.SetBindPropertyName(this.progressBar1, null);
            this.progressBar1.Location = new System.Drawing.Point(291, 375);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(493, 23);
            this.progressBar1.TabIndex = 46;
            // 
            // MakeDrawingsB
            // 
            this.structuresExtender.SetAttributeName(this.MakeDrawingsB, null);
            this.structuresExtender.SetAttributeTypeName(this.MakeDrawingsB, null);
            this.structuresExtender.SetBindPropertyName(this.MakeDrawingsB, null);
            this.MakeDrawingsB.Location = new System.Drawing.Point(1, 45);
            this.MakeDrawingsB.Name = "MakeDrawingsB";
            this.MakeDrawingsB.Size = new System.Drawing.Size(264, 45);
            this.MakeDrawingsB.TabIndex = 47;
            this.MakeDrawingsB.Text = "Создать чертежи";
            this.MakeDrawingsB.UseVisualStyleBackColor = true;
            this.MakeDrawingsB.Click += new System.EventHandler(this.MakeDrawings_Click);
            // 
            // groupBox1
            // 
            this.structuresExtender.SetAttributeName(this.groupBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox1, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox1, null);
            this.groupBox1.Controls.Add(this.ChFormatCB);
            this.groupBox1.Controls.Add(this.DrHightT);
            this.groupBox1.Controls.Add(this.ChOrient);
            this.groupBox1.Controls.Add(this.DrWidthT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MakeDrawingsB);
            this.groupBox1.Location = new System.Drawing.Point(11, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 98);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создавать чертежи";
            // 
            // ChFormatCB
            // 
            this.structuresExtender.SetAttributeName(this.ChFormatCB, null);
            this.structuresExtender.SetAttributeTypeName(this.ChFormatCB, null);
            this.structuresExtender.SetBindPropertyName(this.ChFormatCB, null);
            this.ChFormatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChFormatCB.FormattingEnabled = true;
            this.ChFormatCB.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4"});
            this.ChFormatCB.Location = new System.Drawing.Point(206, 18);
            this.ChFormatCB.Name = "ChFormatCB";
            this.ChFormatCB.Size = new System.Drawing.Size(59, 21);
            this.ChFormatCB.TabIndex = 52;
            this.ChFormatCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DrHightT
            // 
            this.structuresExtender.SetAttributeName(this.DrHightT, "DrHight");
            this.structuresExtender.SetAttributeTypeName(this.DrHightT, "Integer");
            this.structuresExtender.SetBindPropertyName(this.DrHightT, "Text");
            this.DrHightT.Location = new System.Drawing.Point(146, 18);
            this.DrHightT.Name = "DrHightT";
            this.DrHightT.Size = new System.Drawing.Size(54, 20);
            this.DrHightT.TabIndex = 51;
            // 
            // ChOrient
            // 
            this.structuresExtender.SetAttributeName(this.ChOrient, null);
            this.structuresExtender.SetAttributeTypeName(this.ChOrient, null);
            this.structuresExtender.SetBindPropertyName(this.ChOrient, null);
            this.ChOrient.Location = new System.Drawing.Point(119, 18);
            this.ChOrient.Name = "ChOrient";
            this.ChOrient.Size = new System.Drawing.Size(21, 20);
            this.ChOrient.TabIndex = 50;
            this.ChOrient.Text = "X";
            this.ChOrient.UseVisualStyleBackColor = true;
            this.ChOrient.Click += new System.EventHandler(this.ChOrient_Click);
            // 
            // DrWidthT
            // 
            this.structuresExtender.SetAttributeName(this.DrWidthT, "DrWidth");
            this.structuresExtender.SetAttributeTypeName(this.DrWidthT, "Integer");
            this.structuresExtender.SetBindPropertyName(this.DrWidthT, "Text");
            this.DrWidthT.Location = new System.Drawing.Point(59, 18);
            this.DrWidthT.Name = "DrWidthT";
            this.DrWidthT.Size = new System.Drawing.Size(54, 20);
            this.DrWidthT.TabIndex = 49;
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Размер";
            // 
            // label4
            // 
            this.structuresExtender.SetAttributeName(this.label4, null);
            this.structuresExtender.SetAttributeTypeName(this.label4, null);
            this.label4.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label4, null);
            this.label4.Location = new System.Drawing.Point(288, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Цвет основных линий";
            // 
            // cmbBorberColorB
            // 
            this.structuresExtender.SetAttributeName(this.cmbBorberColorB, "BorberColorB");
            this.structuresExtender.SetAttributeTypeName(this.cmbBorberColorB, "Integer");
            this.structuresExtender.SetBindPropertyName(this.cmbBorberColorB, "Text");
            this.cmbBorberColorB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBorberColorB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorberColorB.FormattingEnabled = true;
            this.cmbBorberColorB.Location = new System.Drawing.Point(408, 331);
            this.cmbBorberColorB.MaxDropDownItems = 14;
            this.cmbBorberColorB.Name = "cmbBorberColorB";
            this.cmbBorberColorB.Size = new System.Drawing.Size(374, 21);
            this.cmbBorberColorB.TabIndex = 51;
            this.cmbBorberColorB.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbTextColor_DrawItem);
            this.cmbBorberColorB.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cmbTextColor_MeasureItem);
            this.cmbBorberColorB.SelectedIndexChanged += new System.EventHandler(this.cmbBorberColorB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.structuresExtender.SetAttributeName(this.label3, null);
            this.structuresExtender.SetAttributeTypeName(this.label3, null);
            this.label3.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label3, null);
            this.label3.Location = new System.Drawing.Point(303, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Цвет тонких линий";
            // 
            // cmbBorberColor
            // 
            this.structuresExtender.SetAttributeName(this.cmbBorberColor, "BorberColor");
            this.structuresExtender.SetAttributeTypeName(this.cmbBorberColor, "Integer");
            this.structuresExtender.SetBindPropertyName(this.cmbBorberColor, "Text");
            this.cmbBorberColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBorberColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorberColor.FormattingEnabled = true;
            this.cmbBorberColor.Location = new System.Drawing.Point(408, 304);
            this.cmbBorberColor.MaxDropDownItems = 14;
            this.cmbBorberColor.Name = "cmbBorberColor";
            this.cmbBorberColor.Size = new System.Drawing.Size(374, 21);
            this.cmbBorberColor.TabIndex = 49;
            this.cmbBorberColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbTextColor_DrawItem);
            this.cmbBorberColor.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cmbTextColor_MeasureItem);
            this.cmbBorberColor.SelectedIndexChanged += new System.EventHandler(this.chbBorberColor_SelectedIndexChanged);
            // 
            // ASortIndCmb
            // 
            this.structuresExtender.SetAttributeName(this.ASortIndCmb, "SortIndA");
            this.structuresExtender.SetAttributeTypeName(this.ASortIndCmb, "Integer");
            this.structuresExtender.SetBindPropertyName(this.ASortIndCmb, "Text");
            this.ASortIndCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ASortIndCmb.FormattingEnabled = true;
            this.ASortIndCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ASortIndCmb.Location = new System.Drawing.Point(9, 29);
            this.ASortIndCmb.Name = "ASortIndCmb";
            this.ASortIndCmb.Size = new System.Drawing.Size(35, 21);
            this.ASortIndCmb.TabIndex = 35;
            // 
            // MSortIndCmb
            // 
            this.structuresExtender.SetAttributeName(this.MSortIndCmb, "SortIndM");
            this.structuresExtender.SetAttributeTypeName(this.MSortIndCmb, "Integer");
            this.structuresExtender.SetBindPropertyName(this.MSortIndCmb, "Text");
            this.MSortIndCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MSortIndCmb.FormattingEnabled = true;
            this.MSortIndCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.MSortIndCmb.Location = new System.Drawing.Point(9, 27);
            this.MSortIndCmb.Name = "MSortIndCmb";
            this.MSortIndCmb.Size = new System.Drawing.Size(35, 21);
            this.MSortIndCmb.TabIndex = 36;
            // 
            // GSortIndCmb
            // 
            this.structuresExtender.SetAttributeName(this.GSortIndCmb, "SortIndG");
            this.structuresExtender.SetAttributeTypeName(this.GSortIndCmb, "Integer");
            this.structuresExtender.SetBindPropertyName(this.GSortIndCmb, "Text");
            this.GSortIndCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GSortIndCmb.FormattingEnabled = true;
            this.GSortIndCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.GSortIndCmb.Location = new System.Drawing.Point(9, 27);
            this.GSortIndCmb.Name = "GSortIndCmb";
            this.GSortIndCmb.Size = new System.Drawing.Size(35, 21);
            this.GSortIndCmb.TabIndex = 36;
            // 
            // CSortIndCmb
            // 
            this.structuresExtender.SetAttributeName(this.CSortIndCmb, "SortIndC");
            this.structuresExtender.SetAttributeTypeName(this.CSortIndCmb, "Integer");
            this.structuresExtender.SetBindPropertyName(this.CSortIndCmb, "Text");
            this.CSortIndCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CSortIndCmb.FormattingEnabled = true;
            this.CSortIndCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CSortIndCmb.Location = new System.Drawing.Point(9, 27);
            this.CSortIndCmb.Name = "CSortIndCmb";
            this.CSortIndCmb.Size = new System.Drawing.Size(35, 21);
            this.CSortIndCmb.TabIndex = 36;
            // 
            // MainForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(1031, 408);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBorberColorB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBorberColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DrawOnSheetB);
            this.Controls.Add(this.GEnableC);
            this.Controls.Add(this.CEnableC);
            this.Controls.Add(this.Ggr);
            this.Controls.Add(this.Cgr);
            this.Controls.Add(this.MEnableC);
            this.Controls.Add(this.Mgr);
            this.Controls.Add(this.saveLoad1);
            this.Controls.Add(this.AEnableC);
            this.Controls.Add(this.Agr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowInTaskbar = true;
            this.Text = "Ведомость чертежей";
            this.TopMost = true;
            this.AListGr.ResumeLayout(false);
            this.ANaimG.ResumeLayout(false);
            this.ANaimG.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Agr.ResumeLayout(false);
            this.Mgr.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.MNaimG.ResumeLayout(false);
            this.MNaimG.PerformLayout();
            this.MListGr.ResumeLayout(false);
            this.Cgr.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.CNaimG.ResumeLayout(false);
            this.CNaimG.PerformLayout();
            this.CListGr.ResumeLayout(false);
            this.Ggr.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.GNaimG.ResumeLayout(false);
            this.GNaimG.PerformLayout();
            this.GListGr.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.ComboBox AListT;
        private System.Windows.Forms.ComboBox AListTUDA;
        private System.Windows.Forms.GroupBox AListGr;
        private System.Windows.Forms.TextBox ANaimT;
        private System.Windows.Forms.Button ANaimB;
        private System.Windows.Forms.GroupBox ANaimG;
        private System.Windows.Forms.CheckBox APrimMRC;
        private System.Windows.Forms.ComboBox APrimUDAC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox Agr;
        private System.Windows.Forms.CheckBox AEnableC;
        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
        private System.Windows.Forms.CheckBox MEnableC;
        private System.Windows.Forms.GroupBox Mgr;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox MPrimMRC;
        private System.Windows.Forms.ComboBox MPrimUDAC;
        private System.Windows.Forms.GroupBox MNaimG;
        private System.Windows.Forms.Button MNaimB;
        private System.Windows.Forms.TextBox MNaimT;
        private System.Windows.Forms.GroupBox MListGr;
        private System.Windows.Forms.ComboBox MListTUDA;
        private System.Windows.Forms.ComboBox MListT;
        private System.Windows.Forms.CheckBox CEnableC;
        private System.Windows.Forms.GroupBox Cgr;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox CPrimMRC;
        private System.Windows.Forms.ComboBox CPrimUDAC;
        private System.Windows.Forms.GroupBox CNaimG;
        private System.Windows.Forms.Button CNaimB;
        private System.Windows.Forms.TextBox CNaimT;
        private System.Windows.Forms.GroupBox CListGr;
        private System.Windows.Forms.ComboBox CListTUDA;
        private System.Windows.Forms.ComboBox CListT;
        private System.Windows.Forms.CheckBox GEnableC;
        private System.Windows.Forms.GroupBox Ggr;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox GPrimMRC;
        private System.Windows.Forms.ComboBox GPrimUDAC;
        private System.Windows.Forms.GroupBox GNaimG;
        private System.Windows.Forms.Button GNaimB;
        private System.Windows.Forms.TextBox GNaimT;
        private System.Windows.Forms.GroupBox GListGr;
        private System.Windows.Forms.ComboBox GListTUDA;
        private System.Windows.Forms.ComboBox GListT;
        private System.Windows.Forms.Button DrawOnSheetB;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button MakeDrawingsB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ChFormatCB;
        private System.Windows.Forms.TextBox DrHightT;
        private System.Windows.Forms.Button ChOrient;
        private System.Windows.Forms.TextBox DrWidthT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBorberColorB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBorberColor;
        private System.Windows.Forms.ComboBox ASortIndCmb;
        private System.Windows.Forms.ComboBox MSortIndCmb;
        private System.Windows.Forms.ComboBox CSortIndCmb;
        private System.Windows.Forms.ComboBox GSortIndCmb;

        ArrayList drAttr = new ArrayList();

        public MainFormVedChert()
        {
            InitializeComponent();
            InitializeForm();

            CatalogHandler CH = new CatalogHandler();
            Localization TekLoc = new Localization();
            UserPropertyItemEnumerator UIE = CH.GetUserPropertyItems(CatalogObjectTypeEnum.ASSEMBLY_DRAWING);
            while (UIE.MoveNext()) { UserPropertyItem PI = UIE.Current; drAttr.Add(new UDAItem(PI.Name, (TekLoc.GetText(PI.GetLabel()) == "") ? PI.Name : TekLoc.GetText(PI.GetLabel()))); }
            drAttr.Sort(new StrNumComp());
            ArrayList drAttr1 = new ArrayList(); drAttr1.AddRange(drAttr);
            ArrayList drAttr2 = new ArrayList(); drAttr2.AddRange(drAttr);
            ArrayList drAttr3 = new ArrayList(); drAttr3.AddRange(drAttr);

            ArrayList drAttrU1 = new ArrayList(); drAttrU1.AddRange(drAttr);
            ArrayList drAttrU2 = new ArrayList(); drAttrU2.AddRange(drAttr);
            ArrayList drAttrU3 = new ArrayList(); drAttrU3.AddRange(drAttr);
            ArrayList drAttrU4 = new ArrayList(); drAttrU4.AddRange(drAttr);

            AListTUDA.DataSource = drAttr; AListTUDA.DisplayMember = "TitleO"; AListTUDA.ValueMember = "NameO";
            MListTUDA.DataSource = drAttr1; MListTUDA.DisplayMember = "TitleO"; MListTUDA.ValueMember = "NameO";
            GListTUDA.DataSource = drAttr2; GListTUDA.DisplayMember = "TitleO"; GListTUDA.ValueMember = "NameO";
            CListTUDA.DataSource = drAttr3; CListTUDA.DisplayMember = "TitleO"; CListTUDA.ValueMember = "NameO";

            APrimUDAC.DataSource = drAttrU1; APrimUDAC.DisplayMember = "TitleO"; APrimUDAC.ValueMember = "NameO";
            MPrimUDAC.DataSource = drAttrU2; MPrimUDAC.DisplayMember = "TitleO"; MPrimUDAC.ValueMember = "NameO";
            GPrimUDAC.DataSource = drAttrU3; GPrimUDAC.DisplayMember = "TitleO"; GPrimUDAC.ValueMember = "NameO";
            CPrimUDAC.DataSource = drAttrU4; CPrimUDAC.DisplayMember = "TitleO"; CPrimUDAC.ValueMember = "NameO";

            foreach (string color in DrColorName)
            {
                colors1.Add(color);
                colors2.Add(color);
            }
            cmbBorberColor.DataSource = colors1;
            cmbBorberColorB.DataSource = colors2;

            cmbBorberColor.Text = "Красный";
            cmbBorberColorB.Text = "Желтый";
            DrWidthT.Text = "594";
            SetAttributeValue(DrWidthT, DrWidthT.Text);
            DrHightT.Text = "420";
            SetAttributeValue(DrHightT, DrHightT.Text);
            SetAttributeValue(ASortIndCmb, 1);
            SetAttributeValue(MSortIndCmb, 2);
            SetAttributeValue(GSortIndCmb, 3);
            SetAttributeValue(CSortIndCmb, 4);
        }
        private void ListT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grMName = (sender as ComboBox).Name[0] + "Gr";
            string grName = (sender as ComboBox).Name[0] + "ListGr";
            string UdaName = (sender as ComboBox).Name + "UDA";

            (this.Controls[grMName].Controls[grName].Controls[UdaName] as ComboBox).Enabled = (sender as ComboBox).Text == "UDA";
        }
        private void EnableC_CheckedChanged(object sender, EventArgs e)
        {
            string grName = (sender as CheckBox).Name[0] + "Gr";
            (this.Controls[grName] as GroupBox).Enabled = (sender as CheckBox).Checked;
        }
        private void NaimB_Click(object sender, EventArgs e)
        {
            string grMName = (sender as Button).Name[0] + "Gr";
            string grName = (sender as Button).Name[0] + "NaimG";
            string NaimT = (sender as Button).Name[0] + "NaimT";
            string ParStr = (this.Controls[grMName].Controls[grName].Controls[NaimT] as TextBox).Text;
            NaimConstr NaimConstrForm = new NaimConstr(drAttr);
            NaimConstrForm.setSrt(ParStr);
            NaimConstrForm.ShowDialog(this);
            ParStr = NaimConstrForm.getStr();
            (this.Controls[grMName].Controls[grName].Controls[NaimT] as TextBox).Text = ParStr;
            SetAttributeValue((this.Controls[grMName].Controls[grName].Controls[NaimT] as TextBox), ParStr);
            NaimConstrForm.Dispose();
        }

        #region Вспомогательное
        private bool IsParam(string str)
        {
            if (str.ToLower().IndexOf("имя") != -1 | str.ToLower().IndexOf("метка") != -1 | str.ToLower().IndexOf("заголовок") != -1 | str.ToLower().IndexOf("номер") != -1)
            {
                return true;
            }
            return false;
        }
        private bool IsUDA(string str)
        {
            foreach (UDAItem ui in drAttr)
            {
                if (ui.NameO == str)
                { return true; }
            }
            return false;
        }
        private string GetSortString(string s)
        {
            string sOut = s;

            string Num = "";
            string Str = "";
            int addZ = 4;
            if (sOut.IndexOf(" - ") > -1)
            {
                addZ = 4 - (sOut.Length - sOut.IndexOf(" - ") - 3);
                sOut = sOut.Replace(" - ", "");
            }

            foreach (char Nm in sOut)
            {
                if (!Char.IsNumber(Nm))
                {
                    Str = Str + Nm;
                }
                else
                {
                    Num = Num + Nm;
                }
            }
            sOut = Str + Num.PadLeft(20 + (4 - addZ), '0') + "".PadRight(addZ, '0');
            return sOut;
        }
        private Identifier GetIdentifier(object Obj)
        {
            Type drType = Obj.GetType();
            PropertyInfo propertyInfo = drType.GetProperty("Identifier", BindingFlags.Instance | BindingFlags.NonPublic);
            object value = propertyInfo.GetValue(Obj, null);
            Identifier drIdentifier = (Identifier)value;
            return drIdentifier;
        }
        private String GetAttrFileName(object Obj)
        {
            Type drType = Obj.GetType();
            PropertyInfo propertyInfo = drType.GetProperty("AttributeFilename", BindingFlags.Instance | BindingFlags.NonPublic);
            object value = propertyInfo.GetValue(Obj, null);
            String AttrFileName = (String)value;
            return AttrFileName;
        }
        #endregion Вспомогательное

        private void GetDrData(bool MakeDrawing = false)
        {
            try
            {
                bool AOut = AEnableC.Checked;
                bool MOut = MEnableC.Checked;
                bool GOut = GEnableC.Checked;
                bool COut = CEnableC.Checked;

                string AList = AListT.Text;
                string MList = MListT.Text;
                string GList = GListT.Text;
                string CList = CListT.Text;

                string AListUDA = (string)AListTUDA.SelectedValue;
                string MListUDA = (string)MListTUDA.SelectedValue;
                string GListUDA = (string)GListTUDA.SelectedValue;
                string CListUDA = (string)CListTUDA.SelectedValue;

                DataTable DrTable = new DataTable();
                DrTable.Columns.Add("DrTyp", typeof(int));
                DrTable.Columns.Add("List", typeof(string));
                DrTable.Columns.Add("ListS", typeof(string));
                DrTable.Columns.Add("Naim", typeof(string));
                DrTable.Columns.Add("Prim", typeof(string));

                string List = "";
                string Naim = "";
                string Prim = "";


                string APrimUDA = (string)APrimUDAC.SelectedValue;
                if ((APrimUDA == null | APrimUDA == "Default") & APrimUDAC.Text != "") { APrimUDA = APrimUDAC.Text; }
                string MPrimUDA = (string)MPrimUDAC.SelectedValue;
                if ((MPrimUDA == null | MPrimUDA == "Default") & MPrimUDAC.Text != "") { MPrimUDA = APrimUDAC.Text; }
                string GPrimUDA = (string)GPrimUDAC.SelectedValue;
                if ((GPrimUDA == null | GPrimUDA == "Default") & GPrimUDAC.Text != "") { GPrimUDA = APrimUDAC.Text; }
                string CPrimUDA = (string)CPrimUDAC.SelectedValue;
                if ((CPrimUDA == null | CPrimUDA == "Default") & CPrimUDAC.Text != "") { CPrimUDA = APrimUDAC.Text; }

                bool APrimMR = APrimMRC.Checked;
                bool MPrimMR = MPrimMRC.Checked;
                bool GPrimMR = GPrimMRC.Checked;
                bool CPrimMR = CPrimMRC.Checked;

                ArrayList SortArr = new ArrayList();
                SortArr.Add(typeof(GADrawing).ToString());
                SortArr.Add(typeof(MultiDrawing).ToString());
                SortArr.Add(typeof(AssemblyDrawing).ToString());
                SortArr.Add(typeof(CastUnitDrawing).ToString());

                DrawingHandler dh = new DrawingHandler();
                DrawingEnumerator de = dh.GetDrawingSelector().GetSelected();
                if (de.GetSize() == 0)
                {
                    de = dh.GetDrawings();
                }

                de.SelectInstances = false;
                progressBar1.Value = 0;
                progressBar1.Maximum = de.GetSize();
                foreach (Drawing dr in de)
                {
                    ++progressBar1.Value;

                    if (!((dr is AssemblyDrawing & AOut) | (dr is MultiDrawing & MOut) | (dr is CastUnitDrawing & COut) | (dr is GADrawing & GOut)))
                    {
                        continue;
                    }

                    Naim = "";
                    List = "";
                    Prim = "";
                    Identifier drIdentifier = GetIdentifier(dr);
                    Beam DrObj = new Beam { Identifier = drIdentifier };

                    DataRow NewDr = DrTable.Rows.Add();

                    if ((dr is AssemblyDrawing & AList == "Имя") | (dr is MultiDrawing & MList == "Имя") | (dr is CastUnitDrawing & CList == "Имя") | (dr is GADrawing & GList == "Имя"))
                    {
                        List = dr.Name;
                    }
                    if ((dr is AssemblyDrawing & AList == "Метка") | (dr is MultiDrawing & MList == "Метка") | (dr is CastUnitDrawing & CList == "Метка") | (dr is GADrawing & GList == "Метка"))
                    {
                        List = dr.Mark;
                    }
                    if ((dr is MultiDrawing & MList == "Имя или метка"))
                    {
                        List = (dr.Name == "") ? dr.Mark : dr.Name;
                    }
                    if ((dr is AssemblyDrawing & AList == "Заголовок 1") | (dr is MultiDrawing & MList == "Заголовок 1") | (dr is CastUnitDrawing & CList == "Заголовок 1") | (dr is GADrawing & GList == "Заголовок 1"))
                    {
                        List = dr.Title1;
                    }
                    if ((dr is AssemblyDrawing & AList == "Заголовок 2") | (dr is MultiDrawing & MList == "Заголовок 2") | (dr is CastUnitDrawing & CList == "Заголовок 2") | (dr is GADrawing & GList == "Заголовок 2"))
                    {
                        List = dr.Title2;
                    }
                    if ((dr is AssemblyDrawing & AList == "Заголовок 3") | (dr is MultiDrawing & MList == "Заголовок 3") | (dr is CastUnitDrawing & CList == "Заголовок 3") | (dr is GADrawing & GList == "Заголовок 3"))
                    {
                        List = dr.Title3;
                    }
                    if ((dr is AssemblyDrawing & AList == "UDA") | (dr is MultiDrawing & MList == "UDA") | (dr is CastUnitDrawing & CList == "UDA") | (dr is GADrawing & GList == "UDA"))
                    {
                        string UdaName = (dr is AssemblyDrawing) ? AListUDA : (dr is MultiDrawing) ? MListUDA : (dr is CastUnitDrawing) ? CListUDA : (dr is GADrawing) ? GListUDA : "";
                        dr.GetUserProperty(UdaName, ref List);
                    }
                    string ParamStrT = (dr is AssemblyDrawing) ? ANaimT.Text : (dr is MultiDrawing) ? MNaimT.Text : (dr is CastUnitDrawing) ? CNaimT.Text : (dr is GADrawing) ? GNaimT.Text : "";
                    string[] arS = ParamStrT.Split(' ');
                    if (arS.Count() > 0)
                    {
                        foreach (string tstr in arS)
                        {
                            string parStr = tstr;
                            if (IsParam(tstr.ToLower()))
                            {
                                parStr = parStr.ToLower();
                                if (parStr == "имя_главной_детали") { parStr = "ASSEMBLY.MAINPART.NAME"; }
                                else if (parStr == "имя_сборки") { parStr = "ASSEMBLY.ASSEMBLY_NAME"; }
                                else if (parStr == "номер_позиции_сборки") { parStr = "ASSEMBLY.ASSEMBLY_POS"; }
                                else { parStr = parStr.Replace("_", "").Replace("имя", "TITLE").Replace("заголовок", "TITLE").Replace("метка", "NAME_BASE"); }
                            }
                            else
                            {
                                //parStr = parStr;
                                if (IsUDA(parStr))
                                {
                                    parStr = "USERDEFINED." + parStr;
                                }
                            }
                            string naimS = "";
                            DrObj.GetReportProperty(parStr, ref naimS);
                            Naim = Naim + ((Naim == "") ? "" : " ") + naimS;
                        }
                    }

                    string UdaPrimName = (dr is AssemblyDrawing) ? APrimUDA : (dr is MultiDrawing) ? MPrimUDA :
                        (dr is CastUnitDrawing) ? CPrimUDA : (dr is GADrawing) ? GPrimUDA : "";

                    if (UdaPrimName != null)
                        DrObj.GetUserProperty(UdaPrimName, ref Prim);
                    if (((dr is AssemblyDrawing & APrimMR) | (dr is MultiDrawing & MPrimMR) | (dr is CastUnitDrawing & CPrimMR) | (dr is GADrawing & GPrimMR)))
                    {
                        string PrimMR = "";
                        DrObj.GetReportProperty("REVISION.LAST_MARK", ref PrimMR);
                        int PrimMRT = 0;
                        DrObj.GetReportProperty("REVISION.NUMBER", ref PrimMRT);
                        if (PrimMR != "")
                        { Prim = Prim + ((Prim == "") ? "" : " ") + "Изм. " + ((PrimMRT == 0) ? "" : PrimMRT.ToString()) + "(" + PrimMR + ")"; }
                    }
                    NewDr["DrTyp"] = ASortIndCmb.Items.IndexOf((dr is AssemblyDrawing) ? ASortIndCmb.Text : (dr is MultiDrawing) ? MSortIndCmb.Text : (dr is CastUnitDrawing) ? CSortIndCmb.Text : (dr is GADrawing) ? GSortIndCmb.Text : "1");
                    NewDr["List"] = List.Replace("[", "").Replace("]", "");
                    NewDr["ListS"] = GetSortString(List.Replace("[", "").Replace("]", ""));
                    NewDr["Naim"] = Naim.Replace("[", "").Replace("]", "");
                    NewDr["Prim"] = Prim.Replace("[", "").Replace("]", "");
                }
                DataView dv = new DataView(DrTable);
                dv.Sort = "DrTyp,ListS";
                DataTable SortTable = dv.ToTable();
                DrawSpis(SortTable, MakeDrawing);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        #region Рисуем
        private void DrawSpis(DataTable dt, bool MakeDrawing = false)
        {
            ViewBase pickedView;
            double StartX;
            double StartY;
            Drawing TekDraw;
            DrawingHandler dh = new DrawingHandler();
            int DrWidth = 594;
            int.TryParse(DrWidthT.Text, out DrWidth);
            int DrHight = 420;
            int.TryParse(DrHightT.Text, out DrHight);
            string drAttrName = "standard";

            if (!MakeDrawing)
            {

                TekDraw = dh.GetActiveDrawing();
                if (TekDraw == null)
                {
                    MessageBox.Show(this, "Не открыт чертеж!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Tekla.Structures.Drawing.UI.Picker myPicker = dh.GetPicker();
                Tekla.Structures.Geometry3d.Point pickedPoint = new Tekla.Structures.Geometry3d.Point(20, TekDraw.GetSheet().Height - 5);

                try
                {
                    myPicker.PickPoint("Укажите точку верхнего левого угла вставляемой таблицы, отмена - выбор левого верхнего угла", out pickedPoint, out pickedView);
                    StartX = pickedPoint.X;
                    StartY = pickedPoint.Y;
                }
                catch (PickerInterruptedException)
                {

                    pickedView = TekDraw.GetSheet();
                    StartX = 20;
                    StartY = pickedView.Height - 5;
                }
            }
            else
            {
                Tekla.Structures.Drawing.Size DrSize = new Tekla.Structures.Drawing.Size(DrWidth, DrHight);
                TekDraw = new GADrawing(drAttrName, DrSize);
                TekDraw.Name = "Ведомость чертежей";
                TekDraw.Insert();
                pickedView = TekDraw.GetSheet();
                StartX = 20;
                StartY = pickedView.Height - 5;
                dh.SetActiveDrawing(TekDraw, false);
            }

            double StartXS = StartX;
            double StartYS = StartY;

            Tekla.Structures.Drawing.Text myText;
            Text.TextAttributes MyTextAttributes = new Text.TextAttributes();
            MyTextAttributes.Alignment = TextAlignment.Center;
            MyTextAttributes.Font = new FontAttributes(DrawingColors.Green, 3.5, "GOST type A", true, false);
            Text.TextAttributes MyTextAttributesL = new Text.TextAttributes();
            MyTextAttributesL.Alignment = TextAlignment.Left;
            MyTextAttributesL.PreferredPlacing = PreferredTextPlacingTypes.PointPlacingType();
            MyTextAttributesL.Font = new FontAttributes(DrawingColors.Green, 3.5, "GOST type A Italic", false, false);
            Text.TextAttributes MyTextAttributesT = new Text.TextAttributes();
            MyTextAttributesT.Alignment = TextAlignment.Center;
            MyTextAttributesT.Font = new FontAttributes(DrawingColors.Green, 5, "GOST type A", true, false);

            Tekla.Structures.Drawing.Text myTextStart = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 92.5, StartY - 7.5), "Ведомость рабочих чертежей основного комплекта", new PointPlacing(), MyTextAttributesT);
            myTextStart.Insert();

            StartY = StartY - 15;
            DrLine(StartX, StartY, StartX + 185, StartY, pickedView);
            DrLine(StartX, StartY - 15, StartX + 185, StartY - 15, pickedView);
            DrLine(StartX, StartY, StartX, StartY - 15, pickedView);
            DrLine(StartX + 185, StartY, StartX + 185, StartY - 15, pickedView);
            DrLine(StartX + 15, StartY, StartX + 15, StartY - 15, pickedView);
            DrLine(StartX + 155, StartY, StartX + 155, StartY - 15, pickedView);

            myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 7.5, StartY - 7.5), "Лист", new PointPlacing(), MyTextAttributes);
            myText.Insert();
            myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 86, StartY - 7.5), "Наименование", new PointPlacing(), MyTextAttributes);
            myText.Attributes.Font.Italic = true;
            myText.Insert();
            myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 170, StartY - 7.5), "Примечание", new PointPlacing(), MyTextAttributes);
            myText.Insert();

            StartY = StartY - 15;
            DrLine(StartX, StartY - 8, StartX + 185, StartY - 8, pickedView);
            DrLine(StartX, StartY, StartX, StartY - 8, pickedView);
            DrLine(StartX + 185, StartY, StartX + 185, StartY - 8, pickedView);
            DrLine(StartX + 15, StartY, StartX + 15, StartY - 8, pickedView);
            DrLine(StartX + 155, StartY, StartX + 155, StartY - 8, pickedView);

            myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 7.5, StartY - 4), "1", new PointPlacing(), MyTextAttributes);
            myText.Insert();
            myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 86, StartY - 4), "2", new PointPlacing(), MyTextAttributes);
            myText.Attributes.Font.Italic = true;
            myText.Insert();
            myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 170, StartY - 4), "3", new PointPlacing(), MyTextAttributes);
            myText.Insert();

            StartY = StartY - 8;

            Tekla.Structures.Drawing.Text myTextL;
            const int MaxLen = 76;
            int dob = 0;
            int maxHg = 0;
            int maxHgs = 0;
            int drCount = 0;
            bool DontQ = false;
            progressBar1.Value = 0;
            progressBar1.Maximum = dt.Rows.Count;
            progressBar1.Value = progressBar1.Maximum;
            foreach (DataRow tekNod in dt.Rows)
            {
                if (tekNod["List"].ToString() == "" | tekNod["Naim"].ToString() == "")
                {
                    continue;
                }
                string Naim = tekNod["Naim"].ToString();
                int NumRow = (int)Math.Ceiling((double)Naim.Length / (MaxLen - 1));
                if (pickedView.Width - StartX < 380)
                {
                    dob = 120;
                }
                if (StartY - NumRow * 8 < 8 + dob)
                {
                    if (maxHg == 0)
                    {
                        myTextStart.TextString = "Ведомость рабочих чертежей основного комплекта (начало)";
                        myTextStart.Modify();
                    }
                    maxHg = Math.Max(maxHg, maxHgs);
                    maxHgs = 0;
                    StartY = StartYS;
                    StartX = StartX + 190;
                    if (StartX + 185 > pickedView.Width & !MakeDrawing & !DontQ)
                    {
                        System.Windows.Forms.DialogResult mr = MessageBox.Show(this, "Ведомость не входит на чертеж!!!\nСоздать новый чертеж?", "Ошибка", MessageBoxButtons.YesNoCancel);
                        if (mr == System.Windows.Forms.DialogResult.Yes)
                        {
                            drAttrName = GetAttrFileName(TekDraw);
                            DrWidth = (int)TekDraw.GetSheet().Width;
                            DrHight = (int)TekDraw.GetSheet().Height;
                            MakeDrawing = true;
                        }
                        if (mr == System.Windows.Forms.DialogResult.Cancel)
                        {
                            break;
                        }
                        DontQ = mr == System.Windows.Forms.DialogResult.No;
                    }

                    if (StartX + 185 > pickedView.Width & MakeDrawing)
                    {
                        if (drCount == 0)
                        {
                            TekDraw.Name = "Ведомость чертежей (начало)";
                        }
                        TekDraw.CommitChanges();
                        TekDraw.Modify();
                        dh.CloseActiveDrawing(true);
                        Tekla.Structures.Drawing.Size DrSize = new Tekla.Structures.Drawing.Size(DrWidth, DrHight);
                        TekDraw = new GADrawing(drAttrName, DrSize);
                        TekDraw.Name = "Ведомость чертежей (продолжение)";
                        TekDraw.Insert();
                        ++drCount;
                        dh.SetActiveDrawing(TekDraw, false);
                        pickedView = TekDraw.GetSheet();
                        StartX = 20;
                        StartY = pickedView.Height - 5;
                        dob = 0;
                    }
                    if (progressBar1.Value > maxHg)
                    {
                        myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 92.5, StartY - 7.5), "Ведомость рабочих чертежей основного комплекта (продолжение)", new PointPlacing(), MyTextAttributesT);
                    }
                    else
                    {
                        myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 92.5, StartY - 7.5), "Ведомость рабочих чертежей основного комплекта (окончание)", new PointPlacing(), MyTextAttributesT);
                    }
                    myText.Insert();
                    StartY = StartY - 15;
                    DrLine(StartX, StartY, StartX + 185, StartY, pickedView);
                    DrLine(StartX, StartY - 8, StartX + 185, StartY - 8, pickedView);
                    DrLine(StartX, StartY, StartX, StartY - 8, pickedView);
                    DrLine(StartX + 185, StartY, StartX + 185, StartY - 8, pickedView);
                    DrLine(StartX + 15, StartY, StartX + 15, StartY - 8, pickedView);
                    DrLine(StartX + 155, StartY, StartX + 155, StartY - 8, pickedView);

                    myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 7.5, StartY - 4), "1", new PointPlacing(), MyTextAttributes);
                    myText.Insert();
                    myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 86, StartY - 4), "2", new PointPlacing(), MyTextAttributes);
                    myText.Attributes.Font.Italic = true;
                    myText.Insert();
                    myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 170, StartY - 4), "3", new PointPlacing(), MyTextAttributes);
                    myText.Insert();

                    StartY = StartY - 8;
                    DrLine(StartX, StartY, StartX + 185, StartY, pickedView);
                }

                //DrLine(StartX      , StartY    , StartX + 185, StartY    , pickedView);
                DrLineR(StartX, StartY - 8, StartX + 185, StartY - 8, pickedView);
                DrLine(StartX, StartY, StartX, StartY - 8, pickedView);
                DrLine(StartX + 185, StartY, StartX + 185, StartY - 8, pickedView);
                DrLine(StartX + 15, StartY, StartX + 15, StartY - 8, pickedView);
                DrLine(StartX + 155, StartY, StartX + 155, StartY - 8, pickedView);

                myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 7.5, StartY - 4), tekNod["List"].ToString(), new PointPlacing(), MyTextAttributes);
                myText.Insert();

                if (tekNod["Prim"].ToString() != "")
                {
                    myText = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 170, StartY - 4), tekNod["Prim"].ToString(), new PointPlacing(), MyTextAttributes);
                    myText.Insert();
                    /*RectangleBoundingBox W = myText.GetObjectAlignedBoundingBox();
                    myText.InsertionPoint.X = myText.InsertionPoint.X + W.Width * 0.5;
                    myText.Modify();*/
                }

                if (tekNod["Naim"].ToString() != "")
                {
                    string Opis = tekNod["Naim"].ToString();
                    if (Opis.Length < MaxLen)
                    {
                        myTextL = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 16, StartY - 4), Opis, MyTextAttributesL);
                        myTextL.Insert();
                        RectangleBoundingBox W = myTextL.GetObjectAlignedBoundingBox();
                        myTextL.InsertionPoint.X = myTextL.InsertionPoint.X + W.Width * 0.5;
                        myTextL.Modify();
                        StartY = StartY - 8;
                    }
                    else
                    {
                        String OpisS = "";
                        bool First = true;

                        while (Opis.Length > 0)
                        {
                            while (Opis.Length > 0)
                            {
                                string w = Opis.Substring(0, Opis.IndexOf(" ") + 1);
                                if (w == "" & Opis.Length > 0)
                                {
                                    w = Opis;
                                    Opis = "";
                                }
                                Opis = Opis.Substring(Opis.IndexOf(" ") + 1);
                                if ((OpisS + w).Length < MaxLen & Opis.Length > 0)
                                {
                                    OpisS = OpisS + w;
                                }
                                else
                                {
                                    if ((OpisS + w).Length < MaxLen & Opis.Length == 0 & w.Length > 0)
                                    {
                                        OpisS = OpisS + w; w = "";
                                    }
                                    if (!First)
                                    {
                                        DrLineR(StartX, StartY - 8, StartX + 185, StartY - 8, pickedView);
                                        DrLine(StartX, StartY, StartX, StartY - 8, pickedView);
                                        DrLine(StartX + 185, StartY, StartX + 185, StartY - 8, pickedView);
                                        DrLine(StartX + 15, StartY, StartX + 15, StartY - 8, pickedView);
                                        DrLine(StartX + 155, StartY, StartX + 155, StartY - 8, pickedView);
                                    }
                                    myTextL = new Text(pickedView, new Tekla.Structures.Geometry3d.Point(StartX + 16, StartY - 4), OpisS, MyTextAttributesL);
                                    myTextL.Insert();
                                    RectangleBoundingBox W = myTextL.GetObjectAlignedBoundingBox();
                                    myTextL.InsertionPoint.X = myTextL.InsertionPoint.X + W.Width * 0.5;
                                    myTextL.Modify();
                                    StartY = StartY - 8;
                                    First = false;

                                    OpisS = w;
                                    if (Opis.Length == 0 & OpisS.Length > 0)
                                    {
                                        Opis = OpisS;
                                        OpisS = "";
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                --progressBar1.Value;
                ++maxHgs;
            }
            progressBar1.Value = 0;
            if (MakeDrawing & drCount > 0)
            {
                TekDraw.Name = "Ведомость чертежей (окончание)";
            }
            TekDraw.CommitChanges();
            TekDraw.Modify();
            if (MakeDrawing)
            {
                dh.CloseActiveDrawing(true);
            }
        }
        private void DrLine(double xs, double ys, double xe, double ye, ViewBase View)
        {
            Tekla.Structures.Drawing.Line MyLine;

            MyLine = new Tekla.Structures.Drawing.Line(View,
                    new Tekla.Structures.Geometry3d.Point(xs, ys), new Tekla.Structures.Geometry3d.Point(xe, ye), new Line.LineAttributes("standard"));
            MyLine.Attributes.Line.Color = BorberColorB;
            MyLine.Insert();
        }
        private void DrLineR(double xs, double ys, double xe, double ye, ViewBase View)
        {
            Tekla.Structures.Drawing.Line MyLine;

            MyLine = new Tekla.Structures.Drawing.Line(View,
                    new Tekla.Structures.Geometry3d.Point(xs, ys), new Tekla.Structures.Geometry3d.Point(xe, ye), new Line.LineAttributes("standard"));
            MyLine.Attributes.Line.Color = BorberColor;
            MyLine.Insert();
        }
        #endregion Рисуем
        private void DrawOnChert_Click(object sender, EventArgs e)
        {
            DrawingHandler dh = new DrawingHandler();
            Drawing TekDraw = dh.GetActiveDrawing();
            if (TekDraw == null)
            {
                MessageBox.Show(this, "Не открыт чертеж!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            GetDrData();
        }
        private void MakeDrawings_Click(object sender, EventArgs e)
        {
            DrawingHandler dh = new DrawingHandler();
            Drawing TekDraw = dh.GetActiveDrawing();
            if (TekDraw != null)
            {
                if (MessageBox.Show(this, "Открытый чертеж будет закрыт!!!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
            }
            GetDrData(true);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChFormatCB.Text == "A0")
            {
                DrWidthT.Text = "1189";
                SetAttributeValue(DrWidthT, DrWidthT.Text);
                DrHightT.Text = "841";
                SetAttributeValue(DrHightT, DrHightT.Text);
            }
            if (ChFormatCB.Text == "A1")
            {
                DrWidthT.Text = "841";
                SetAttributeValue(DrWidthT, DrWidthT.Text);
                DrHightT.Text = "594";
                SetAttributeValue(DrHightT, DrHightT.Text);
            }
            if (ChFormatCB.Text == "A2")
            {
                DrWidthT.Text = "594";
                SetAttributeValue(DrWidthT, DrWidthT.Text);
                DrHightT.Text = "420";
                SetAttributeValue(DrHightT, DrHightT.Text);
            }
            if (ChFormatCB.Text == "A3")
            {
                DrWidthT.Text = "420";
                SetAttributeValue(DrWidthT, DrWidthT.Text);
                DrHightT.Text = "297";
                SetAttributeValue(DrHightT, DrHightT.Text);
            }
            if (ChFormatCB.Text == "A4")
            {
                DrWidthT.Text = "297";
                SetAttributeValue(DrWidthT, DrWidthT.Text);
                DrHightT.Text = "210";
                SetAttributeValue(DrHightT, DrHightT.Text);
            }

        }
        private void ChOrient_Click(object sender, EventArgs e)
        {
            string h = DrHightT.Text;
            DrHightT.Text = DrWidthT.Text;
            SetAttributeValue(DrHightT, DrHightT.Text);
            DrWidthT.Text = h;
            SetAttributeValue(DrWidthT, DrWidthT.Text);
        }

        #region Выбор цвета
        ArrayList colors1 = new ArrayList();
        ArrayList colors2 = new ArrayList();

        private System.Drawing.Color[] DrColors = new System.Drawing.Color[]
        {
             System.Drawing.Color.LightGray,
             System.Drawing.Color.Black,
             System.Drawing.Color.Brown,
             System.Drawing.Color.Green,
             System.Drawing.Color.DarkBlue,
             System.Drawing.Color.ForestGreen,
             System.Drawing.Color.Orange,
             System.Drawing.Color.Gray,
             System.Drawing.Color.Red,
             System.Drawing.Color.LightGreen,
             System.Drawing.Color.Blue,
             System.Drawing.Color.Cyan,
             System.Drawing.Color.Yellow,
             System.Drawing.Color.Magenta
        };
        private int[] DRColorsNm = new int[] { 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165 };
        private string[] DrColorName = new string[] { "Невидимый", "Черный", "Коричневый", "Темно-зеленый", "Темно-синий", "Аквамариновый", "Оранжевый", "Серый", "Красный", "Зеленый", "Синий", "Голубой", "Желтый", "Пурпурный" };

        private DrawingColors BorberColor;
        private DrawingColors BorberColorB;
        private void cmbTextColor_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 15;
            e.ItemWidth = 260;
        }
        private void cmbTextColor_DrawItem(object sender, DrawItemEventArgs e)
        {

            System.Drawing.Color drColor = DrColors[e.Index];

            e.DrawBackground();

            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(2, e.Bounds.Top + 2, e.Bounds.Height, e.Bounds.Height - 4);
            e.Graphics.FillRectangle(new SolidBrush(drColor), rectangle);

            e.Graphics.DrawString(DrColorName[e.Index], cmbBorberColor.Font, System.Drawing.Brushes.Black, new RectangleF(e.Bounds.X + rectangle.Width, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));

            // Draw the focus rectangle if the mouse hovers over an item.
            e.DrawFocusRectangle();
        }
        private void chbBorberColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = DrColorName.ToList().FindIndex(item => item == (string)cmbBorberColor.SelectedItem);
            SetAttributeValue(cmbBorberColor, DRColorsNm[ind]);
            BorberColor = (DrawingColors)Enum.GetValues(typeof(DrawingColors)).GetValue(ind);
        }
        private void cmbBorberColorB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = DrColorName.ToList().FindIndex(item => item == (string)cmbBorberColorB.SelectedItem);
            SetAttributeValue(cmbBorberColorB, DRColorsNm[ind]);
            BorberColorB = (DrawingColors)Enum.GetValues(typeof(DrawingColors)).GetValue(ind);
        }
        #endregion Выбор цвета

    }

    partial class NaimConstr : Form
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Naim1UDA = new System.Windows.Forms.ComboBox();
            this.Naim1 = new System.Windows.Forms.ComboBox();
            this.Naim2UDA = new System.Windows.Forms.ComboBox();
            this.Naim2 = new System.Windows.Forms.ComboBox();
            this.Naim3UDA = new System.Windows.Forms.ComboBox();
            this.Naim3 = new System.Windows.Forms.ComboBox();
            this.Naim4UDA = new System.Windows.Forms.ComboBox();
            this.Naim4 = new System.Windows.Forms.ComboBox();
            this.Naim5UDA = new System.Windows.Forms.ComboBox();
            this.Naim5 = new System.Windows.Forms.ComboBox();
            this.ParamStrT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Naim1UDA
            // 
            this.Naim1UDA.Enabled = false;
            this.Naim1UDA.FormattingEnabled = true;
            this.Naim1UDA.Location = new System.Drawing.Point(7, 38);
            this.Naim1UDA.Name = "Naim1UDA";
            this.Naim1UDA.Size = new System.Drawing.Size(159, 21);
            this.Naim1UDA.TabIndex = 26;
            this.Naim1UDA.SelectedIndexChanged += new System.EventHandler(this.NaimUDA_SelectedIndexChanged);
            // 
            // Naim1
            // 
            this.Naim1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Naim1.FormattingEnabled = true;
            this.Naim1.Items.AddRange(new object[] {
            "Имя",
            "Метка",
            "Заголовок 1",
            "Заголовок 2",
            "Заголовок 3",
            "UDA",
            "Имя главной детали",
            "Имя сборки",
            "Номер позиции сборки"});
            this.Naim1.Location = new System.Drawing.Point(7, 12);
            this.Naim1.Name = "Naim1";
            this.Naim1.Size = new System.Drawing.Size(159, 21);
            this.Naim1.TabIndex = 25;
            this.Naim1.SelectedIndexChanged += new System.EventHandler(this.NaimT_SelectedIndexChanged);
            // 
            // Naim2UDA
            // 
            this.Naim2UDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Naim2UDA.Enabled = false;
            this.Naim2UDA.FormattingEnabled = true;
            this.Naim2UDA.Location = new System.Drawing.Point(172, 38);
            this.Naim2UDA.Name = "Naim2UDA";
            this.Naim2UDA.Size = new System.Drawing.Size(120, 21);
            this.Naim2UDA.TabIndex = 28;
            this.Naim2UDA.SelectedIndexChanged += new System.EventHandler(this.NaimUDA_SelectedIndexChanged);
            // 
            // Naim2
            // 
            this.Naim2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Naim2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Naim2.FormattingEnabled = true;
            this.Naim2.Items.AddRange(new object[] {
            "",
            "Имя",
            "Метка",
            "Заголовок 1",
            "Заголовок 2",
            "Заголовок 3",
            "UDA",
            "Имя главной детали",
            "Имя сборки",
            "Номер позиции сборки"});
            this.Naim2.Location = new System.Drawing.Point(172, 12);
            this.Naim2.Name = "Naim2";
            this.Naim2.Size = new System.Drawing.Size(120, 21);
            this.Naim2.TabIndex = 27;
            this.Naim2.SelectedIndexChanged += new System.EventHandler(this.NaimT_SelectedIndexChanged);
            // 
            // Naim3UDA
            // 
            this.Naim3UDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Naim3UDA.Enabled = false;
            this.Naim3UDA.FormattingEnabled = true;
            this.Naim3UDA.Location = new System.Drawing.Point(300, 38);
            this.Naim3UDA.Name = "Naim3UDA";
            this.Naim3UDA.Size = new System.Drawing.Size(121, 21);
            this.Naim3UDA.TabIndex = 30;
            this.Naim3UDA.SelectedIndexChanged += new System.EventHandler(this.NaimUDA_SelectedIndexChanged);
            // 
            // Naim3
            // 
            this.Naim3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Naim3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Naim3.FormattingEnabled = true;
            this.Naim3.Items.AddRange(new object[] {
            "",
            "Имя",
            "Метка",
            "Заголовок 1",
            "Заголовок 2",
            "Заголовок 3",
            "UDA",
            "Имя главной детали",
            "Имя сборки",
            "Номер позиции сборки"});
            this.Naim3.Location = new System.Drawing.Point(300, 12);
            this.Naim3.Name = "Naim3";
            this.Naim3.Size = new System.Drawing.Size(121, 21);
            this.Naim3.TabIndex = 29;
            this.Naim3.SelectedIndexChanged += new System.EventHandler(this.NaimT_SelectedIndexChanged);
            // 
            // Naim4UDA
            // 
            this.Naim4UDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Naim4UDA.Enabled = false;
            this.Naim4UDA.FormattingEnabled = true;
            this.Naim4UDA.Location = new System.Drawing.Point(429, 38);
            this.Naim4UDA.Name = "Naim4UDA";
            this.Naim4UDA.Size = new System.Drawing.Size(126, 21);
            this.Naim4UDA.TabIndex = 32;
            this.Naim4UDA.SelectedIndexChanged += new System.EventHandler(this.NaimUDA_SelectedIndexChanged);
            // 
            // Naim4
            // 
            this.Naim4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Naim4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Naim4.FormattingEnabled = true;
            this.Naim4.Items.AddRange(new object[] {
            "",
            "Имя",
            "Метка",
            "Заголовок 1",
            "Заголовок 2",
            "Заголовок 3",
            "UDA",
            "Имя главной детали",
            "Имя сборки",
            "Номер позиции сборки"});
            this.Naim4.Location = new System.Drawing.Point(429, 12);
            this.Naim4.Name = "Naim4";
            this.Naim4.Size = new System.Drawing.Size(126, 21);
            this.Naim4.TabIndex = 31;
            this.Naim4.SelectedIndexChanged += new System.EventHandler(this.NaimT_SelectedIndexChanged);
            // 
            // Naim5UDA
            // 
            this.Naim5UDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Naim5UDA.Enabled = false;
            this.Naim5UDA.FormattingEnabled = true;
            this.Naim5UDA.Location = new System.Drawing.Point(563, 38);
            this.Naim5UDA.Name = "Naim5UDA";
            this.Naim5UDA.Size = new System.Drawing.Size(143, 21);
            this.Naim5UDA.TabIndex = 34;
            this.Naim5UDA.SelectedIndexChanged += new System.EventHandler(this.NaimUDA_SelectedIndexChanged);
            // 
            // Naim5
            // 
            this.Naim5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Naim5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Naim5.FormattingEnabled = true;
            this.Naim5.Items.AddRange(new object[] {
            "",
            "Имя",
            "Метка",
            "Заголовок 1",
            "Заголовок 2",
            "Заголовок 3",
            "UDA",
            "Имя главной детали",
            "Имя сборки",
            "Номер позиции сборки"});
            this.Naim5.Location = new System.Drawing.Point(563, 12);
            this.Naim5.Name = "Naim5";
            this.Naim5.Size = new System.Drawing.Size(143, 21);
            this.Naim5.TabIndex = 33;
            this.Naim5.SelectedIndexChanged += new System.EventHandler(this.NaimT_SelectedIndexChanged);
            // 
            // ParamStrT
            // 
            this.ParamStrT.Location = new System.Drawing.Point(7, 76);
            this.ParamStrT.Name = "ParamStrT";
            this.ParamStrT.Size = new System.Drawing.Size(701, 20);
            this.ParamStrT.TabIndex = 35;
            this.ParamStrT.TextChanged += new System.EventHandler(this.ParamStrT_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 24);
            this.button1.TabIndex = 36;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NaimConstr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(716, 129);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ParamStrT);
            this.Controls.Add(this.Naim5UDA);
            this.Controls.Add(this.Naim5);
            this.Controls.Add(this.Naim4UDA);
            this.Controls.Add(this.Naim4);
            this.Controls.Add(this.Naim3UDA);
            this.Controls.Add(this.Naim3);
            this.Controls.Add(this.Naim2UDA);
            this.Controls.Add(this.Naim2);
            this.Controls.Add(this.Naim1UDA);
            this.Controls.Add(this.Naim1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NaimConstr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Конструктор наименования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.ComboBox Naim1UDA;
        private System.Windows.Forms.ComboBox Naim1;
        private System.Windows.Forms.ComboBox Naim2UDA;
        private System.Windows.Forms.ComboBox Naim2;
        private System.Windows.Forms.ComboBox Naim3UDA;
        private System.Windows.Forms.ComboBox Naim3;
        private System.Windows.Forms.ComboBox Naim4UDA;
        private System.Windows.Forms.ComboBox Naim4;
        private System.Windows.Forms.ComboBox Naim5UDA;
        private System.Windows.Forms.ComboBox Naim5;
        private System.Windows.Forms.TextBox ParamStrT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        public string ParamStr = "";
        public NaimConstr(ArrayList UDAArr)
        {
            InitializeComponent();
            ArrayList UDA1 = new ArrayList(); UDA1.AddRange(UDAArr);
            Naim1UDA.DataSource = UDA1; Naim1UDA.DisplayMember = "TitleO"; Naim1UDA.ValueMember = "NameO";
            ArrayList UDA2 = new ArrayList(); UDA2.AddRange(UDAArr);
            Naim2UDA.DataSource = UDA2; Naim2UDA.DisplayMember = "TitleO"; Naim2UDA.ValueMember = "NameO";
            ArrayList UDA3 = new ArrayList(); UDA3.AddRange(UDAArr);
            Naim3UDA.DataSource = UDA3; Naim3UDA.DisplayMember = "TitleO"; Naim3UDA.ValueMember = "NameO";
            ArrayList UDA4 = new ArrayList(); UDA4.AddRange(UDAArr);
            Naim4UDA.DataSource = UDA4; Naim4UDA.DisplayMember = "TitleO"; Naim4UDA.ValueMember = "NameO";
            ArrayList UDA5 = new ArrayList(); UDA5.AddRange(UDAArr);
            Naim5UDA.DataSource = UDA5; Naim5UDA.DisplayMember = "TitleO"; Naim5UDA.ValueMember = "NameO";
            if (ParamStr == "")
            {
                ParamStr = "Заголовок_1";
            }
            ParamStrT.Text = ParamStr;
            DecodeParamStr();
        }
        public void setSrt(string s)
        {
            if (s == "")
            {
                return;
            }
            ParamStr = s;
            ParamStrT.Text = ParamStr;
            DecodeParamStr();
        }
        public string getStr()
        {
            return ParamStrT.Text;
        }
        private void DecodeParamStr()
        {
            if (ParamStrT.Text == "")
            {
                return;
            }
            string[] arS = ParamStrT.Text.Split(' ');
            if (arS.Count() == 0)
            {
                return;
            }
            int i = 1;
            foreach (string tstr in arS)
            {
                ComboBox TControl = (this.Controls["Naim" + i.ToString()] as ComboBox);
                ComboBox TControlUDA = (this.Controls["Naim" + i.ToString() + "UDA"] as ComboBox);

                if (IsParam(tstr))
                {
                    if (tstr.IndexOf("Заголовок") != -1 & false)
                    {
                        TControl.Text = tstr.Insert(9, " ");
                    }
                    else
                    {
                        TControl.Text = tstr.Substring(0, 1).ToUpper() + tstr.Substring(1).Replace('_', ' ').ToLower();
                    }
                    ++i;
                }
                else
                {
                    UDAItem udaName = null;
                    foreach (UDAItem uda in (ArrayList)TControlUDA.DataSource)
                    {
                        if (uda.Name.ToLower() == tstr.ToLower())
                        {
                            udaName = uda;
                            break;
                        }

                    }
                    if (udaName != null)
                    {
                        TControlUDA.SelectedItem = udaName;
                        TControl.Text = "UDA";
                        ++i;
                    }

                }
            }
        }
        private bool IsParam(string str)
        {
            if (str.ToLower().IndexOf("имя") != -1 | str.ToLower().IndexOf("метка") != -1 | str.ToLower().IndexOf("заголовок") != -1 | str.ToLower().IndexOf("номер") != -1)
            {
                return true;
            }
            return false;
        }
        private void NaimT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bName = (sender as ComboBox).Name + "UDA";
            (this.Controls[bName] as ComboBox).Enabled = (sender as ComboBox).Text == "UDA";
            MakeParamStr();
        }

        private void MakeParamStr()
        {
            string ParamStr = "";
            for (int i = 1; i <= 5; ++i)
            {
                ComboBox TControl = (this.Controls["Naim" + i.ToString()] as ComboBox);
                ComboBox TControlUDA = (this.Controls["Naim" + i.ToString() + "UDA"] as ComboBox);
                if (TControl.Text != "")
                {
                    ParamStr = ParamStr + ((ParamStr == "") ? "" : " ") + ((TControl.Text == "UDA") ? TControlUDA.SelectedValue.ToString() : TControl.Text.Replace(" ", "_"));
                }
            }
            ParamStrT.Text = ParamStr;
        }

        private void NaimUDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeParamStr();
        }

        private void ParamStrT_TextChanged(object sender, EventArgs e)
        {
            DecodeParamStr();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Naim1.Text = "Заголовок_1";
            for (int i = 5; i > 1; --i)
            {
                (this.Controls["Naim" + i.ToString()] as ComboBox).Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class UDAItem
    {
        public string Name;
        public string Title;
        public string TitleO
        {
            get { return Title; }
        }
        public string NameO
        {
            get { return Name; }
        }
        public UDAItem(string name, string title)
        {
            Name = name; Title = title;
        }
    }
    public class StrNumComp : IComparer
    {
        int IComparer.Compare(System.Object x, System.Object y)
        {
            return (x as UDAItem).Title.CompareTo((y as UDAItem).Title);
        }
    }


    public class Script
    {
        public static void Run(Tekla.Technology.Akit.IScript akit)
        {
            Application.EnableVisualStyles();
            Application.Run(new MainFormVedChert());
        }
    }
}
