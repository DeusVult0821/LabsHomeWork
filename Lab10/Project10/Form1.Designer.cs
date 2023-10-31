namespace Project10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            перваяФормаToolStripMenuItem = new ToolStripMenuItem();
            стилиИзображенийToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            втораяФормаToolStripMenuItem = new ToolStripMenuItem();
            calculationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { перваяФормаToolStripMenuItem, втораяФормаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // перваяФормаToolStripMenuItem
            // 
            перваяФормаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { стилиИзображенийToolStripMenuItem });
            перваяФормаToolStripMenuItem.Name = "перваяФормаToolStripMenuItem";
            перваяФормаToolStripMenuItem.Size = new Size(100, 20);
            перваяФормаToolStripMenuItem.Text = "Первая форма";
            // 
            // стилиИзображенийToolStripMenuItem
            // 
            стилиИзображенийToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arrangeIconsToolStripMenuItem, cascadeToolStripMenuItem, tileHorizontalToolStripMenuItem, tileVerticalToolStripMenuItem });
            стилиИзображенийToolStripMenuItem.Name = "стилиИзображенийToolStripMenuItem";
            стилиИзображенийToolStripMenuItem.Size = new Size(186, 22);
            стилиИзображенийToolStripMenuItem.Text = "Стили изображений";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(147, 22);
            arrangeIconsToolStripMenuItem.Text = "ArrangeIcons";
            arrangeIconsToolStripMenuItem.Click += arrangeIconsToolStripMenuItem_Click;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(147, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(147, 22);
            tileHorizontalToolStripMenuItem.Text = "TileHorizontal";
            tileHorizontalToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(147, 22);
            tileVerticalToolStripMenuItem.Text = "TileVertical";
            tileVerticalToolStripMenuItem.Click += tileVerticalToolStripMenuItem_Click;
            // 
            // втораяФормаToolStripMenuItem
            // 
            втораяФормаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculationToolStripMenuItem });
            втораяФормаToolStripMenuItem.Name = "втораяФормаToolStripMenuItem";
            втораяФормаToolStripMenuItem.Size = new Size(98, 20);
            втораяФормаToolStripMenuItem.Text = "Вторая форма";
            // 
            // calculationToolStripMenuItem
            // 
            calculationToolStripMenuItem.Name = "calculationToolStripMenuItem";
            calculationToolStripMenuItem.Size = new Size(180, 22);
            calculationToolStripMenuItem.Text = "Calculation";
            calculationToolStripMenuItem.Click += calculationToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem перваяФормаToolStripMenuItem;
        private ToolStripMenuItem стилиИзображенийToolStripMenuItem;
        private ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem втораяФормаToolStripMenuItem;
        private ToolStripMenuItem calculationToolStripMenuItem;
    }
}