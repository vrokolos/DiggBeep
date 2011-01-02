using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;
using System.Windows.Forms;
using Baileysoft.Rss.DiggAPI;
namespace diggBeep
{
    partial class Form1:Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Diggs = new diggBeep.TextAndImageColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new diggBeep.TextAndImageColumn();
            this.Story = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.linkLabel15 = new System.Windows.Forms.LinkLabel();
            this.linkLabel16 = new System.Windows.Forms.LinkLabel();
            this.linkLabel17 = new System.Windows.Forms.LinkLabel();
            this.linkLabel18 = new System.Windows.Forms.LinkLabel();
            this.linkLabel19 = new System.Windows.Forms.LinkLabel();
            this.playsndwrkr = new System.ComponentModel.BackgroundWorker();
            this.playsndcmntwrkr = new System.ComponentModel.BackgroundWorker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkUser = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textAndImageColumn1 = new diggBeep.TextAndImageColumn();
            this.textAndImageColumn2 = new diggBeep.TextAndImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "10x10-digg-thumb.gif");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(194)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 22);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(200, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(159, 22);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "vrokolos.blogspot.com";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(91)))), ((int)(((byte)(50)))));
            this.linkLabel2.Location = new System.Drawing.Point(77, 7);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(60, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Settings";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(91)))), ((int)(((byte)(50)))));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Diggs,
            this.Status,
            this.Comments,
            this.Story});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(92)))), ((int)(((byte)(191)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 18;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(359, 289);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataMemberChanged += new System.EventHandler(this.dataGridView1_DataMemberChanged);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Diggs
            // 
            this.Diggs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Diggs.DataPropertyName = "Diggs";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Diggs.DefaultCellStyle = dataGridViewCellStyle1;
            this.Diggs.FillWeight = 10F;
            this.Diggs.HeaderText = "Diggs";
            this.Diggs.Image = global::diggBeep.Properties.Resources._10x10_digg_thumb;
            this.Diggs.Name = "Diggs";
            this.Diggs.ReadOnly = true;
            this.Diggs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Diggs.Width = 50;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // Comments
            // 
            this.Comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Comments.DataPropertyName = "TotalComments";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Comments.DefaultCellStyle = dataGridViewCellStyle2;
            this.Comments.FillWeight = 10F;
            this.Comments.HeaderText = "Comments";
            this.Comments.Image = global::diggBeep.Properties.Resources.th_comment;
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Comments.Width = 50;
            // 
            // Story
            // 
            this.Story.DataPropertyName = "Title";
            this.Story.FillWeight = 134.7716F;
            this.Story.HeaderText = "Story";
            this.Story.Name = "Story";
            this.Story.ReadOnly = true;
            this.Story.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "diggBeep";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(181)))), ((int)(((byte)(87)))));
            this.panel4.Controls.Add(this.linkLabel6);
            this.panel4.Controls.Add(this.linkLabel12);
            this.panel4.Controls.Add(this.linkLabel13);
            this.panel4.Controls.Add(this.linkLabel14);
            this.panel4.Controls.Add(this.linkLabel15);
            this.panel4.Controls.Add(this.linkLabel16);
            this.panel4.Controls.Add(this.linkLabel17);
            this.panel4.Controls.Add(this.linkLabel18);
            this.panel4.Controls.Add(this.linkLabel19);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 27);
            this.panel4.TabIndex = 8;
            this.panel4.Visible = false;
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(181)))), ((int)(((byte)(87)))));
            this.linkLabel6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel6.Location = new System.Drawing.Point(407, 7);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(49, 13);
            this.linkLabel6.TabIndex = 9;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Offbeat";
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            // 
            // linkLabel12
            // 
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(181)))), ((int)(((byte)(87)))));
            this.linkLabel12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel12.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel12.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel12.Location = new System.Drawing.Point(358, 7);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(44, 13);
            this.linkLabel12.TabIndex = 8;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "Sports";
            this.linkLabel12.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            // 
            // linkLabel13
            // 
            this.linkLabel13.AutoSize = true;
            this.linkLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(181)))), ((int)(((byte)(87)))));
            this.linkLabel13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel13.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel13.Location = new System.Drawing.Point(294, 7);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(58, 13);
            this.linkLabel13.TabIndex = 7;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "Entertain";
            this.linkLabel13.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            // 
            // linkLabel14
            // 
            this.linkLabel14.AutoSize = true;
            this.linkLabel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(181)))), ((int)(((byte)(87)))));
            this.linkLabel14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel14.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel14.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel14.Location = new System.Drawing.Point(236, 7);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(54, 13);
            this.linkLabel14.TabIndex = 6;
            this.linkLabel14.TabStop = true;
            this.linkLabel14.Text = "Lifestyle";
            this.linkLabel14.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            // 
            // linkLabel15
            // 
            this.linkLabel15.AutoSize = true;
            this.linkLabel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(181)))), ((int)(((byte)(87)))));
            this.linkLabel15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel15.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel15.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel15.Location = new System.Drawing.Point(179, 7);
            this.linkLabel15.Name = "linkLabel15";
            this.linkLabel15.Size = new System.Drawing.Size(51, 13);
            this.linkLabel15.TabIndex = 5;
            this.linkLabel15.TabStop = true;
            this.linkLabel15.Text = "Gaming";
            this.linkLabel15.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            // 
            // linkLabel16
            // 
            this.linkLabel16.AutoSize = true;
            this.linkLabel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(181)))), ((int)(((byte)(87)))));
            this.linkLabel16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel16.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel16.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel16.Location = new System.Drawing.Point(83, 7);
            this.linkLabel16.Name = "linkLabel16";
            this.linkLabel16.Size = new System.Drawing.Size(35, 13);
            this.linkLabel16.TabIndex = 3;
            this.linkLabel16.TabStop = true;
            this.linkLabel16.Text = "W+B";
            this.linkLabel16.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            // 
            // linkLabel17
            // 
            this.linkLabel17.AutoSize = true;
            this.linkLabel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(181)))), ((int)(((byte)(87)))));
            this.linkLabel17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel17.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel17.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel17.Location = new System.Drawing.Point(122, 7);
            this.linkLabel17.Name = "linkLabel17";
            this.linkLabel17.Size = new System.Drawing.Size(51, 13);
            this.linkLabel17.TabIndex = 2;
            this.linkLabel17.TabStop = true;
            this.linkLabel17.Text = "Science";
            this.linkLabel17.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            // 
            // linkLabel18
            // 
            this.linkLabel18.AutoSize = true;
            this.linkLabel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(181)))), ((int)(((byte)(87)))));
            this.linkLabel18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel18.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel18.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel18.Location = new System.Drawing.Point(43, 7);
            this.linkLabel18.Name = "linkLabel18";
            this.linkLabel18.Size = new System.Drawing.Size(34, 13);
            this.linkLabel18.TabIndex = 1;
            this.linkLabel18.TabStop = true;
            this.linkLabel18.Text = "Tech";
            this.linkLabel18.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            // 
            // linkLabel19
            // 
            this.linkLabel19.AutoSize = true;
            this.linkLabel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(194)))));
            this.linkLabel19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel19.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel19.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            this.linkLabel19.Location = new System.Drawing.Point(7, 7);
            this.linkLabel19.Name = "linkLabel19";
            this.linkLabel19.Size = new System.Drawing.Size(33, 13);
            this.linkLabel19.TabIndex = 0;
            this.linkLabel19.TabStop = true;
            this.linkLabel19.Text = "Mine";
            this.linkLabel19.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(49)))));
            // 
            // playsndwrkr
            // 
            this.playsndwrkr.DoWork += new System.ComponentModel.DoWorkEventHandler(this.playsndwrkr_DoWork);
            // 
            // playsndcmntwrkr
            // 
            this.playsndcmntwrkr.DoWork += new System.ComponentModel.DoWorkEventHandler(this.playsndcmntwrkr_DoWork);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(359, 49);
            this.panel5.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::diggBeep.Properties.Resources._32x32_digg_guy;
            this.pictureBox2.Location = new System.Drawing.Point(8, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 38);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(181)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 27);
            this.panel1.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.linkLabel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(213, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(146, 27);
            this.panel7.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(129)))));
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.lnkUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 22);
            this.panel3.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(248, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(111, 22);
            this.panel8.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diggBeep.Properties.Resources._80x15_digg_standard_badge;
            this.pictureBox1.Location = new System.Drawing.Point(17, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 16);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lnkUser
            // 
            this.lnkUser.AutoSize = true;
            this.lnkUser.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUser.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkUser.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(91)))), ((int)(((byte)(50)))));
            this.lnkUser.Location = new System.Drawing.Point(51, 4);
            this.lnkUser.Name = "lnkUser";
            this.lnkUser.Size = new System.Drawing.Size(74, 13);
            this.lnkUser.TabIndex = 0;
            this.lnkUser.TabStop = true;
            this.lnkUser.Text = "linkLabel2";
            this.lnkUser.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(91)))), ((int)(((byte)(50)))));
            this.lnkUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUser_LinkClicked);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(144)))));
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(359, 39);
            this.panel6.TabIndex = 10;
            this.panel6.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::diggBeep.Properties.Resources.digglogo;
            this.pictureBox3.Location = new System.Drawing.Point(8, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 35);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // textAndImageColumn1
            // 
            this.textAndImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.textAndImageColumn1.DataPropertyName = "Diggs";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.textAndImageColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.textAndImageColumn1.FillWeight = 30F;
            this.textAndImageColumn1.HeaderText = "Diggs";
            this.textAndImageColumn1.Image = global::diggBeep.Properties.Resources._10x10_digg_thumb;
            this.textAndImageColumn1.Name = "textAndImageColumn1";
            this.textAndImageColumn1.ReadOnly = true;
            this.textAndImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.textAndImageColumn1.Width = 57;
            // 
            // textAndImageColumn2
            // 
            this.textAndImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.textAndImageColumn2.DataPropertyName = "TotalComments";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.textAndImageColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.textAndImageColumn2.FillWeight = 30F;
            this.textAndImageColumn2.HeaderText = "Comments";
            this.textAndImageColumn2.Image = global::diggBeep.Properties.Resources.th_comment;
            this.textAndImageColumn2.Name = "textAndImageColumn2";
            this.textAndImageColumn2.ReadOnly = true;
            this.textAndImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.textAndImageColumn2.Width = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DiggBeep";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TextAndImageColumn textAndImageColumn1;
        private TextAndImageColumn textAndImageColumn2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel12;
        private System.Windows.Forms.LinkLabel linkLabel13;
        private System.Windows.Forms.LinkLabel linkLabel14;
        private System.Windows.Forms.LinkLabel linkLabel15;
        private System.Windows.Forms.LinkLabel linkLabel16;
        private System.Windows.Forms.LinkLabel linkLabel17;
        private System.Windows.Forms.LinkLabel linkLabel18;
        private System.Windows.Forms.LinkLabel linkLabel19;
        private System.ComponentModel.BackgroundWorker playsndwrkr;
        private System.ComponentModel.BackgroundWorker playsndcmntwrkr;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel lnkUser;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextAndImageColumn Diggs;
        private DataGridViewTextBoxColumn Status;
        private TextAndImageColumn Comments;
        private DataGridViewTextBoxColumn Story;
    }
}

