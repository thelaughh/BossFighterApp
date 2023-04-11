using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic;
using Bossfighter;
using RomanNumerals;

namespace Bossfighter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lbl1.Content = Help.ins.name;
        }
        
        

        private void Button_OnFight(object sender, RoutedEventArgs e)
        {
            Help.ins.healthBoss -= Help.ins.attack;

            Prgs.Value = Help.ins.healthBoss;

            if (Prgs.Value <= 0)
            {
                MessageBox.Show("Boss prohrál a ty jsi vyhrál a postupuješ dál");
                Help.ins.healthBoss = 200;
                Help.ins.health = 200;

                Prg.Value = Help.ins.health;
                Prgs.Value = Help.ins.healthBoss;
                BossFighterEnd bossFighterEnd = new BossFighterEnd();
                bossFighterEnd.Show();
                Close();

            }
           

        }

        private void ButtonBase_OnHeal(object sender, RoutedEventArgs e)
        {
            //viditelnost
            Fight.Visibility = Visibility.Hidden;
            Prote.Visibility = Visibility.Hidden;
            Healus.Visibility = Visibility.Hidden;



            Help.ins.health += Help.ins.heal;

            Prg.Value  = Help.ins.health;
             
            MessageBox.Show($"Bylo ti přidáno {Help.ins.heal} Hp");

        }

        private void ButtonBase_OnProtect(object sender, RoutedEventArgs e)
        {
            Help.ins.block = 1;


        }

        private void Button_OnPressed(object sender, RoutedEventArgs e)
        {
            if(Help.ins.block == 1)
            {
                int blokovani = Help.ins.block - Help.ins.attackBoss;

                Help.ins.healthBoss -= blokovani;
                Help.ins.block = 0;


                Prg.Value = Help.ins.health;
                if (Prg.Value <= 0)
                {
                    MessageBox.Show("Prohrál jsi LOL");
                  
                }

            }
            else
            {
                Help.ins.health -= Help.ins.attackBoss;
                Prg.Value = Help.ins.health;
                MessageBox.Show($"Boss ti ubral {Help.ins.attackBoss} hp");
            }

            Fight.Visibility = Visibility.Hidden;
            Prote.Visibility = Visibility.Hidden;
            Healus.Visibility = Visibility.Hidden;






        }

    }
}
