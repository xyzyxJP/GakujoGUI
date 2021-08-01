﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace GakujoGUI
{
    public partial class QuizForm : MaterialForm
    {
        public string inputHtml;
        public string outputText;

        public QuizForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.Blue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
        }

        public DialogResult Set(string message, string html)
        {
            DialogResult dialogResult = DialogResult.None;
            Text = message;
            inputHtml = html;
            return dialogResult;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonFile_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private async void QuizForm_Load(object sender, EventArgs e)
        {
            await webView2.EnsureCoreWebView2Async();
            webView2.NavigateToString(inputHtml);
        }

        private void webView2_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            outputText = e.TryGetWebMessageAsString();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}