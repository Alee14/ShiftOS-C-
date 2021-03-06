﻿namespace ShiftOS
{
    partial class NameChanger
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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.pnlactions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnapply = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlactions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CategoryForeColor = System.Drawing.Color.Black;
            this.propertyGrid1.CategorySplitterColor = System.Drawing.Color.Gray;
            this.propertyGrid1.CommandsActiveLinkColor = System.Drawing.Color.Black;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBorderColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.Gray;
            this.propertyGrid1.CommandsForeColor = System.Drawing.Color.Black;
            this.propertyGrid1.CommandsLinkColor = System.Drawing.Color.Gray;
            this.propertyGrid1.DisabledItemForeColor = System.Drawing.Color.Gray;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 28);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid1.SelectedItemWithFocusBackColor = System.Drawing.Color.Gray;
            this.propertyGrid1.SelectedItemWithFocusForeColor = System.Drawing.Color.White;
            this.propertyGrid1.Size = new System.Drawing.Size(403, 400);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.ToolbarVisible = false;
            this.propertyGrid1.ViewBackColor = System.Drawing.Color.White;
            this.propertyGrid1.ViewBorderColor = System.Drawing.Color.White;
            this.propertyGrid1.ViewForeColor = System.Drawing.Color.Black;
            // 
            // pnlactions
            // 
            this.pnlactions.BackColor = System.Drawing.Color.Gray;
            this.pnlactions.Controls.Add(this.btnapply);
            this.pnlactions.Controls.Add(this.btnload);
            this.pnlactions.Controls.Add(this.btnsave);
            this.pnlactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlactions.Location = new System.Drawing.Point(0, 428);
            this.pnlactions.Name = "pnlactions";
            this.pnlactions.Size = new System.Drawing.Size(403, 39);
            this.pnlactions.TabIndex = 1;
            // 
            // btnapply
            // 
            this.btnapply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnapply.ForeColor = System.Drawing.Color.White;
            this.btnapply.Location = new System.Drawing.Point(3, 3);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(75, 33);
            this.btnapply.TabIndex = 0;
            this.btnapply.Text = "Apply";
            this.btnapply.UseVisualStyleBackColor = true;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // btnload
            // 
            this.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnload.ForeColor = System.Drawing.Color.White;
            this.btnload.Location = new System.Drawing.Point(84, 3);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 33);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "Load Pack";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(165, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 33);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save Pack";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name Changer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.propertyGrid1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlactions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 467);
            this.panel1.TabIndex = 3;
            // 
            // NameChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 467);
            this.Controls.Add(this.panel1);
            this.Name = "NameChanger";
            this.Text = "NameChanger";
            this.Load += new System.EventHandler(this.NameChanger_Load);
            this.pnlactions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnlactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnapply;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}