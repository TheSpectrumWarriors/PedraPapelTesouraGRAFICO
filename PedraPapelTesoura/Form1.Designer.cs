namespace PedraPapelTesoura {
    partial class FormJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogo));
            this.buttonPedra = new System.Windows.Forms.Button();
            this.labelEscolha = new System.Windows.Forms.Label();
            this.buttonPapel = new System.Windows.Forms.Button();
            this.buttonTesoura = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelVS = new System.Windows.Forms.Label();
            this.pictureBoxPC = new System.Windows.Forms.PictureBox();
            this.labelGanhador = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelhomo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPedra
            // 
            this.buttonPedra.Location = new System.Drawing.Point(12, 38);
            this.buttonPedra.Name = "buttonPedra";
            this.buttonPedra.Size = new System.Drawing.Size(75, 23);
            this.buttonPedra.TabIndex = 0;
            this.buttonPedra.Text = "Pedra";
            this.buttonPedra.UseVisualStyleBackColor = true;
            this.buttonPedra.Click += new System.EventHandler(this.buttonPedra_Click);
            // 
            // labelEscolha
            // 
            this.labelEscolha.AutoSize = true;
            this.labelEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelEscolha.Location = new System.Drawing.Point(66, 9);
            this.labelEscolha.Name = "labelEscolha";
            this.labelEscolha.Size = new System.Drawing.Size(150, 18);
            this.labelEscolha.TabIndex = 1;
            this.labelEscolha.Text = "Escolhe para jogar";
            // 
            // buttonPapel
            // 
            this.buttonPapel.Location = new System.Drawing.Point(104, 38);
            this.buttonPapel.Name = "buttonPapel";
            this.buttonPapel.Size = new System.Drawing.Size(75, 23);
            this.buttonPapel.TabIndex = 2;
            this.buttonPapel.Text = "Papel";
            this.buttonPapel.UseVisualStyleBackColor = true;
            this.buttonPapel.Click += new System.EventHandler(this.buttonPapel_Click);
            // 
            // buttonTesoura
            // 
            this.buttonTesoura.Location = new System.Drawing.Point(197, 38);
            this.buttonTesoura.Name = "buttonTesoura";
            this.buttonTesoura.Size = new System.Drawing.Size(75, 23);
            this.buttonTesoura.TabIndex = 3;
            this.buttonTesoura.Text = "Tesoura";
            this.buttonTesoura.UseVisualStyleBackColor = true;
            this.buttonTesoura.Click += new System.EventHandler(this.buttonTesoura_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.InitialImage = null;
            this.pictureBoxUser.Location = new System.Drawing.Point(12, 83);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxUser.TabIndex = 4;
            this.pictureBoxUser.TabStop = false;
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVS.Location = new System.Drawing.Point(121, 119);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(42, 25);
            this.labelVS.TabIndex = 5;
            this.labelVS.Text = "VS";
            // 
            // pictureBoxPC
            // 
            this.pictureBoxPC.Location = new System.Drawing.Point(172, 83);
            this.pictureBoxPC.Name = "pictureBoxPC";
            this.pictureBoxPC.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxPC.TabIndex = 6;
            this.pictureBoxPC.TabStop = false;
            // 
            // labelGanhador
            // 
            this.labelGanhador.AutoSize = true;
            this.labelGanhador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGanhador.Location = new System.Drawing.Point(92, 204);
            this.labelGanhador.Name = "labelGanhador";
            this.labelGanhador.Size = new System.Drawing.Size(0, 15);
            this.labelGanhador.TabIndex = 7;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(50, 231);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(184, 17);
            this.labelResultado.TabIndex = 8;
            this.labelResultado.Text = "Resultado:  0 (Tu)  -  0 (PC)";
            // 
            // labelhomo
            // 
            this.labelhomo.AutoSize = true;
            this.labelhomo.Location = new System.Drawing.Point(106, 206);
            this.labelhomo.Name = "labelhomo";
            this.labelhomo.Size = new System.Drawing.Size(73, 13);
            this.labelhomo.TabIndex = 9;
            this.labelhomo.Text = "O quico é gay";
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelhomo);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelGanhador);
            this.Controls.Add(this.pictureBoxPC);
            this.Controls.Add(this.labelVS);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.buttonTesoura);
            this.Controls.Add(this.buttonPapel);
            this.Controls.Add(this.labelEscolha);
            this.Controls.Add(this.buttonPedra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJogo";
            this.Text = "Pedra/Papel/Tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPedra;
        private System.Windows.Forms.Label labelEscolha;
        private System.Windows.Forms.Button buttonPapel;
        private System.Windows.Forms.Button buttonTesoura;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelVS;
        private System.Windows.Forms.PictureBox pictureBoxPC;
        private System.Windows.Forms.Label labelGanhador;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelhomo;
    }
}

