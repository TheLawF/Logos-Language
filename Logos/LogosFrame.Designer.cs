using System;
using System.Drawing;
using System.Windows.Forms;
using ICSharpCode.TextEditor;

namespace Logos
{
    partial class LogosFrame
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
            this.codeEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cssItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconToolStrip = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.returnButton = new System.Windows.Forms.ToolStripButton();
            this.newButton = new System.Windows.Forms.ToolStripSplitButton();
            this.新建项目CtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建空项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.undoButton = new System.Windows.Forms.ToolStripSplitButton();
            this.redoButton = new System.Windows.Forms.ToolStripButton();
            this.infoComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.runButton = new System.Windows.Forms.ToolStripButton();
            this.configButton = new System.Windows.Forms.ToolStripButton();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.menu.SuspendLayout();
            this.iconToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeEditor
            // 
            this.codeEditor.AutoScroll = true;
            this.codeEditor.IsReadOnly = false;
            this.codeEditor.Location = new System.Drawing.Point(0, 144);
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.Size = new System.Drawing.Size(3000, 1000);
            this.codeEditor.TabIndex = 0;
            this.codeEditor.Text = "textEditorControl1";
            this.codeEditor.Load += new System.EventHandler(this.OnWindowStateChange);
            this.codeEditor.Load += new EventHandler(this.codeEditor_TextChanged);
            this.codeEditor.Load += new EventHandler(this.codeEditor_Load);
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.debugMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(3000, 39);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.settingsMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(143, 38);
            this.fileMenuItem.Text = "文件（F）";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(373, 44);
            this.newMenuItem.Text = "新建（N）";
            this.newMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(373, 44);
            this.openMenuItem.Text = "打开（O）";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(373, 44);
            this.saveMenuItem.Text = "保存（S）";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click_1);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtItem,
            this.jsonItem,
            this.csItem,
            this.htmlItem,
            this.jsItem,
            this.cssItem,
            this.javaItem});
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(373, 44);
            this.saveAsMenuItem.Text = "另存为（Shift+S）";
            // 
            // txtItem
            // 
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(384, 44);
            this.txtItem.Text = "文本文件（.txt）";
            this.txtItem.Click += new System.EventHandler(this.txtItem_Click);
            // 
            // jsonItem
            // 
            this.jsonItem.Name = "jsonItem";
            this.jsonItem.Size = new System.Drawing.Size(384, 44);
            this.jsonItem.Text = "Json 文件（.json）";
            this.jsonItem.Click += new System.EventHandler(this.jsonItem_Click);
            // 
            // csItem
            // 
            this.csItem.Name = "csItem";
            this.csItem.Size = new System.Drawing.Size(384, 44);
            this.csItem.Text = "C# 脚本（.cs）";
            this.csItem.Click += new System.EventHandler(this.csItem_Click);
            // 
            // htmlItem
            // 
            this.htmlItem.Name = "htmlItem";
            this.htmlItem.Size = new System.Drawing.Size(384, 44);
            this.htmlItem.Text = "HTML文件（.html）";
            this.htmlItem.Click += new System.EventHandler(this.htmlItem_Click);
            // 
            // jsItem
            // 
            this.jsItem.Name = "jsItem";
            this.jsItem.Size = new System.Drawing.Size(384, 44);
            this.jsItem.Text = "Javascript 脚本（.js）";
            this.jsItem.Click += new System.EventHandler(this.jsItem_Click);
            // 
            // cssItem
            // 
            this.cssItem.Name = "cssItem";
            this.cssItem.Size = new System.Drawing.Size(384, 44);
            this.cssItem.Text = "CSS 样式表（.css）";
            this.cssItem.Click += new System.EventHandler(this.cssItem_Click);
            // 
            // javaItem
            // 
            this.javaItem.Name = "javaItem";
            this.javaItem.Size = new System.Drawing.Size(384, 44);
            this.javaItem.Text = "Java 类（.java）";
            this.javaItem.Click += new System.EventHandler(this.javaItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(373, 44);
            this.settingsMenuItem.Text = "设置（Ctrl+Alt+S)）";
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findMenuItem,
            this.replaceMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(143, 35);
            this.editMenuItem.Text = "编辑（E）";
            // 
            // findMenuItem
            // 
            this.findMenuItem.Name = "findMenuItem";
            this.findMenuItem.Size = new System.Drawing.Size(359, 44);
            this.findMenuItem.Text = "查找（Shift+F）";
            // 
            // replaceMenuItem
            // 
            this.replaceMenuItem.Name = "replaceMenuItem";
            this.replaceMenuItem.Size = new System.Drawing.Size(359, 44);
            this.replaceMenuItem.Text = "替换（Shift+R）";
            // 
            // debugMenuItem
            // 
            this.debugMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileMenuItem,
            this.runMenuItem});
            this.debugMenuItem.Name = "debugMenuItem";
            this.debugMenuItem.Size = new System.Drawing.Size(148, 38);
            this.debugMenuItem.Text = "调试（D）";
            // 
            // compileMenuItem
            // 
            this.compileMenuItem.Name = "compileMenuItem";
            this.compileMenuItem.Size = new System.Drawing.Size(329, 44);
            this.compileMenuItem.Text = "编译（Shift+R）";
            // 
            // runMenuItem
            // 
            this.runMenuItem.Name = "runMenuItem";
            this.runMenuItem.Size = new System.Drawing.Size(359, 44);
            this.runMenuItem.Text = "运行（Shift+C）";
            this.runMenuItem.Click += new System.EventHandler(this.runMenuItem_Click);
            // 
            // iconToolStrip
            // 
            this.iconToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.iconToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.returnButton,
            this.newButton,
            this.openButton,
            this.saveButton,
            this.undoButton,
            this.redoButton,
            this.infoComboBox,
            this.runButton,
            this.configButton,
            this.searchTextBox});
            this.iconToolStrip.Location = new System.Drawing.Point(0, 39);
            this.iconToolStrip.Name = "iconToolStrip";
            this.iconToolStrip.Size = new System.Drawing.Size(3000, 42);
            this.iconToolStrip.TabIndex = 2;
            this.iconToolStrip.Text = "toolStrip1";
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = global::Logos.Properties.Resources.arrow_back_outline;
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(46, 36);
            this.backButton.Text = "toolStripButton1";
            this.backButton.ToolTipText = "返回上一个";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.returnButton.Image = global::Logos.Properties.Resources.arrow_forward_outline;
            this.returnButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(46, 36);
            this.returnButton.Text = "toolStripButton1";
            this.returnButton.ToolTipText = "下一个";
            // 
            // newButton
            // 
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建项目CtrlNToolStripMenuItem,
            this.新建空项目ToolStripMenuItem});
            this.newButton.Image = global::Logos.Properties.Resources.file_add_outline;
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(59, 36);
            this.newButton.Text = "toolStripSplitButton1";
            this.newButton.ToolTipText = "新建...";
            // 
            // 新建项目CtrlNToolStripMenuItem
            // 
            this.新建项目CtrlNToolStripMenuItem.Name = "新建项目CtrlNToolStripMenuItem";
            this.新建项目CtrlNToolStripMenuItem.Size = new System.Drawing.Size(369, 44);
            this.新建项目CtrlNToolStripMenuItem.Text = "新建项目（Ctrl+N）";
            // 
            // 新建空项目ToolStripMenuItem
            // 
            this.新建空项目ToolStripMenuItem.Name = "新建空项目ToolStripMenuItem";
            this.新建空项目ToolStripMenuItem.Size = new System.Drawing.Size(369, 44);
            this.新建空项目ToolStripMenuItem.Text = "新建空项目";
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = global::Logos.Properties.Resources.book_open_outline;
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(46, 36);
            this.openButton.Text = "toolStripButton1";
            this.openButton.ToolTipText = "打开（O）";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::Logos.Properties.Resources.save_outline;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(46, 36);
            this.saveButton.Text = "toolStripButton1";
            this.saveButton.ToolTipText = "保存（S）";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoButton.Image = global::Logos.Properties.Resources.corner_up_left_outline;
            this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(59, 36);
            this.undoButton.Text = "toolStripSplitButton2";
            this.undoButton.ToolTipText = "撤回（Undo）";
            // 
            // redoButton
            // 
            this.redoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoButton.Image = global::Logos.Properties.Resources.corner_up_right_outline;
            this.redoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(46, 36);
            this.redoButton.Text = "toolStripButton1";
            this.redoButton.ToolTipText = "重复（Redo）";
            // 
            // infoComboBox
            // 
            this.infoComboBox.Items.AddRange(new object[] {
            "Debug",
            "Info",
            "Warn",
            "Error",
            "Fatal"});
            this.infoComboBox.Name = "infoComboBox";
            this.infoComboBox.Size = new System.Drawing.Size(121, 42);
            this.infoComboBox.Text = "Debug";
            this.infoComboBox.ToolTipText = "日志属性";
            // 
            // runButton
            // 
            this.runButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runButton.Image = global::Logos.Properties.Resources.arrow_right_outline;
            this.runButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(46, 36);
            this.runButton.Text = "toolStripButton1";
            this.runButton.ToolTipText = "运行（R）";
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // configButton
            // 
            this.configButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.configButton.Image = global::Logos.Properties.Resources.settings_2_outline;
            this.configButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(46, 36);
            this.configButton.Text = "toolStripButton1";
            this.configButton.ToolTipText = "设置（Settings）";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(160, 42);
            this.searchTextBox.ToolTipText = "搜索（Search）";
            // 
            // LogosFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3000, 1920);
            this.Controls.Add(this.iconToolStrip);
            this.Controls.Add(this.codeEditor);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "LogosFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnWindowStateChange);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.iconToolStrip.ResumeLayout(false);
            this.iconToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ICSharpCode.TextEditor.TextEditorControl codeEditor;

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem newMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem saveAsMenuItem;
        private ToolStripMenuItem txtItem;
        private ToolStripMenuItem jsonItem;
        private ToolStripMenuItem csItem;
        private ToolStripMenuItem htmlItem;
        private ToolStripMenuItem jsItem;
        private ToolStripMenuItem cssItem;
        private ToolStripMenuItem javaItem;
        private ToolStripMenuItem editMenuItem;
        private ToolStripMenuItem findMenuItem;
        private ToolStripMenuItem replaceMenuItem;
        private ToolStripMenuItem debugMenuItem;
        private ToolStripMenuItem compileMenuItem;
        private ToolStripMenuItem runMenuItem;
        private ToolStrip iconToolStrip;
        private ToolStripButton backButton;
        private ToolStripButton returnButton;
        private ToolStripSplitButton newButton;
        private ToolStripMenuItem 新建项目CtrlNToolStripMenuItem;
        private ToolStripMenuItem 新建空项目ToolStripMenuItem;
        private ToolStripButton openButton;
        private ToolStripButton saveButton;
        private ToolStripSplitButton undoButton;
        private ToolStripButton redoButton;
        private ToolStripComboBox infoComboBox;
        private ToolStripMenuItem settingsMenuItem;
        private ToolStripButton runButton;
        private ToolStripButton configButton;
        private ToolStripTextBox searchTextBox;
    }
}