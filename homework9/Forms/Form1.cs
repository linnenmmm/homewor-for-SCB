﻿using Crawlerapp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerForm
{
    public partial class Form1 : Form
    {
        Crawler.CrawlerClass crawlerClass = new CrawlerClass();
        public Form1()
        {
            InitializeComponent();
            bindingSource1.Add(crawlerClass);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(CrawlerClass.Crawl);
            t.Start();
        }
    }
}
