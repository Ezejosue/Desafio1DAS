using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ScottPlot;

namespace WinFormsApp1
{
    public partial class Information : Form
    {
        public string Thema { get; set; }

        public Information(string thema)
        {

            Thema = thema;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabInfo1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tabInfo2_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {
        }

        private void Information_Load(object sender, EventArgs e)
        {

            switch (Thema)
            {
                case "Redes":
                    TabControl1.TabPages.Remove(tabInfo2);

                    TabControl1.SelectedIndex = 2;
                    labelM.Text = "Facebook";
                    labelZ.Text = "Instagram";
                    labelX.Text = "Twitter";
                    CreateGraphs();

                    TabControl1.SelectedIndex = 0;

                    break;
                case "Streaming":
                    TabControl1.TabPages.Remove(tabInfo1);
                    TabControl1.SelectedIndex = 2;
                    labelM.Text = "Netflix";
                    labelZ.Text = "Amazon";
                    labelX.Text = "Disney";

                    CreateGraphStr();

                    TabControl1.SelectedIndex = 0;

                    break;
                default:
                    MessageBox.Show("Ese tema no existe");
                    break;
            }

        }

        private void tabEstadistica_Click(object sender, EventArgs e)
        {

        }


        private void CreateGraph(PictureBox pictureBox, string graphType, double[] values, string[] labels, double[][] multiAxisValues = null)
        {
            var plt = new ScottPlot.Plot(600, 400);

            if (graphType == "Pie")
            {
                var pie = plt.AddPie(values);
                pie.SliceLabels = labels;
                pie.ShowValues = true;
                plt.Title("Generación que Usa Más Cada Red Social");
            }
            else if (graphType == "Bar")
            {
                plt.AddBar(values);
                plt.XTicks(new double[] { 0, 1, 2 }, labels);
                plt.Title("Número de Usuarios (en millones y billones)");
                plt.XLabel("Plataformas de Redes Sociales");
                plt.YLabel("Número de Usuarios");
            }
            else if (graphType == "MultiAxis" && multiAxisValues != null)
            {
                var sigZ = plt.AddSignal(multiAxisValues[0]);
                var sigM = plt.AddSignal(multiAxisValues[1]);
                var sigX = plt.AddSignal(multiAxisValues[2]);

                sigZ.YAxisIndex = 0;
                plt.YAxis.Label("Generación Z");
                plt.YAxis.Color(sigZ.Color);

                sigM.YAxisIndex = 1;
                plt.AddAxis(ScottPlot.Renderable.Edge.Right, axisIndex: 2);
                plt.YAxis2.Label("Millennials");
                plt.YAxis2.Color(sigM.Color);
                plt.YAxis2.Ticks(true);

                sigX.YAxisIndex = 2;
                var yAxisGenX = plt.AddAxis(ScottPlot.Renderable.Edge.Left, axisIndex: 3);
                yAxisGenX.Label("Generación X");
                yAxisGenX.Color(sigX.Color);
                yAxisGenX.Ticks(true);

                plt.XTicks(new double[] { 0, 1, 2 }, labels);
                plt.Title("Generación que Más Usa Cada Red Social");
            }

            pictureBox.Image = plt.Render();
        }


        private void CreateGraphs()
        {
            double[] pieValues = { 40, 30, 30 };
            string[] pieLabels = { "Generación Z (Facebook)", "Millennials (Instagram)", "Generación X (Twitter)" };
            CreateGraph(pictureBoxRedes2, "Pie", pieValues, pieLabels);

            double[] barValues = { 2.9, 1.2, 1.3 };
            string[] barLabels = { "Facebook", "Instagram", "Twitter" };
            CreateGraph(pictureBoxRedes, "Bar", barValues, barLabels);

            double[] genZ = { 40, 60, 20 };
            double[] millennials = { 30, 30, 50 };
            double[] genX = { 30, 10, 30 };
            double[][] multiAxisValues = { genZ, millennials, genX };
            string[] multiAxisLabels = { "Facebook", "Instagram", "Twitter" };
            CreateGraph(pictureBoxRedes3, "MultiAxis", null, multiAxisLabels, multiAxisValues);
        }

        private void CreateGraphSt(PictureBox pictureBox, string graphType, double[] values, string[] labels, double[][] multiAxisValues = null)
        {
            var plt = new ScottPlot.Plot(600, 400);

            if (graphType == "Pie")
            {
                var pie = plt.AddPie(values);
                pie.SliceLabels = labels;
                pie.ShowValues = true;
                plt.Title("Generación que Usa Más Cada Servicio de Streaming");
            }
            else if (graphType == "Bar")
            {
                plt.AddBar(values);
                plt.XTicks(new double[] { 0, 1, 2 }, labels);
                plt.Title("Número de Usuarios (en millones y billones)");
                plt.XLabel("Servicios de Streaming");
                plt.YLabel("Número de Usuarios");
            }
            else if (graphType == "MultiAxis" && multiAxisValues != null)
            {
                var sigZ = plt.AddSignal(multiAxisValues[0]);
                var sigM = plt.AddSignal(multiAxisValues[1]);
                var sigX = plt.AddSignal(multiAxisValues[2]);

                sigZ.YAxisIndex = 0;
                plt.YAxis.Label("Generación Z");
                plt.YAxis.Color(sigZ.Color);

                sigM.YAxisIndex = 1;
                plt.AddAxis(ScottPlot.Renderable.Edge.Right, axisIndex: 2);
                plt.YAxis2.Label("Millennials");
                plt.YAxis2.Color(sigM.Color);
                plt.YAxis2.Ticks(true);

                sigX.YAxisIndex = 2;
                var yAxisGenX = plt.AddAxis(ScottPlot.Renderable.Edge.Left, axisIndex: 3);
                yAxisGenX.Label("Generación X");
                yAxisGenX.Color(sigX.Color);
                yAxisGenX.Ticks(true);

                plt.XTicks(new double[] { 0, 1, 2 }, labels);
                plt.Title("Generación que Más Usa Cada Servicio de Streaming");
            }

            pictureBox.Image = plt.Render();
        }

        // Luego, puedes llamar a este método para cada gráfico que deseas crear:

        private void CreateGraphStr()
        {
            double[] pieValues = { 40, 30, 30 };
            string[] pieLabels = { "Generación Z (Netflix)", "Millennials (Amazon)", "Generación X (Disney+)" };
            CreateGraphSt(pictureBoxRedes2, "Pie", pieValues, pieLabels);

            double[] barValues = { 2.9, 1.2, 1.3 }; // Asegúrate de actualizar estos valores con los datos reales
            string[] barLabels = { "Netflix", "Amazon", "Disney+" };
            CreateGraphSt(pictureBoxRedes, "Bar", barValues, barLabels);

            double[] genZ = { 40, 60, 20 }; // Asegúrate de actualizar estos valores con los datos reales
            double[] millennials = { 30, 30, 50 }; // Asegúrate de actualizar estos valores con los datos reales
            double[] genX = { 30, 10, 30 }; // Asegúrate de actualizar estos valores con los datos reales
            double[][] multiAxisValues = { genZ, millennials, genX };
            string[] multiAxisLabels = { "Netflix", "Amazon", "Disney+" };
            CreateGraphSt(pictureBoxRedes3, "MultiAxis", null, multiAxisLabels, multiAxisValues);
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
    }
}
