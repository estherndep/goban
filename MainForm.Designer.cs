namespace Goban
{
	partial class MainForm
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
			this.panelMain = new System.Windows.Forms.Panel();
			this.buttonClearBoard = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Margin = new System.Windows.Forms.Padding(2);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(536, 548);
			this.panelMain.TabIndex = 0;
			// 
			// buttonClearBoard
			// 
			this.buttonClearBoard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonClearBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClearBoard.Location = new System.Drawing.Point(0, 548);
			this.buttonClearBoard.Name = "buttonClearBoard";
			this.buttonClearBoard.Size = new System.Drawing.Size(536, 23);
			this.buttonClearBoard.TabIndex = 1;
			this.buttonClearBoard.Text = "Clear Board";
			this.buttonClearBoard.UseVisualStyleBackColor = true;
			this.buttonClearBoard.Click += new System.EventHandler(this.buttonClearBoard_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 571);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.buttonClearBoard);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Goban";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button buttonClearBoard;
	}
}