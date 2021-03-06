﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Xenia.Debug.UI.Controls;

namespace Xenia.Debug.UI.Views {
  public partial class FunctionsPanel : BasePanel {
    private readonly Debugger debugger;

    public FunctionsPanel(Debugger debugger) {
      InitializeComponent();
      this.debugger = debugger;

      debugger.ModuleList.Changed += UpdateModulesList;
      UpdateModulesList();
    }

    private void UpdateModulesList() {
      modulesComboBox.BeginUpdate();
      modulesComboBox.Items.Clear();
      foreach (Module module in debugger.ModuleList) {
        modulesComboBox.Items.Add("Module A");
      }
      modulesComboBox.EndUpdate();
    }
  }
}
