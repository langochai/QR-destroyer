﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using wpf_in_winforms.Models;
using wpf_in_winforms.UC;

namespace wpf_in_winforms.Forms
{
    public partial class Weapons : Form
    {
        private readonly FrmMain main;
        private List<Scanner> scanners;
        private List<WeaponShowCase> weapons = new List<WeaponShowCase>();
        public Weapons(FrmMain m)
        {
            InitializeComponent();
            this.main = m;
            try
            {
                scanners = GetScanners();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadScannerInfo();
        }

        private void LoadScannerInfo()
        {
            try
            {
                foreach (Scanner scanner in scanners)
                {
                    WeaponShowCase wp = new WeaponShowCase(scanner);
                    this.Controls.Add(wp);
                    weapons.Add(wp);
                }
                for (int i = 0; i < weapons.Count; i++)
                {
                    weapons[i].Size = new Size((this.Width / weapons.Count) - 30, this.Height - (btnStart.Height + 200));
                    weapons[i].Location = new Point((this.Width * i / weapons.Count) + 5, 10);
                }
            }
            catch
            {
            }
        }
        public static List<Scanner> GetScanners()
        {
            string settingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scanner.json");
            if (File.Exists(settingsFilePath))
            {
                string jsonString = File.ReadAllText(settingsFilePath);
                var scanner = JsonConvert.DeserializeObject<List<Scanner>>(jsonString)
                    ?? throw new InvalidOperationException("Không tìm thấy thông tin Scanner");
                return scanner;
            }
            else
            {
                throw new FileNotFoundException("Không tìm được file Scanner.json");
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Weapons_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var weapon in weapons) { weapon.TurnOffVid(); }
        }
    }
}