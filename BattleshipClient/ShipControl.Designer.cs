namespace BattleshipClient {
	partial class ShipControl {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipControl));
			this.label1 = new System.Windows.Forms.Label();
			this.aircraftcarrier = new System.Windows.Forms.Button();
			this.battleship = new System.Windows.Forms.Button();
			this.cruiser = new System.Windows.Forms.Button();
			this.destroyer = new System.Windows.Forms.Button();
			this.submarine = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ships";
			// 
			// aircraftcarrier
			// 
			this.aircraftcarrier.Image = ((System.Drawing.Image)(resources.GetObject("aircraftcarrier.Image")));
			this.aircraftcarrier.Location = new System.Drawing.Point(7, 20);
			this.aircraftcarrier.Name = "aircraftcarrier";
			this.aircraftcarrier.Size = new System.Drawing.Size(150, 50);
			this.aircraftcarrier.TabIndex = 2;
			this.aircraftcarrier.UseVisualStyleBackColor = true;
			this.aircraftcarrier.Click += new System.EventHandler(this.aircraftcarrier_Click);
			// 
			// battleship
			// 
			this.battleship.Image = ((System.Drawing.Image)(resources.GetObject("battleship.Image")));
			this.battleship.Location = new System.Drawing.Point(163, 20);
			this.battleship.Name = "battleship";
			this.battleship.Size = new System.Drawing.Size(150, 50);
			this.battleship.TabIndex = 3;
			this.battleship.UseVisualStyleBackColor = true;
			this.battleship.Click += new System.EventHandler(this.battleship_Click);
			// 
			// cruiser
			// 
			this.cruiser.Image = ((System.Drawing.Image)(resources.GetObject("cruiser.Image")));
			this.cruiser.Location = new System.Drawing.Point(319, 20);
			this.cruiser.Name = "cruiser";
			this.cruiser.Size = new System.Drawing.Size(150, 50);
			this.cruiser.TabIndex = 4;
			this.cruiser.UseVisualStyleBackColor = true;
			this.cruiser.Click += new System.EventHandler(this.cruiser_Click);
			// 
			// destroyer
			// 
			this.destroyer.Image = ((System.Drawing.Image)(resources.GetObject("destroyer.Image")));
			this.destroyer.Location = new System.Drawing.Point(7, 76);
			this.destroyer.Name = "destroyer";
			this.destroyer.Size = new System.Drawing.Size(150, 50);
			this.destroyer.TabIndex = 5;
			this.destroyer.UseVisualStyleBackColor = true;
			this.destroyer.Click += new System.EventHandler(this.destroyer_Click);
			// 
			// submarine
			// 
			this.submarine.Image = ((System.Drawing.Image)(resources.GetObject("submarine.Image")));
			this.submarine.Location = new System.Drawing.Point(163, 76);
			this.submarine.Name = "submarine";
			this.submarine.Size = new System.Drawing.Size(150, 50);
			this.submarine.TabIndex = 6;
			this.submarine.UseVisualStyleBackColor = true;
			this.submarine.Click += new System.EventHandler(this.submarine_Click);
			// 
			// ShipControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.submarine);
			this.Controls.Add(this.destroyer);
			this.Controls.Add(this.cruiser);
			this.Controls.Add(this.battleship);
			this.Controls.Add(this.aircraftcarrier);
			this.Controls.Add(this.label1);
			this.Name = "ShipControl";
			this.Size = new System.Drawing.Size(477, 134);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button aircraftcarrier;
		private System.Windows.Forms.Button battleship;
		private System.Windows.Forms.Button cruiser;
		private System.Windows.Forms.Button destroyer;
		private System.Windows.Forms.Button submarine;
	}
}
