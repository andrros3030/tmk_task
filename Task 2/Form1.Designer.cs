using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public class DoubleBufferedTableLayoutPanel : TableLayoutPanel
{
    public DoubleBufferedTableLayoutPanel()
    {
        DoubleBuffered = true;
    }
}
namespace Task_2
{

    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.create_new_button = new System.Windows.Forms.Button();
            this.label_note = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.is_good = new System.Windows.Forms.CheckBox();
            this.steel_selector = new System.Windows.Forms.DomainUpDown();
            this.number_field = new System.Windows.Forms.TextBox();
            this.weight_field = new System.Windows.Forms.TextBox();
            this.size_X = new System.Windows.Forms.TextBox();
            this.size_Y = new System.Windows.Forms.TextBox();
            this.size_Z = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.table = new DoubleBufferedTableLayoutPanel();
            this.cancel_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // create_new_button
            // 
            this.create_new_button.Location = new System.Drawing.Point(721, 228);
            this.create_new_button.Name = "create_new_button";
            this.create_new_button.Size = new System.Drawing.Size(236, 75);
            this.create_new_button.TabIndex = 0;
            this.create_new_button.Text = "Добавить данные";
            this.create_new_button.UseVisualStyleBackColor = true;
            this.create_new_button.Click += new System.EventHandler(this.create_new_button_Click);
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.Location = new System.Drawing.Point(720, 10);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(62, 17);
            this.label_note.TabIndex = 3;
            this.label_note.Text = "№трубы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(875, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "качество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "марка стали";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "размеры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(875, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "вес";
            // 
            // is_good
            // 
            this.is_good.AutoSize = true;
            this.is_good.Checked = true;
            this.is_good.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is_good.Location = new System.Drawing.Point(878, 190);
            this.is_good.Name = "is_good";
            this.is_good.Size = new System.Drawing.Size(75, 21);
            this.is_good.TabIndex = 10;
            this.is_good.Text = "годная";
            this.is_good.UseVisualStyleBackColor = true;
            // 
            // steel_selector
            // 
            this.steel_selector.Location = new System.Drawing.Point(721, 75);
            this.steel_selector.Name = "steel_selector";
            this.steel_selector.ReadOnly = true;
            this.steel_selector.Size = new System.Drawing.Size(150, 22);
            this.steel_selector.TabIndex = 13;
            // 
            // number_field
            // 
            this.number_field.Location = new System.Drawing.Point(721, 30);
            this.number_field.Name = "number_field";
            this.number_field.Size = new System.Drawing.Size(125, 22);
            this.number_field.TabIndex = 14;
            // 
            // weight_field
            // 
            this.weight_field.Location = new System.Drawing.Point(878, 120);
            this.weight_field.Name = "weight_field";
            this.weight_field.Size = new System.Drawing.Size(79, 22);
            this.weight_field.TabIndex = 15;
            // 
            // size_X
            // 
            this.size_X.Location = new System.Drawing.Point(723, 120);
            this.size_X.Name = "size_X";
            this.size_X.Size = new System.Drawing.Size(106, 22);
            this.size_X.TabIndex = 16;
            // 
            // size_Y
            // 
            this.size_Y.Location = new System.Drawing.Point(723, 155);
            this.size_Y.Name = "size_Y";
            this.size_Y.Size = new System.Drawing.Size(106, 22);
            this.size_Y.TabIndex = 17;
            // 
            // size_Z
            // 
            this.size_Z.Location = new System.Drawing.Point(723, 190);
            this.size_Z.Name = "size_Z";
            this.size_Z.Size = new System.Drawing.Size(106, 22);
            this.size_Z.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.table);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 701);
            this.panel1.TabIndex = 19;
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 7;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(8, 2);
            this.table.TabIndex = 2;
            // 
            // cancel_button
            // 
            this.cancel_button.Enabled = false;
            this.cancel_button.Location = new System.Drawing.Point(882, 309);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 20;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 725);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.size_Z);
            this.Controls.Add(this.size_Y);
            this.Controls.Add(this.size_X);
            this.Controls.Add(this.weight_field);
            this.Controls.Add(this.number_field);
            this.Controls.Add(this.steel_selector);
            this.Controls.Add(this.is_good);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.create_new_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Программа ввода данных по трубам";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_new_button;
        private DoubleBufferedTableLayoutPanel table;
        private Label label_note;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox is_good;
        private DomainUpDown steel_selector;
        private TextBox number_field;
        private TextBox weight_field;
        private TextBox size_X;
        private TextBox size_Y;
        private TextBox size_Z;
        private Panel panel1;
        private Button cancel_button;
    }
}

