﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wpf_control;

namespace wpf_in_winforms
{
    public partial class GameFrame : Form
    {
        private readonly List<PictureBox> Stars = new List<PictureBox>();
        public GameFrame()
        {
            InitializeComponent();
            eleHost.Child = new GameControl();
            Stars.AddRange(new[] { star1, star2, star3, star4, star5, star6 });
        }
        public void NextQR()
        {
            if (!(eleHost.Child is GameControl game)) return;
            Stars[game.currentImg].Image = Properties.Resources.star;
            if(game.currentImg == 5)
            {
                eleHost.Child = null;
                MessageBox.Show("Chiến thắng!!!", "You won!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            game.RespawnImage();
            game.speedFactor += 0.3;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!(eleHost.Child is GameControl game)) return;
            var currentIndex = cboQRValue.SelectedIndex;
            if (currentIndex == game.currentImg) NextQR();
        }
    }
}
