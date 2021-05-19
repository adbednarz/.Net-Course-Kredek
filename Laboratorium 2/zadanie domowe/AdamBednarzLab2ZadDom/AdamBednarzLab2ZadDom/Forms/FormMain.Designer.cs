
namespace AdamBednarzLab2ZadDom
{
    partial class FormMain
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonMountains = new System.Windows.Forms.Button();
            this.buttonMountainRanges = new System.Windows.Forms.Button();
            this.buttonPeaks = new System.Windows.Forms.Button();
            this.buttonRiverSprings = new System.Windows.Forms.Button();
            this.buttonLocalities = new System.Windows.Forms.Button();
            this.buttonNationalParks = new System.Windows.Forms.Button();
            this.buttonTouristAttractions = new System.Windows.Forms.Button();
            this.buttonMinerals = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMountainRange = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMountainRange = new System.Windows.Forms.TextBox();
            this.textBoxPopulation = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonEraseFields = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 42);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(643, 145);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // buttonMountains
            // 
            this.buttonMountains.Location = new System.Drawing.Point(13, 13);
            this.buttonMountains.Name = "buttonMountains";
            this.buttonMountains.Size = new System.Drawing.Size(56, 23);
            this.buttonMountains.TabIndex = 1;
            this.buttonMountains.Text = "Góry";
            this.buttonMountains.UseVisualStyleBackColor = true;
            this.buttonMountains.Click += new System.EventHandler(this.ButtonMountains_Click);
            // 
            // buttonMountainRanges
            // 
            this.buttonMountainRanges.Location = new System.Drawing.Point(75, 13);
            this.buttonMountainRanges.Name = "buttonMountainRanges";
            this.buttonMountainRanges.Size = new System.Drawing.Size(60, 23);
            this.buttonMountainRanges.TabIndex = 2;
            this.buttonMountainRanges.Text = "Pasma ";
            this.buttonMountainRanges.UseVisualStyleBackColor = true;
            this.buttonMountainRanges.Click += new System.EventHandler(this.ButtonMountainRanges_Click);
            // 
            // buttonPeaks
            // 
            this.buttonPeaks.Location = new System.Drawing.Point(141, 13);
            this.buttonPeaks.Name = "buttonPeaks";
            this.buttonPeaks.Size = new System.Drawing.Size(62, 23);
            this.buttonPeaks.TabIndex = 3;
            this.buttonPeaks.Text = "Szczyty";
            this.buttonPeaks.UseVisualStyleBackColor = true;
            this.buttonPeaks.Click += new System.EventHandler(this.ButtonPeaks_Click);
            // 
            // buttonRiverSprings
            // 
            this.buttonRiverSprings.Location = new System.Drawing.Point(209, 13);
            this.buttonRiverSprings.Name = "buttonRiverSprings";
            this.buttonRiverSprings.Size = new System.Drawing.Size(75, 23);
            this.buttonRiverSprings.TabIndex = 4;
            this.buttonRiverSprings.Text = "Źródła";
            this.buttonRiverSprings.UseVisualStyleBackColor = true;
            this.buttonRiverSprings.Click += new System.EventHandler(this.ButtonRiverSprings_Click);
            // 
            // buttonLocalities
            // 
            this.buttonLocalities.Location = new System.Drawing.Point(290, 13);
            this.buttonLocalities.Name = "buttonLocalities";
            this.buttonLocalities.Size = new System.Drawing.Size(89, 23);
            this.buttonLocalities.TabIndex = 5;
            this.buttonLocalities.Text = "Miejscowości";
            this.buttonLocalities.UseVisualStyleBackColor = true;
            this.buttonLocalities.Click += new System.EventHandler(this.ButtonLocalities_Click);
            // 
            // buttonNationalParks
            // 
            this.buttonNationalParks.Location = new System.Drawing.Point(385, 13);
            this.buttonNationalParks.Name = "buttonNationalParks";
            this.buttonNationalParks.Size = new System.Drawing.Size(108, 23);
            this.buttonNationalParks.TabIndex = 6;
            this.buttonNationalParks.Text = "Parki narodowe";
            this.buttonNationalParks.UseVisualStyleBackColor = true;
            this.buttonNationalParks.Click += new System.EventHandler(this.ButtonNationalParks_Click);
            // 
            // buttonTouristAttractions
            // 
            this.buttonTouristAttractions.Location = new System.Drawing.Point(499, 13);
            this.buttonTouristAttractions.Name = "buttonTouristAttractions";
            this.buttonTouristAttractions.Size = new System.Drawing.Size(75, 23);
            this.buttonTouristAttractions.TabIndex = 7;
            this.buttonTouristAttractions.Text = "Atrakcje";
            this.buttonTouristAttractions.UseVisualStyleBackColor = true;
            this.buttonTouristAttractions.Click += new System.EventHandler(this.ButtonTouristAttractions_Click);
            // 
            // buttonMinerals
            // 
            this.buttonMinerals.Location = new System.Drawing.Point(580, 13);
            this.buttonMinerals.Name = "buttonMinerals";
            this.buttonMinerals.Size = new System.Drawing.Size(75, 23);
            this.buttonMinerals.TabIndex = 8;
            this.buttonMinerals.Text = "Minerały";
            this.buttonMinerals.UseVisualStyleBackColor = true;
            this.buttonMinerals.Click += new System.EventHandler(this.ButtonMinerals_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 230);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 15);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "Id:";
            this.labelId.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 275);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 15);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Nazwa:";
            this.labelName.Visible = false;
            // 
            // labelMountainRange
            // 
            this.labelMountainRange.AutoSize = true;
            this.labelMountainRange.Location = new System.Drawing.Point(12, 316);
            this.labelMountainRange.Name = "labelMountainRange";
            this.labelMountainRange.Size = new System.Drawing.Size(46, 15);
            this.labelMountainRange.TabIndex = 11;
            this.labelMountainRange.Text = "Pasmo:";
            this.labelMountainRange.Visible = false;
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(13, 359);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(62, 15);
            this.labelPopulation.TabIndex = 12;
            this.labelPopulation.Text = "Populacja:";
            this.labelPopulation.Visible = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(100, 230);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 23);
            this.textBoxId.TabIndex = 13;
            this.textBoxId.Visible = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 267);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 15;
            this.textBoxName.Visible = false;
            // 
            // textBoxMountainRange
            // 
            this.textBoxMountainRange.Location = new System.Drawing.Point(100, 308);
            this.textBoxMountainRange.Name = "textBoxMountainRange";
            this.textBoxMountainRange.Size = new System.Drawing.Size(100, 23);
            this.textBoxMountainRange.TabIndex = 16;
            this.textBoxMountainRange.Visible = false;
            // 
            // textBoxPopulation
            // 
            this.textBoxPopulation.Location = new System.Drawing.Point(100, 351);
            this.textBoxPopulation.Name = "textBoxPopulation";
            this.textBoxPopulation.Size = new System.Drawing.Size(100, 23);
            this.textBoxPopulation.TabIndex = 17;
            this.textBoxPopulation.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(248, 230);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Usuń miejścowość";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(248, 267);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(131, 23);
            this.buttonEdit.TabIndex = 19;
            this.buttonEdit.Text = "Edytuj miejscowość";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonEraseFields
            // 
            this.buttonEraseFields.Location = new System.Drawing.Point(248, 308);
            this.buttonEraseFields.Name = "buttonEraseFields";
            this.buttonEraseFields.Size = new System.Drawing.Size(131, 23);
            this.buttonEraseFields.TabIndex = 20;
            this.buttonEraseFields.Text = "Wyczyść pola";
            this.buttonEraseFields.UseVisualStyleBackColor = true;
            this.buttonEraseFields.Visible = false;
            this.buttonEraseFields.Click += new System.EventHandler(this.ButtonEraseFields_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(248, 351);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 23);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Dodaj miejscowość";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEraseFields);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxPopulation);
            this.Controls.Add(this.textBoxMountainRange);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.labelMountainRange);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonMinerals);
            this.Controls.Add(this.buttonTouristAttractions);
            this.Controls.Add(this.buttonNationalParks);
            this.Controls.Add(this.buttonLocalities);
            this.Controls.Add(this.buttonRiverSprings);
            this.Controls.Add(this.buttonPeaks);
            this.Controls.Add(this.buttonMountainRanges);
            this.Controls.Add(this.buttonMountains);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormMain";
            this.Text = "Adam Bednarz - Zadanie domowe 2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonMountains;
        private System.Windows.Forms.Button buttonMountainRanges;
        private System.Windows.Forms.Button buttonPeaks;
        private System.Windows.Forms.Button buttonRiverSprings;
        private System.Windows.Forms.Button buttonLocalities;
        private System.Windows.Forms.Button buttonNationalParks;
        private System.Windows.Forms.Button buttonTouristAttractions;
        private System.Windows.Forms.Button buttonMinerals;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMountainRange;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMountainRange;
        private System.Windows.Forms.TextBox textBoxPopulation;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonEraseFields;
        private System.Windows.Forms.Button buttonAdd;
    }
}

