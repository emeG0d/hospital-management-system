﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system.gui.components
{
    public partial class InformationComboBox : UserControl
    {
        public InformationComboBox()
        {
            InitializeComponent();
        }

        public String LabelText {
            get { return Label.Text; }
            set { Label.Text = value; } 
        }

        public float ColumnWidth0 {
            get { return TableLayout.ColumnStyles[0].Width; }
            set { TableLayout.ColumnStyles[0].Width = value; } 
        }

        public object getSelectedValue()
        {
            return ComboBox.SelectedValue;
        }

        public void setValueMemebr(string value)
        {
            ComboBox.ValueMember = value;
        }

        public void setDisplayMemebr(string value)
        {
            ComboBox.DisplayMember = value;
        }

        public void setDataSource(List<object> value)
        {
            ComboBox.DataSource = value;
        }

    }
}
