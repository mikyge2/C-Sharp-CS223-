namespace lec_8
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
            this.components = new System.ComponentModel.Container();
            this.id = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.Label();
            this.ln = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.sy = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.fntext = new System.Windows.Forms.TextBox();
            this.lntext = new System.Windows.Forms.TextBox();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.datetext = new System.Windows.Forms.DateTimePicker();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.gendertext = new System.Windows.Forms.GroupBox();
            this.add = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.card1 = new lec_8.card();
            this.gendertext.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(16, 50);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(42, 31);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fn.Location = new System.Drawing.Point(16, 95);
            this.fn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(147, 31);
            this.fn.TabIndex = 1;
            this.fn.Text = "First Name";
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ln.Location = new System.Drawing.Point(16, 155);
            this.ln.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(145, 31);
            this.ln.TabIndex = 2;
            this.ln.Text = "Last Name";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address.Location = new System.Drawing.Point(16, 207);
            this.address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(114, 31);
            this.address.TabIndex = 3;
            this.address.Text = "Address";
            // 
            // sy
            // 
            this.sy.AutoSize = true;
            this.sy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sy.Location = new System.Drawing.Point(16, 261);
            this.sy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sy.Name = "sy";
            this.sy.Size = new System.Drawing.Size(161, 31);
            this.sy.TabIndex = 4;
            this.sy.Text = "School Year";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender.Location = new System.Drawing.Point(26, 325);
            this.gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(104, 31);
            this.gender.TabIndex = 5;
            this.gender.Text = "Gender";
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(197, 58);
            this.idtext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(236, 22);
            this.idtext.TabIndex = 6;
            this.idtext.TextChanged += new System.EventHandler(this.idtext_TextChanged);
            // 
            // fntext
            // 
            this.fntext.Location = new System.Drawing.Point(197, 102);
            this.fntext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fntext.Name = "fntext";
            this.fntext.Size = new System.Drawing.Size(236, 22);
            this.fntext.TabIndex = 7;
            // 
            // lntext
            // 
            this.lntext.Location = new System.Drawing.Point(197, 161);
            this.lntext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lntext.Name = "lntext";
            this.lntext.Size = new System.Drawing.Size(236, 22);
            this.lntext.TabIndex = 8;
            this.lntext.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // addresstext
            // 
            this.addresstext.Location = new System.Drawing.Point(197, 214);
            this.addresstext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(236, 22);
            this.addresstext.TabIndex = 9;
            // 
            // datetext
            // 
            this.datetext.Location = new System.Drawing.Point(197, 261);
            this.datetext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datetext.Name = "datetext";
            this.datetext.Size = new System.Drawing.Size(236, 22);
            this.datetext.TabIndex = 10;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.male.Location = new System.Drawing.Point(21, 23);
            this.male.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(80, 30);
            this.male.TabIndex = 11;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.female.Location = new System.Drawing.Point(153, 23);
            this.female.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(106, 30);
            this.female.TabIndex = 12;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // gendertext
            // 
            this.gendertext.Controls.Add(this.female);
            this.gendertext.Controls.Add(this.male);
            this.gendertext.Location = new System.Drawing.Point(197, 302);
            this.gendertext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gendertext.Name = "gendertext";
            this.gendertext.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gendertext.Size = new System.Drawing.Size(267, 71);
            this.gendertext.TabIndex = 13;
            this.gendertext.TabStop = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(388, 432);
            this.add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 28);
            this.add.TabIndex = 14;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.card1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(567, 58);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(447, 343);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // card1
            // 
            this.card1.address = null;
            this.card1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.card1.date = null;
            this.card1.First = "";
            this.card1.gender = null;
            this.card1.Id = null;
            this.card1.last = null;
            this.card1.Location = new System.Drawing.Point(5, 5);
            this.card1.Margin = new System.Windows.Forms.Padding(5);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(428, 337);
            this.card1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.gendertext);
            this.Controls.Add(this.datetext);
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.lntext);
            this.Controls.Add(this.fntext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.sy);
            this.Controls.Add(this.address);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.id);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gendertext.ResumeLayout(false);
            this.gendertext.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label fn;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label sy;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox fntext;
        private System.Windows.Forms.TextBox lntext;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.DateTimePicker datetext;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.GroupBox gendertext;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private card card1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

