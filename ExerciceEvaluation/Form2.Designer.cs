namespace windowsform
{
    partial class Form2
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
            this.datedebut = new System.Windows.Forms.DateTimePicker();
            this.datefin = new System.Windows.Forms.DateTimePicker();
            this.tentative = new System.Windows.Forms.CheckedListBox();
            this.label1datedebut = new System.Windows.Forms.Label();
            this.labeldatefin = new System.Windows.Forms.Label();
            this.labeltentative = new System.Windows.Forms.Label();
            this.labeltypedexam = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbqsm = new System.Windows.Forms.RadioButton();
            this.rbquestion = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nbretudiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datedebut
            // 
            this.datedebut.Location = new System.Drawing.Point(178, 61);
            this.datedebut.Name = "datedebut";
            this.datedebut.Size = new System.Drawing.Size(200, 20);
            this.datedebut.TabIndex = 0;
            this.datedebut.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.datedebut.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // datefin
            // 
            this.datefin.Location = new System.Drawing.Point(178, 97);
            this.datefin.Name = "datefin";
            this.datefin.Size = new System.Drawing.Size(200, 20);
            this.datefin.TabIndex = 1;
            this.datefin.Value = new System.DateTime(2022, 12, 1, 21, 3, 0, 0);
            this.datefin.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // tentative
            // 
            this.tentative.FormattingEnabled = true;
            this.tentative.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.tentative.Location = new System.Drawing.Point(178, 133);
            this.tentative.Name = "tentative";
            this.tentative.Size = new System.Drawing.Size(200, 64);
            this.tentative.TabIndex = 2;
            // 
            // label1datedebut
            // 
            this.label1datedebut.AutoSize = true;
            this.label1datedebut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1datedebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1datedebut.ForeColor = System.Drawing.Color.Navy;
            this.label1datedebut.Location = new System.Drawing.Point(12, 61);
            this.label1datedebut.Name = "label1datedebut";
            this.label1datedebut.Size = new System.Drawing.Size(85, 16);
            this.label1datedebut.TabIndex = 3;
            this.label1datedebut.Text = "date debut:";
            // 
            // labeldatefin
            // 
            this.labeldatefin.AutoSize = true;
            this.labeldatefin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatefin.ForeColor = System.Drawing.Color.Navy;
            this.labeldatefin.Location = new System.Drawing.Point(12, 101);
            this.labeldatefin.Name = "labeldatefin";
            this.labeldatefin.Size = new System.Drawing.Size(62, 16);
            this.labeldatefin.TabIndex = 4;
            this.labeldatefin.Text = "date fin:";
            // 
            // labeltentative
            // 
            this.labeltentative.AutoSize = true;
            this.labeltentative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltentative.ForeColor = System.Drawing.Color.Navy;
            this.labeltentative.Location = new System.Drawing.Point(12, 143);
            this.labeltentative.Name = "labeltentative";
            this.labeltentative.Size = new System.Drawing.Size(66, 16);
            this.labeltentative.TabIndex = 5;
            this.labeltentative.Text = "tentative";
            // 
            // labeltypedexam
            // 
            this.labeltypedexam.AutoSize = true;
            this.labeltypedexam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltypedexam.ForeColor = System.Drawing.Color.Navy;
            this.labeltypedexam.Location = new System.Drawing.Point(12, 238);
            this.labeltypedexam.Name = "labeltypedexam";
            this.labeltypedexam.Size = new System.Drawing.Size(104, 15);
            this.labeltypedexam.TabIndex = 6;
            this.labeltypedexam.Text = "type de l\'exam:";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Navy;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnuler.Location = new System.Drawing.Point(591, 331);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(83, 29);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.Navy;
            this.btnSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuivant.Location = new System.Drawing.Point(502, 331);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(83, 29);
            this.btnSuivant.TabIndex = 10;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // rbqsm
            // 
            this.rbqsm.AutoSize = true;
            this.rbqsm.Location = new System.Drawing.Point(178, 236);
            this.rbqsm.Name = "rbqsm";
            this.rbqsm.Size = new System.Drawing.Size(49, 17);
            this.rbqsm.TabIndex = 11;
            this.rbqsm.TabStop = true;
            this.rbqsm.Text = "QSM";
            this.rbqsm.UseVisualStyleBackColor = true;
            this.rbqsm.CheckedChanged += new System.EventHandler(this.rbqsm_CheckedChanged);
            // 
            // rbquestion
            // 
            this.rbquestion.AutoSize = true;
            this.rbquestion.Location = new System.Drawing.Point(256, 235);
            this.rbquestion.Name = "rbquestion";
            this.rbquestion.Size = new System.Drawing.Size(100, 17);
            this.rbquestion.TabIndex = 12;
            this.rbquestion.TabStop = true;
            this.rbquestion.Text = "Question ouvert";
            this.rbquestion.UseVisualStyleBackColor = true;
            this.rbquestion.CheckedChanged += new System.EventHandler(this.rbquestion_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre des etudiants";
            // 
            // nbretudiant
            // 
            this.nbretudiant.Location = new System.Drawing.Point(178, 276);
            this.nbretudiant.Multiline = true;
            this.nbretudiant.Name = "nbretudiant";
            this.nbretudiant.Size = new System.Drawing.Size(197, 25);
            this.nbretudiant.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ajouter un exam";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nbretudiant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbquestion);
            this.Controls.Add(this.rbqsm);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.labeltypedexam);
            this.Controls.Add(this.labeltentative);
            this.Controls.Add(this.labeldatefin);
            this.Controls.Add(this.label1datedebut);
            this.Controls.Add(this.tentative);
            this.Controls.Add(this.datefin);
            this.Controls.Add(this.datedebut);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datedebut;
        private System.Windows.Forms.DateTimePicker datefin;
        private System.Windows.Forms.CheckedListBox tentative;
        private System.Windows.Forms.Label label1datedebut;
        private System.Windows.Forms.Label labeldatefin;
        private System.Windows.Forms.Label labeltentative;
        private System.Windows.Forms.Label labeltypedexam;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSuivant;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbqsm;
        private System.Windows.Forms.RadioButton rbquestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nbretudiant;
        private System.Windows.Forms.Label label2;
    }
}