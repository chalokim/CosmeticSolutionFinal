﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CosmeticSolutionFinal.Data;
using System.Data.Entity;
using DevExpress.XtraMap;

namespace CosmeticSolutionFinal
{
    public partial class Recommendation500mAreaMap : Form
    {

        public Recommendation500mAreaMap()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            CosmeticSolutionFinal.Data.CosmeticFinalEntities dbContext = new CosmeticSolutionFinal.Data.CosmeticFinalEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Branches.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    branchesBindingSource.DataSource = dbContext.Branches.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Recommendation500mAreaMap_Load(object sender, EventArgs e)
        {
            InitializeComponent();


        }

        private void bingSearchDataProvider1_SearchCompleted(object sender, DevExpress.XtraMap.BingSearchCompletedEventArgs e)
        {
            mapControl1.ZoomToFitLayerItems(0.5);
        }

        private void comboSearch_Click(object sender, EventArgs e)
        {

            List<string> list = StationDao.

            List<string> cities = Dao.Route.GetDepartureCities();
            foreach (var city in cities)
                comboDeparture.Items.Add(city);

        }
    }
}
