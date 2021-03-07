
namespace Paste_Text_to_Columns_with_RegEx
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTable = new System.Windows.Forms.GroupBox();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.groupBoxRowText = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.textBoxRow = new System.Windows.Forms.TextBox();
            this.groupBoxRegEx = new System.Windows.Forms.GroupBox();
            this.textBoxCompiledRegEx = new System.Windows.Forms.TextBox();
            this.buttonUndoRegex = new System.Windows.Forms.Button();
            this.buttonEscapeRegEx = new System.Windows.Forms.Button();
            this.buttonCompileRegEx = new System.Windows.Forms.Button();
            this.textBoxRegEx = new System.Windows.Forms.TextBox();
            this.buttonRedoRegEx = new System.Windows.Forms.Button();
            this.groupBoxTable.SuspendLayout();
            this.groupBoxRowText.SuspendLayout();
            this.groupBoxRegEx.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTable
            // 
            this.groupBoxTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTable.Controls.Add(this.textBoxTable);
            this.groupBoxTable.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTable.Name = "groupBoxTable";
            this.groupBoxTable.Size = new System.Drawing.Size(776, 194);
            this.groupBoxTable.TabIndex = 0;
            this.groupBoxTable.TabStop = false;
            this.groupBoxTable.Text = "Table";
            // 
            // textBoxTable
            // 
            this.textBoxTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTable.Location = new System.Drawing.Point(3, 19);
            this.textBoxTable.Multiline = true;
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTable.Size = new System.Drawing.Size(770, 172);
            this.textBoxTable.TabIndex = 0;
            // 
            // groupBoxRowText
            // 
            this.groupBoxRowText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxRowText.Controls.Add(this.checkBox1);
            this.groupBoxRowText.Controls.Add(this.buttonAddRow);
            this.groupBoxRowText.Controls.Add(this.textBoxRow);
            this.groupBoxRowText.Location = new System.Drawing.Point(12, 212);
            this.groupBoxRowText.Name = "groupBoxRowText";
            this.groupBoxRowText.Size = new System.Drawing.Size(234, 226);
            this.groupBoxRowText.TabIndex = 1;
            this.groupBoxRowText.TabStop = false;
            this.groupBoxRowText.Text = "Row Text";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(87, 200);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Add Row when Paste";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddRow.Location = new System.Drawing.Point(6, 197);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRow.TabIndex = 1;
            this.buttonAddRow.Text = "Add Row";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // textBoxRow
            // 
            this.textBoxRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRow.Location = new System.Drawing.Point(6, 22);
            this.textBoxRow.Multiline = true;
            this.textBoxRow.Name = "textBoxRow";
            this.textBoxRow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRow.Size = new System.Drawing.Size(218, 169);
            this.textBoxRow.TabIndex = 0;
            // 
            // groupBoxRegEx
            // 
            this.groupBoxRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRegEx.Controls.Add(this.buttonRedoRegEx);
            this.groupBoxRegEx.Controls.Add(this.textBoxCompiledRegEx);
            this.groupBoxRegEx.Controls.Add(this.buttonUndoRegex);
            this.groupBoxRegEx.Controls.Add(this.buttonEscapeRegEx);
            this.groupBoxRegEx.Controls.Add(this.buttonCompileRegEx);
            this.groupBoxRegEx.Controls.Add(this.textBoxRegEx);
            this.groupBoxRegEx.Location = new System.Drawing.Point(252, 212);
            this.groupBoxRegEx.Name = "groupBoxRegEx";
            this.groupBoxRegEx.Size = new System.Drawing.Size(536, 226);
            this.groupBoxRegEx.TabIndex = 2;
            this.groupBoxRegEx.TabStop = false;
            this.groupBoxRegEx.Text = "Regular Expression";
            // 
            // textBoxCompiledRegEx
            // 
            this.textBoxCompiledRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCompiledRegEx.Location = new System.Drawing.Point(6, 144);
            this.textBoxCompiledRegEx.Multiline = true;
            this.textBoxCompiledRegEx.Name = "textBoxCompiledRegEx";
            this.textBoxCompiledRegEx.ReadOnly = true;
            this.textBoxCompiledRegEx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCompiledRegEx.Size = new System.Drawing.Size(524, 76);
            this.textBoxCompiledRegEx.TabIndex = 5;
            // 
            // buttonUndoRegex
            // 
            this.buttonUndoRegex.Location = new System.Drawing.Point(168, 115);
            this.buttonUndoRegex.Name = "buttonUndoRegex";
            this.buttonUndoRegex.Size = new System.Drawing.Size(75, 23);
            this.buttonUndoRegex.TabIndex = 4;
            this.buttonUndoRegex.Text = "Undo";
            this.buttonUndoRegex.UseVisualStyleBackColor = true;
            this.buttonUndoRegex.Click += new System.EventHandler(this.buttonUndoRegex_Click);
            // 
            // buttonEscapeRegEx
            // 
            this.buttonEscapeRegEx.Location = new System.Drawing.Point(87, 115);
            this.buttonEscapeRegEx.Name = "buttonEscapeRegEx";
            this.buttonEscapeRegEx.Size = new System.Drawing.Size(75, 23);
            this.buttonEscapeRegEx.TabIndex = 3;
            this.buttonEscapeRegEx.Text = "Escape";
            this.buttonEscapeRegEx.UseVisualStyleBackColor = true;
            this.buttonEscapeRegEx.Click += new System.EventHandler(this.buttonEscapeRegEx_Click);
            // 
            // buttonCompileRegEx
            // 
            this.buttonCompileRegEx.Location = new System.Drawing.Point(6, 115);
            this.buttonCompileRegEx.Name = "buttonCompileRegEx";
            this.buttonCompileRegEx.Size = new System.Drawing.Size(75, 23);
            this.buttonCompileRegEx.TabIndex = 1;
            this.buttonCompileRegEx.Text = "Compile";
            this.buttonCompileRegEx.UseVisualStyleBackColor = true;
            this.buttonCompileRegEx.Click += new System.EventHandler(this.buttonCompileRegEx_Click);
            // 
            // textBoxRegEx
            // 
            this.textBoxRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegEx.Location = new System.Drawing.Point(3, 19);
            this.textBoxRegEx.Multiline = true;
            this.textBoxRegEx.Name = "textBoxRegEx";
            this.textBoxRegEx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRegEx.Size = new System.Drawing.Size(527, 90);
            this.textBoxRegEx.TabIndex = 0;
            // 
            // buttonRedoRegEx
            // 
            this.buttonRedoRegEx.Location = new System.Drawing.Point(249, 115);
            this.buttonRedoRegEx.Name = "buttonRedoRegEx";
            this.buttonRedoRegEx.Size = new System.Drawing.Size(75, 23);
            this.buttonRedoRegEx.TabIndex = 6;
            this.buttonRedoRegEx.Text = "Redo";
            this.buttonRedoRegEx.UseVisualStyleBackColor = true;
            this.buttonRedoRegEx.Click += new System.EventHandler(this.buttonRedoRegEx_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxRegEx);
            this.Controls.Add(this.groupBoxRowText);
            this.Controls.Add(this.groupBoxTable);
            this.Name = "FormMain";
            this.Text = "Paste Text to Columns with RegEx";
            this.groupBoxTable.ResumeLayout(false);
            this.groupBoxTable.PerformLayout();
            this.groupBoxRowText.ResumeLayout(false);
            this.groupBoxRowText.PerformLayout();
            this.groupBoxRegEx.ResumeLayout(false);
            this.groupBoxRegEx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTable;
        private System.Windows.Forms.GroupBox groupBoxRowText;
        private System.Windows.Forms.TextBox textBoxRow;
        private System.Windows.Forms.GroupBox groupBoxRegEx;
        private System.Windows.Forms.TextBox textBoxRegEx;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.Button buttonCompileRegEx;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Button buttonEscapeRegEx;
        private System.Windows.Forms.Button buttonUndoRegex;
        private System.Windows.Forms.TextBox textBoxCompiledRegEx;
        private System.Windows.Forms.Button buttonRedoRegEx;
    }
}

