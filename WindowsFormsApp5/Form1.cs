using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            odczytzpliku();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Dodawanie podgałęzi";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Nodes.Add(dialog.nazwa);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Zapisać zmiany przed zamknięciem?", "Zamykanie", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                zapisdopliku();
                Application.Exit();
            }
            else if (res == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private TreeNode ZnajdzRodzica(TreeNode node, string rodzic)
        {
            TreeNode wynik = null;
            if (node == null)
                return null;
            if (node.Text == rodzic)
                return node;

            if (node.NextNode != null)
                wynik = ZnajdzRodzica(node.NextNode, rodzic);
            if (node.GetNodeCount(true) > 0)
                wynik = ZnajdzRodzica(node.FirstNode, rodzic);

            return wynik;

        }

        private void odczytzpliku()
       {
            treeView1.Nodes.Clear();
            List<myNode> lista = new List<myNode>();
            string[] tab = File.ReadAllLines("firma.txt");
            foreach (string elem in tab)
            {
                string[] pom = elem.Split(' ');
                lista.Add(new myNode(pom[1], pom[0]));

            }
            foreach (myNode node in lista)
            {
                if (node.rodzic == "brak")
                    treeView1.Nodes.Add(new TreeNode(node.nazwa));
                else
                {
                    TreeNode rodzic = ZnajdzRodzica(treeView1.Nodes[0],node.rodzic);
                    if (rodzic != null)
                        rodzic.Nodes.Add(node.nazwa);
                }
            }


        }
        private TreeNode znajdzrodzica(string rodzic)
        {
            return null;
        }
        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Dodawnanie gałęzi";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Add(dialog.nazwa);
            }

        }
        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void zmieńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Modyfikowanie gałęzi";
            dialog.nazwa = treeView1.SelectedNode.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Text = dialog.nazwa;
            }
        }
        private void dodajdolisty(TreeNode node, ref List<myNode> lista)
        {
            if (node == null)
                return;
            string r, n;
            if (node.Parent == null)
                r = "brak";
            else

                r = node.Parent.Text;
            n = node.Text;

            lista.Add(new myNode(r, n));
            if (node.NextNode != null)
                dodajdolisty(node.NextNode, ref lista);
            if (node.GetNodeCount(true) > 0)
                dodajdolisty(node.FirstNode, ref lista);
        }

        private void zapisdopliku()
        {

            List<myNode> lista = new List<myNode>();
            dodajdolisty(treeView1.Nodes[0], ref lista);
            if (lista.Count == 0)
                return;

            string text = "";
            foreach (myNode elem in lista)
            {
                text += elem.nazwa + " " + elem.rodzic + "\n";
            }
            File.WriteAllText("firma.txt", text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            zapisdopliku();
            Application.Exit();
        }
    }
    public class myNode
    {
        public string rodzic;
        public string nazwa;


        public myNode(string rodzic, string nazwa)
        {
            this.rodzic = rodzic;
            this.nazwa = nazwa;
        }
    }

}
