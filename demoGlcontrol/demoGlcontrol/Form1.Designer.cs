namespace demoGlcontrol
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.objetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pata1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pata2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pata3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pata4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espaldarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pata1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pata2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pata3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pata4ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todaLaSillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.Update);
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
           // this.timer1.Tick += new System.EventHandler(this.button1_Click_1);

            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objetosToolStripMenuItem,
            this.accionesToolStripMenuItem,
            this.animarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // objetosToolStripMenuItem
            // 
            this.objetosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesaToolStripMenuItem,
            this.sillaToolStripMenuItem,
            this.escenarioToolStripMenuItem});
            this.objetosToolStripMenuItem.Name = "objetosToolStripMenuItem";
            this.objetosToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.objetosToolStripMenuItem.Text = "Objetos";
            // 
            // mesaToolStripMenuItem
            // 
            this.mesaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseToolStripMenuItem,
            this.pata1ToolStripMenuItem,
            this.pata2ToolStripMenuItem,
            this.pata3ToolStripMenuItem,
            this.pata4ToolStripMenuItem,
            this.tableToolStripMenuItem});
            this.mesaToolStripMenuItem.Name = "mesaToolStripMenuItem";
            this.mesaToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.mesaToolStripMenuItem.Text = "Mesa";
            // 
            // baseToolStripMenuItem
            // 
            this.baseToolStripMenuItem.Name = "baseToolStripMenuItem";
            this.baseToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.baseToolStripMenuItem.Text = "Base";
            // 
            // pata1ToolStripMenuItem
            // 
            this.pata1ToolStripMenuItem.Name = "pata1ToolStripMenuItem";
            this.pata1ToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.pata1ToolStripMenuItem.Text = "pata1";
            // 
            // pata2ToolStripMenuItem
            // 
            this.pata2ToolStripMenuItem.Name = "pata2ToolStripMenuItem";
            this.pata2ToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.pata2ToolStripMenuItem.Text = "pata2";
            // 
            // pata3ToolStripMenuItem
            // 
            this.pata3ToolStripMenuItem.Name = "pata3ToolStripMenuItem";
            this.pata3ToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.pata3ToolStripMenuItem.Text = "pata3";
            // 
            // pata4ToolStripMenuItem
            // 
            this.pata4ToolStripMenuItem.Name = "pata4ToolStripMenuItem";
            this.pata4ToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.pata4ToolStripMenuItem.Text = "pata4";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.tableToolStripMenuItem.Text = "table";
            this.tableToolStripMenuItem.Click += new System.EventHandler(this.select_Click);
            // 
            // sillaToolStripMenuItem
            // 
            this.sillaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espaldarToolStripMenuItem,
            this.asientoToolStripMenuItem,
            this.pata1ToolStripMenuItem1,
            this.pata2ToolStripMenuItem1,
            this.pata3ToolStripMenuItem1,
            this.pata4ToolStripMenuItem1,
            this.todaLaSillaToolStripMenuItem});
            this.sillaToolStripMenuItem.Name = "sillaToolStripMenuItem";
            this.sillaToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.sillaToolStripMenuItem.Text = "Silla";
            // 
            // espaldarToolStripMenuItem
            // 
            this.espaldarToolStripMenuItem.Name = "espaldarToolStripMenuItem";
            this.espaldarToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.espaldarToolStripMenuItem.Text = "espaldar";
            // 
            // asientoToolStripMenuItem
            // 
            this.asientoToolStripMenuItem.Name = "asientoToolStripMenuItem";
            this.asientoToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.asientoToolStripMenuItem.Text = "asiento";
            // 
            // pata1ToolStripMenuItem1
            // 
            this.pata1ToolStripMenuItem1.Name = "pata1ToolStripMenuItem1";
            this.pata1ToolStripMenuItem1.Size = new System.Drawing.Size(163, 30);
            this.pata1ToolStripMenuItem1.Text = "pata1";
            // 
            // pata2ToolStripMenuItem1
            // 
            this.pata2ToolStripMenuItem1.Name = "pata2ToolStripMenuItem1";
            this.pata2ToolStripMenuItem1.Size = new System.Drawing.Size(163, 30);
            this.pata2ToolStripMenuItem1.Text = "pata2";
            // 
            // pata3ToolStripMenuItem1
            // 
            this.pata3ToolStripMenuItem1.Name = "pata3ToolStripMenuItem1";
            this.pata3ToolStripMenuItem1.Size = new System.Drawing.Size(163, 30);
            this.pata3ToolStripMenuItem1.Text = "pata3";
            // 
            // pata4ToolStripMenuItem1
            // 
            this.pata4ToolStripMenuItem1.Name = "pata4ToolStripMenuItem1";
            this.pata4ToolStripMenuItem1.Size = new System.Drawing.Size(163, 30);
            this.pata4ToolStripMenuItem1.Text = "pata4";
            // 
            // todaLaSillaToolStripMenuItem
            // 
            this.todaLaSillaToolStripMenuItem.Name = "todaLaSillaToolStripMenuItem";
            this.todaLaSillaToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.todaLaSillaToolStripMenuItem.Text = "chair";
            this.todaLaSillaToolStripMenuItem.Click += new System.EventHandler(this.select_Click);
            // 
            // escenarioToolStripMenuItem
            // 
            this.escenarioToolStripMenuItem.Name = "escenarioToolStripMenuItem";
            this.escenarioToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.escenarioToolStripMenuItem.Text = "Escenario";
            this.escenarioToolStripMenuItem.Click += new System.EventHandler(this.select_Click);
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotarToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // rotarToolStripMenuItem
            // 
            this.rotarToolStripMenuItem.Name = "rotarToolStripMenuItem";
            this.rotarToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.rotarToolStripMenuItem.Text = "Rotar";
            // 
            // animarToolStripMenuItem
            // 
            this.animarToolStripMenuItem.Name = "animarToolStripMenuItem";
            this.animarToolStripMenuItem.Size = new System.Drawing.Size(12, 29);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Animar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem objetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pata1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pata2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pata3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pata4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espaldarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pata1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pata2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pata3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pata4ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem escenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todaLaSillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animarToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

