namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Maszyny");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Elektronika");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Produkcja", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sprzedaż");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Firma", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Prezes");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Rada");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Zarząd", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.dodajToolStripMenuItem1,
            this.usuńToolStripMenuItem,
            this.zmieńToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj gałąź";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.dodajToolStripMenuItem1.Text = "Dodaj podgałąź";
            this.dodajToolStripMenuItem1.Click += new System.EventHandler(this.dodajToolStripMenuItem1_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // zmieńToolStripMenuItem
            // 
            this.zmieńToolStripMenuItem.Name = "zmieńToolStripMenuItem";
            this.zmieńToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.zmieńToolStripMenuItem.Text = "Zmień";
            this.zmieńToolStripMenuItem.Click += new System.EventHandler(this.zmieńToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.treeView1.LineColor = System.Drawing.Color.DeepPink;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Węzeł2";
            treeNode1.Text = "Maszyny";
            treeNode2.Name = "Węzeł3";
            treeNode2.Text = "Elektronika";
            treeNode3.Name = "Węzeł1";
            treeNode3.Text = "Produkcja";
            treeNode4.Name = "Węzeł2";
            treeNode4.Text = "Sprzedaż";
            treeNode5.Name = "Węzeł0";
            treeNode5.Text = "Firma";
            treeNode6.Name = "Węzeł5";
            treeNode6.Text = "Prezes";
            treeNode7.Name = "Węzeł6";
            treeNode7.Text = "Rada";
            treeNode8.Name = "Węzeł4";
            treeNode8.Text = "Zarząd";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(441, 426);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Fortnite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

