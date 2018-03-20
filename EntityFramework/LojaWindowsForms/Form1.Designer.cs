namespace LojaWindowsForms
{
    partial class Form1
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnInsertSelect = new System.Windows.Forms.Button();
            this.btnSelectLojaProduto = new System.Windows.Forms.Button();
            this.btnSelectWhere = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateEntityState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(84, 34);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnInsertSelect
            // 
            this.btnInsertSelect.Location = new System.Drawing.Point(450, 34);
            this.btnInsertSelect.Name = "btnInsertSelect";
            this.btnInsertSelect.Size = new System.Drawing.Size(75, 23);
            this.btnInsertSelect.TabIndex = 1;
            this.btnInsertSelect.Text = "Insert e Select";
            this.btnInsertSelect.UseVisualStyleBackColor = true;
            this.btnInsertSelect.Click += new System.EventHandler(this.btnInsertSelect_Click);
            // 
            // btnSelectLojaProduto
            // 
            this.btnSelectLojaProduto.Location = new System.Drawing.Point(223, 34);
            this.btnSelectLojaProduto.Name = "btnSelectLojaProduto";
            this.btnSelectLojaProduto.Size = new System.Drawing.Size(140, 23);
            this.btnSelectLojaProduto.TabIndex = 2;
            this.btnSelectLojaProduto.Text = "Select Loja do Produto";
            this.btnSelectLojaProduto.UseVisualStyleBackColor = true;
            this.btnSelectLojaProduto.Click += new System.EventHandler(this.btnSelectLojaProduto_Click);
            // 
            // btnSelectWhere
            // 
            this.btnSelectWhere.Location = new System.Drawing.Point(84, 80);
            this.btnSelectWhere.Name = "btnSelectWhere";
            this.btnSelectWhere.Size = new System.Drawing.Size(101, 23);
            this.btnSelectWhere.TabIndex = 3;
            this.btnSelectWhere.Text = "SelectWhere";
            this.btnSelectWhere.UseVisualStyleBackColor = true;
            this.btnSelectWhere.Click += new System.EventHandler(this.btnSelectWhere_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(84, 118);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateEntityState
            // 
            this.btnUpdateEntityState.Location = new System.Drawing.Point(249, 119);
            this.btnUpdateEntityState.Name = "btnUpdateEntityState";
            this.btnUpdateEntityState.Size = new System.Drawing.Size(129, 39);
            this.btnUpdateEntityState.TabIndex = 6;
            this.btnUpdateEntityState.Text = "UpdateEntityState";
            this.btnUpdateEntityState.UseVisualStyleBackColor = true;
            this.btnUpdateEntityState.Click += new System.EventHandler(this.btnUpdateEntityState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 261);
            this.Controls.Add(this.btnUpdateEntityState);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelectWhere);
            this.Controls.Add(this.btnSelectLojaProduto);
            this.Controls.Add(this.btnInsertSelect);
            this.Controls.Add(this.btnInserir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnInsertSelect;
        private System.Windows.Forms.Button btnSelectLojaProduto;
        private System.Windows.Forms.Button btnSelectWhere;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateEntityState;
    }
}

