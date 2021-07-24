using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace demoGlcontrol
{
    public partial class Form1 : Form
    {

        GLControl miglControl;
        Escenario esc = new Escenario();
        ControlEventos ctrl;
        ControlAnimacion ani ;
        private void Form1_Load(object sender, EventArgs e)
        {

           
            this.miglControl = new GLControl();
           

            this.miglControl.BackColor = System.Drawing.Color.CadetBlue;
            this.miglControl.Location = new System.Drawing.Point(0, 0);
            this.miglControl.Name = "miglControl";
            this.miglControl.Size = new System.Drawing.Size(this.Width, this.Height);
            this.miglControl.TabIndex = 1;
            this.miglControl.VSync = false;
            this.miglControl.Load += new System.EventHandler(this.renderCanvas_Load);
            this.miglControl.Paint += new System.Windows.Forms.PaintEventHandler(this.renderCanvas_Paint);
            this.miglControl.Resize += new System.EventHandler(glControl1_Resize); 
          //  this.miglControl.KeyDown+= new KeyEventHandler(glControl_KeyDown);
            this.Controls.Add(this.miglControl);
        }

        public Form1()
        {
            InitializeComponent();
            this.ctrl = new ControlEventos(esc,"Escenario");
            esc.agregarDibujo("chair", new Silla(new Vector3(-1.5f, 0.05f, -0.7f), 0.4f, 1f, 0.50f));
            esc.agregarDibujo("table", new Mesa(new Vector3(-0.5f, 0.4f, 0f), 1.5f, 0.8f, 2f));
            
        }

        public void renderCanvas_Paint(object sender, PaintEventArgs e)
        {
          
            GL.Clear(ClearBufferMask.ColorBufferBit |ClearBufferMask.DepthBufferBit);
          
            esc.dibujarEscenario();
          

            miglControl.SwapBuffers();
        }
        private void renderCanvas_Load(object sender, EventArgs e)
        {
            GL.ClearColor(65 / 255.0f, 137 / 255.0f, 157 / 255.0f, 0.0f);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            miglControl.MakeCurrent();
            PaintEventArgs p = null;
            renderCanvas_Paint(sender, p);
            GL.End();
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            int w = miglControl.Width;
            int h = miglControl.Height;
            miglControl.MakeCurrent();
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-10.0, 10.0, -5.0, 10.0, 10.0, -10.0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.Viewport(0, 0, w, h);
            GL.End();
            miglControl.SwapBuffers();
        }
        private void select_Click(object sender, EventArgs e) {
            ToolStripMenuItem submenoSelect = (ToolStripMenuItem)sender;
            string nombreSelect = submenoSelect.Text;
            this.ctrl = new ControlEventos(esc, nombreSelect);
        }
        public void Update(object sender, EventArgs e) {
            this.ctrl.eventosTeclado(Keyboard.GetState());
            this.ctrl.eventosTecladoEscenario(Keyboard.GetState());
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.ani = new ControlAnimacion(esc);
            this.ani.hilo.Start();
            
        }
        
    }
}
