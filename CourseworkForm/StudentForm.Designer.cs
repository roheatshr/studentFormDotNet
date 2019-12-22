namespace CourseworkForm
{
    partial class StudentForm
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.cbCourseEnrol = new System.Windows.Forms.ComboBox();
            this.dpRegDate = new System.Windows.Forms.DateTimePicker();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.regdateLbl = new System.Windows.Forms.Label();
            this.contactLbl = new System.Windows.Forms.Label();
            this.lnameLbl = new System.Windows.Forms.Label();
            this.courseenrolLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.mnameLbl = new System.Windows.Forms.Label();
            this.fnameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(665, 302);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 29;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(568, 302);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 28;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(476, 302);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 27;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cbCourseEnrol
            // 
            this.cbCourseEnrol.FormattingEnabled = true;
            this.cbCourseEnrol.Items.AddRange(new object[] {
            "Computing",
            "Multimedia",
            "Networking"});
            this.cbCourseEnrol.Location = new System.Drawing.Point(420, 245);
            this.cbCourseEnrol.Name = "cbCourseEnrol";
            this.cbCourseEnrol.Size = new System.Drawing.Size(121, 24);
            this.cbCourseEnrol.TabIndex = 26;
            // 
            // dpRegDate
            // 
            this.dpRegDate.Location = new System.Drawing.Point(420, 175);
            this.dpRegDate.Name = "dpRegDate";
            this.dpRegDate.Size = new System.Drawing.Size(200, 22);
            this.dpRegDate.TabIndex = 25;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(134, 108);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 22);
            this.txtFname.TabIndex = 24;
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(420, 113);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(100, 22);
            this.txtMname.TabIndex = 23;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(640, 113);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 22);
            this.txtLname.TabIndex = 22;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(134, 180);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 21;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(134, 245);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 22);
            this.txtContact.TabIndex = 20;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(134, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 19;
            // 
            // regdateLbl
            // 
            this.regdateLbl.AutoSize = true;
            this.regdateLbl.Location = new System.Drawing.Point(285, 183);
            this.regdateLbl.Name = "regdateLbl";
            this.regdateLbl.Size = new System.Drawing.Size(122, 17);
            this.regdateLbl.TabIndex = 17;
            this.regdateLbl.Text = "Registration Date:";
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Location = new System.Drawing.Point(46, 248);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(82, 17);
            this.contactLbl.TabIndex = 16;
            this.contactLbl.Text = "Contact No:";
            // 
            // lnameLbl
            // 
            this.lnameLbl.AutoSize = true;
            this.lnameLbl.Location = new System.Drawing.Point(554, 113);
            this.lnameLbl.Name = "lnameLbl";
            this.lnameLbl.Size = new System.Drawing.Size(80, 17);
            this.lnameLbl.TabIndex = 15;
            this.lnameLbl.Text = "Last Name:";
            // 
            // courseenrolLbl
            // 
            this.courseenrolLbl.AutoSize = true;
            this.courseenrolLbl.Location = new System.Drawing.Point(285, 245);
            this.courseenrolLbl.Name = "courseenrolLbl";
            this.courseenrolLbl.Size = new System.Drawing.Size(94, 17);
            this.courseenrolLbl.TabIndex = 14;
            this.courseenrolLbl.Text = "Course Enrol:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(48, 180);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(64, 17);
            this.addressLbl.TabIndex = 13;
            this.addressLbl.Text = "Address:";
            // 
            // mnameLbl
            // 
            this.mnameLbl.AutoSize = true;
            this.mnameLbl.Location = new System.Drawing.Point(285, 116);
            this.mnameLbl.Name = "mnameLbl";
            this.mnameLbl.Size = new System.Drawing.Size(94, 17);
            this.mnameLbl.TabIndex = 12;
            this.mnameLbl.Text = "Middle Name:";
            // 
            // fnameLbl
            // 
            this.fnameLbl.AutoSize = true;
            this.fnameLbl.Location = new System.Drawing.Point(48, 108);
            this.fnameLbl.Name = "fnameLbl";
            this.fnameLbl.Size = new System.Drawing.Size(80, 17);
            this.fnameLbl.TabIndex = 18;
            this.fnameLbl.Text = "First Name:";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(51, 48);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(77, 17);
            this.idLbl.TabIndex = 11;
            this.idLbl.Text = "Id Number:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(54, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 154);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 542);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cbCourseEnrol);
            this.Controls.Add(this.dpRegDate);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtMname);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.regdateLbl);
            this.Controls.Add(this.contactLbl);
            this.Controls.Add(this.lnameLbl);
            this.Controls.Add(this.courseenrolLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.mnameLbl);
            this.Controls.Add(this.fnameLbl);
            this.Controls.Add(this.idLbl);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox cbCourseEnrol;
        private System.Windows.Forms.DateTimePicker dpRegDate;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label regdateLbl;
        private System.Windows.Forms.Label contactLbl;
        private System.Windows.Forms.Label lnameLbl;
        private System.Windows.Forms.Label courseenrolLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label mnameLbl;
        private System.Windows.Forms.Label fnameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}